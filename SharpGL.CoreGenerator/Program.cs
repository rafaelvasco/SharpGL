using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SharpGL.CoreGenerator
{
    class Program
    {
        private static int unknowns;

        private static readonly HashSet<string> ExploredFunctions = new HashSet<string>();

        static void Main()
        {

            using (StreamReader stream = new StreamReader("OpenGL4.txt"))
            using (StreamWriter output = new StreamWriter("GLCore.cs"))
            using (StreamWriter errors = new StreamWriter("errors.txt"))
            {
                output.WriteLine(@"using System;
using System.Runtime.InteropServices;

namespace SharpGL
{
    partial class GL
    {
        internal static partial class NativeMethods
        {");
                while (!stream.EndOfStream)
                {
                    string function = stream.ReadLine();

                    if (ExploredFunctions.Contains(function)) continue;
                  
                    if (function != null && function.Contains("Debug")) continue;

                    string page = LoadManPage(function);

                    var reader = new StringReader(page);
                    var funcdef = string.Empty;
                    var paramTypes = new List<string>();
                    var paramNames = new List<string>();

                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (string.IsNullOrEmpty(line)) break;

                        if (line.Contains("funcdef"))
                        {
                            if (paramTypes.Count != 0)
                            {
                                WriteBinding(function, funcdef, paramTypes, paramNames, output);

                                paramTypes.Clear();
                                paramNames.Clear();
                            }

                            funcdef = line.Substring(line.IndexOf("<code class=\"funcdef\">") + 22);
                            funcdef = funcdef.Substring(0, funcdef.IndexOf('<')).Trim();
                            funcdef = (funcdef == "void" ? "void" : GetCSharpType(funcdef));

                            function = line.Substring(line.IndexOf("fsfunc") + 8);
                            function = function.Substring(0, function.IndexOf('<'));

                            if (function.StartsWith("glGetString")) funcdef = "IntPtr";

                            if (funcdef == "Unknown")
                            {
                                if (function.Contains("FramebufferStatus")) funcdef = "FramebufferErrorCode";
                                else if (function.Contains("ClientWaitSync")) funcdef = "ArbSync";
                                else if (function.Contains("GetError")) funcdef = "ErrorCode";
                                else if (function.Contains("GetGraphicsResetStatus")) funcdef = "GraphicResetStatus";
                            }
                        }
                        else if (line.Contains("pdparam"))
                        {
                            if (line.Contains("void") && !line.Contains("*"))
                            {
                                output.WriteLine("            [DllImport(GL.Library, EntryPoint = \"{0}\", ExactSpelling = true)]", function);
                                output.WriteLine("            internal extern static {0} {1}();", funcdef, function.Substring(2));
                                if (funcdef == "Unknown") unknowns++;
                                continue;
                            }

                            string paramType = line.Substring(line.IndexOf("<td>") + 4);
                            paramType = paramType.Substring(0, paramType.IndexOf('<')).Trim('<');

                            string paramName = line.Substring(line.IndexOf("<var class=\"pdparam\">") + 21);
                            paramName = paramName.Substring(0, paramName.IndexOf('<'));
                            paramName = paramName.Trim('.'); // to remove a trailing . from glTextureParameterfv

                            if (paramName.ToLower() == "internalformat") paramName = "internalFormat";
                            if (paramName == "internalFormat" && paramType.Trim() == "GLint") paramType = "GLenum";
                            if (paramName == "mask" && paramType.StartsWith("GL")) paramType = "GLenum";
                            if (paramName == "access" && function.Contains("MapBuffer")) paramType = "GLenum";
                            if (paramName == "framebuffer" && function.Contains("NamedFramebufferReadBuffer")) paramType = "GLenum";

                            string csharpType = GetCSharpType(paramType);
                            if (csharpType == "Unknown") csharpType = GetUnknownType(paramName, function);
                            if (csharpType == "Unknown[]")
                            {
                                if (function == "glTextureParameterfv") csharpType = "Single[]";    
                                else csharpType = GetUnknownType(paramName, function) + "[]";
                            }
                            if (csharpType.Contains("[]") || csharpType == "IntPtr")
                            {
                                if (function.Contains("Gen") || function.Contains("Get") || function.Contains("Read"))
                                {
                                    if (((paramName == "size" || paramName == "offset") && function.Contains("SubData")) ||
                                        (paramName == "sync" && function.Contains("GetSynciv")))
                                    {

                                    }
                                    else
                                    {
                                        csharpType = "[OutAttribute] " + csharpType;
                                    }
                                }
                            }
                            if (paramName == "varyings") csharpType = "String[]";
                            if (paramName == "string" && function.Contains("ShaderSource")) csharpType = "String[]";
                            if (paramName == "data" && function.Contains("Pixels")) csharpType = "Int32[]";
                            paramTypes.Add(csharpType);

                            if (paramName == "params") paramName = "@params";
                            if (paramName == "ref") paramName = "@ref";
                            if (paramName == "string") paramName = "@string";
                            if (paramName == "bifSize") paramName = "bufSize";
                            paramNames.Add(paramName);
                        }
                    }

                    if (paramTypes.Count != 0)
                        WriteBinding(function, funcdef, paramTypes, paramNames, output);
                }

                output.WriteLine(@"        }
    }
}");
            }

            Console.WriteLine("Total unknowns: {0}", unknowns);
        }

        /// <summary>
        /// Attempt to get a man page from cache.
        /// If it is not cached then try to load it from the web and cache it.
        /// </summary>
        /// <param name="function">The OpenGL function name to load a man page for.</param>
        /// <returns>The contents of the man page, or string.Empty if failed.</returns>
        private static string LoadManPage(string function)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (!Directory.Exists("cache")) Directory.CreateDirectory("cache");

                    if (File.Exists("cache/" + function + ".xhtml")) return File.ReadAllText("cache/" + function + ".xhtml");
                    else
                    {
                        string page = client.DownloadString("https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/" + function + ".xhtml");
                        File.WriteAllText("cache/" + function + ".xhtml", page);
                        return page;
                    }
                }
                catch (Exception)
                {
                    // likely a 404
                    Console.WriteLine("Could not load function " + function);
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// If the OpenGL type was not a valid type then we figure out what to do with it here.
        /// Use GlCoreOld as a first pass, and then use some simple rules for the rest.
        /// This could be optimized big time because we're constantly exploring all of GlCoreOld.txt.
        /// </summary>
        /// <param name="glName">The OpenGL type to find a C# equivalent for.</param>
        /// <param name="functionName">The function name of the OpenGL function, which helps track down the type.</param>
        /// <returns>The C# equivalent of the OpenGL type.</returns>
        private static string GetUnknownType(string glName, string functionName)
        {
            if (functionName.Contains("Hint") && glName == "target") return "HintTarget";
            if (functionName.Contains("glTexParameter") && glName == "pname") return "TextureParameterName";
            if (functionName.Contains("SamplerParameter") && glName == "pname") return "TextureParameterName";

            using (StreamReader stream = new StreamReader("GLCoreOld.txt"))
            {
                string fname = functionName.Substring(2);

                if (fname == "ReadnPixels") fname = "ReadPixels";

                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();

                    if ((line.Contains(fname) || line.Contains(fname.Replace("Named", ""))) && line.Contains(glName))
                    {
                        string[] split = line.Split(new char[] { '(', ',', ' ', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < split.Length; i++)
                            if (split[i] == glName && split[i - 1] != "IntPtr") return split[i - 1].Trim('[', ']');
                    }
                }
            }

            if (glName == "cap") return "EnableCap";
            if (functionName.Contains("DrawBuffer") && glName.StartsWith("buf")) return "DrawBufferMode";
            if (functionName.StartsWith("glGetString") && glName == "name") return "StringName";
            if (glName.ToLower() == "shadertype") return "ShaderType";
            if (glName == "mode" &&
                (functionName.StartsWith("glDraw") || functionName.StartsWith("glMultiDraw") || functionName.Contains("NamedFramebufferReadBuffer"))) return "BeginMode";
            if (glName == "target")
            {
                if (functionName.Contains("Query")) return "QueryTarget";
                if (functionName.Contains("Buffer")) return "BufferTarget";
                if (functionName.Contains("Framebuffer")) return "FramebufferTarget";
                if (functionName.Contains("Renderbuffer")) return "RenderbufferTarget";
                if (functionName.Contains("Texture")) return "TextureTarget";
                if (functionName.Contains("TransformFeedback")) return "NvTransformFeedback2";
                if (functionName.Contains("TexParameter") || functionName.Contains("TexStorage") ||
                    functionName.Contains("TexImage") || functionName.Contains("TexSubImage") ||
                    functionName.Contains("GetInternalformat")) return "TextureTarget";
                if (functionName.StartsWith("glCreateQueries")) return "QueryTarget";
                if (functionName.StartsWith("glGet")) return "GetPName";
            }
            if (glName == "type")
            {
                if (functionName.Contains("VertexAttribP")) return "VertexAttribPType";
                if (functionName.Contains("VertexAttrib") && functionName.Contains("Pointer")) return "VertexAttribPointerType";
                if ((functionName.Contains("VertexAttrib") || functionName.Contains("VertexArrayAttrib")) && functionName.Contains("Format")) return "SharpGL.VertexAttribFormat";
                if (functionName.Contains("CreateShaderProgramv")) return "ShaderType";
                if (functionName.StartsWith("glDraw")) return "DrawElementsType";
            }
            if (glName == "pname")
            {
                if (functionName.Contains("glTextureParameter")) return "TextureParameter";
                if (functionName.Contains("glTexParameter")) return "TextureParameterName";
                if (functionName.Contains("SamplerParameter")) return "TextureParameterName";
                if (functionName.Contains("glGetTexParameter")) return "GetTextureParameter";
                if (functionName.Contains("glGetTextureParameter")) return "GetTextureParameter";
                if (functionName.Contains("PointParameter")) return "PointParameterName";
                if (functionName.Contains("FramebufferParameteri")) return "FramebufferPName";
                if (functionName.Contains("GetActiveAtomicCounterBufferiv")) return "AtomicCounterParameterName";
                if (functionName.Contains("BufferParameter")) return "BufferParameterName";
                if (functionName.Contains("GetTextureLevel")) return "GetTextureLevelParameter";
                if (functionName.Contains("GetTexLevel")) return "GetTextureLevelParameter";
                if (functionName.StartsWith("glGetTransformFeedback")) return "TransformFeedbackParameterName";
                if (functionName.StartsWith("glGetVertexArray")) return "VertexAttribParameter";
                if (functionName.Contains("GetActiveSubroutineUniformiv")) return "SubroutineParameterName";
                if (functionName.Contains("GetActiveUniformsiv")) return "ActiveUniformType";
                if (functionName.Contains("GetInternalformat")) return "GetPName";
                if (functionName.Contains("GetPointerv")) return "GetPointerParameter";
                if (functionName.Contains("GetProgramInterfaceiv")) return "ProgramInterfaceParameterName";
                if (functionName.Contains("GetProgramStageiv")) return "ProgramStageParameterName";
                if (functionName.Contains("GetQuery")) return "GetQueryParam";
            }
            if (glName.ToLower() == "internalformat")
            {
                if (functionName.Contains("TexBuffer") || functionName.Contains("TextureBuffer") ||
                    functionName.Contains("TextureStorage") || functionName.Contains("TexStorage") ||
                    functionName.Contains("ClearBuffer") || functionName.Contains("ClearNamedBuffer")) return "SizedInternalFormat";
                //if (functionName.Contains("TexImage") || functionName.Contains("GetInternalformat") ||
                //    functionName.Contains("TextureView")) return "PixelInternalFormat";

                return "PixelInternalFormat";
            }
            if (glName == "texture" && functionName.Contains("Texture")) return "Int32";
            if (glName == "mode" && functionName.Contains("ConditionalRender")) return "ConditionalRenderType";
            if (glName == "primitiveMode" && functionName.Contains("Feedback")) return "BeginFeedbackMode";
            if (glName == "identifier" && functionName.Contains("ObjectLabel")) return "SharpGL.ObjectLabel";
            if (glName == "access") return "BufferAccess";
            if (glName == "format" && (functionName.Contains("BindImage") || functionName.StartsWith("glClear") ||
                functionName.Contains("CompressedTex"))) return "PixelInternalFormat";
            if (glName == "filter" && functionName.StartsWith("glBlitNamed")) return "BlitFramebufferFilter";
            if (glName == "usage" && functionName.StartsWith("glNamedBufferData")) return "BufferUsageHint";
            if (functionName.StartsWith("glBlend"))
            {
                if (glName == "mode") return "BlendEquationMode";
                if (glName == "sfactor" || glName.StartsWith("src")) return "BlendingFactorSrc";
                if (glName == "dfactor" || glName.StartsWith("dst")) return "BlendingFactorDest";
                if (glName == "modeRGB" || glName == "modeAlpha") return "BlendEquationMode";
            }
            if (glName == "buffer" && functionName.Contains("Clear")) return "ClearBuffer";
            if (glName == "type" && functionName.StartsWith("glClear")) return "PixelType";
            if (functionName == "glClipControl")
            {
                if (glName == "origin") return "ClipControlOrigin";
                else if (glName == "depth") return "ClipControlDepth";
            }
            if (functionName.StartsWith("glCopyImageSubData") && (glName.EndsWith("Target"))) return "BufferTarget";
            if (glName == "attachment" && functionName.Contains("Framebuffer")) return "FramebufferAttachment";
            if (glName == "renderbuffertarget") return "RenderbufferTarget";
            if (glName == "textarget" && functionName.Contains("FramebufferTexture")) return "TextureTarget";
            if (glName == "value" && functionName.Contains("GetBufferParameter")) return "BufferParameterName";
            if (glName == "programInterface") return "ProgramInterface";
            if (functionName.Contains("Image"))
            {
                if (glName == "format") return "PixelFormat";
                if (glName == "type") return "PixelType";
            }
            if (glName == "attachments" && functionName.Contains("Framebuffer")) return "FramebufferAttachment";
            if (glName == "props" && functionName.Contains("GetProgramResourceiv")) return "ProgramResourceParameterName";
            if (functionName.StartsWith("GetString")) return "String";
            if (glName == "framebuffer" && functionName.Contains("NamedFramebufferReadBuffer")) return "ReadBufferMode";

            return "Unknown";
        }

        /// <summary>
        /// Get a C# value type from an input OpenGL type.
        /// This function also deals with some typos and errors in the OpenGL man pages.
        /// </summary>
        /// <param name="glType">The OpenGL type to find a C# equivalent for.</param>
        /// <returns>The C# equivalent of the OpenGL type.</returns>
        private static string GetCSharpType(string glType)
        {
            glType = glType.Trim();

            if (glType.StartsWith("const")) glType = glType.Substring(6);

            if (glType.Contains("*"))
            {
                glType = glType.Trim('*');
                if (glType.Contains(" ")) glType = glType.Substring(0, glType.IndexOf(' '));

                if (glType.Contains("char")) return "String";

                if (glType.Contains("void")) return "IntPtr";

                return GetCSharpType(glType) + "[]";
            }

            switch (glType)
            {
                case "GLuint":
                case "Gluint":                  // Gluint is a typo on glGetActiveAtomicCounterBufferiv man page
                case "GLuitn": return "UInt32"; // GLuitn is a typo on glDrawElementsInstancedBaseInstance man page
                case "GLsizei":
                case "GLint": return "Int32";
                case "GLuint64": return "UInt64";
                case "GLint64": return "Int64";
                case "GLfloat": return "Single";
                case "GLdouble": return "Double";
                case "GLshort": return "Int16";
                case "GLushort": return "UInt16";
                case "GLubyte": return "Byte";
                case "GLbyte": return "SByte";
                case "GLboolean": return "Boolean";
                case "GLvoid":
                case "void":
                case "GLsizeiptr":
                case "GLuintptr":
                case "GLintptr": return "IntPtr";

                // special cases
                case "GLsync": return "IntPtr";
                case "GLbitfield": return "UInt32";

                default:
                    return "Unknown";
            }
        }

        private static void WriteBinding(string function, string funcdef, List<string> paramTypes, List<string> paramNames, StreamWriter output)
        {
            if (ExploredFunctions.Contains(function)) return;

            if (paramTypes[paramTypes.Count - 1] == "String" && funcdef == "void")
            {
                if (function.Contains("Gen") || function.Contains("Get") || function.Contains("Read"))
                    paramTypes[paramTypes.Count - 1] = "[OutAttribute] System.Text.StringBuilder";
            }

            output.WriteLine("            [DllImport(GL.Library, EntryPoint = \"{0}\", ExactSpelling = true)]", function);
            output.Write("            internal extern static {0} {1}(", funcdef, function.Substring(2));

            if (funcdef == "Unknown") unknowns++;

            for (int i = 0; i < paramTypes.Count; i++)
            {
                output.Write(paramTypes[i] + " " + paramNames[i]);
                if (i < paramTypes.Count - 1) output.Write(", ");
                if (paramTypes[i].Contains("Unknown")) unknowns++;
            }

            output.WriteLine(");");

            ExploredFunctions.Add(function);
        }
    }
}
