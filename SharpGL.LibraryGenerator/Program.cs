using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SharpGL.LibraryGenerator
{
    class Program
    {
        private const string INPUT = @"GLCore.cs";

        private const string OUTPUT1 = @"GLDelegates.cs";
        private const string PREPEND1 = @"using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649

namespace SharpGL
{
    // Automatically generated from GLCore.cs using SharpGL.Genearator
    partial class GL
    {
        internal static partial class Delegates
        {";
        static string append1 = @"        }
    }
}";

        static string output2 = @"GL.cs";
        static string prepend2 = @"using System;
using System.Runtime.InteropServices;

namespace SharpGL
{
    // Automatically generated from GLCore.cs using SharpGL.Generator
    partial class GL
    {";
        static string append2 = @"    }
}";

        static void Main(string[] args)
        {
            var extensions = from line in ReadFrom(INPUT)
                             where line.Contains("internal extern static") && !line.Contains("*/")
                             select new { Call = line.Substring(line.IndexOf("static") + 7), Name = line.Split(' ')[4] };

            using (StreamWriter output = new StreamWriter(OUTPUT1))
            {
                output.WriteLine(PREPEND1);

                foreach (var extension in extensions)
                {
                    string name = extension.Name.Substring(0, extension.Name.IndexOf('('));
                    //writer.WriteLine(@"            [System.Security.SuppressUnmanagedCodeSecurity()]");
                    output.WriteLine(@"            internal delegate {0}", extension.Call);
                    output.WriteLine(@"            internal static {0} gl{0};", name);
                }

                output.WriteLine(append1);
            }

            using (StreamWriter output = new StreamWriter(output2))
            {
                output.WriteLine(prepend2);

                foreach (var extension in extensions)
                {
                    if (extension.Name.StartsWith("GetString"))
                    {
                        if (extension.Name.StartsWith("GetStringi"))
                        {
                            output.WriteLine(@"        public static String GetStringi(StringName name, UInt32 index)");
                            output.WriteLine(@"        {");
                            output.WriteLine(@"            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.glGetStringi(name, index));");
                            output.WriteLine(@"        }");
                            output.WriteLine();
                        }
                        else
                        {
                            output.WriteLine(@"        public static String GetString(StringName name)");
                            output.WriteLine(@"        {");
                            output.WriteLine(@"            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.glGetString(name));");
                            output.WriteLine(@"        }");
                            output.WriteLine();
                        }
                    }
                    else if (extension.Name.StartsWith("ActiveTexture"))
                    {
                        if (extension.Call.StartsWith("void ActiveTexture"))
                        {
                            output.WriteLine("        [Obsolete(\"ActiveTexture(TextureUnit) is deprecated, please use ActiveTexture(int) instead.\")]");
                            output.WriteLine("        public static void ActiveTexture(TextureUnit texture)");
                            output.WriteLine("        {");
                            output.WriteLine("            Delegates.glActiveTexture((int)texture);");
                            output.WriteLine("        }");
                        }
                    }
                    else
                    {
                        string name = extension.Name.Substring(0, extension.Name.IndexOf('('));

                        output.WriteLine(@"        public static {0}", extension.Call.Trim(';'));
                        output.WriteLine(@"        {");

                        if (extension.Name.StartsWith("UseProgram")) output.WriteLine("            GL.currentProgram = program;");
                        else if (extension.Name.StartsWith("GetUniformBlockIndex")) output.WriteLine("            UseProgram(program);    // take care of a crash that can occur on NVIDIA drivers by using the program first");

                        if (extension.Call.ToLower().Substring(0, 4) != "void") output.Write(@"            return Delegates.gl{0}(", name);
                        else output.Write(@"            Delegates.gl{0}(", name);

                        var arguments = from arg in extension.Call.Trim(new char[] { ';', ')' }).Split(',')
                                        from sarg in arg.Split(' ')
                                        where sarg == arg.Split(' ')[arg.Split(' ').Length - 1] && !sarg.Contains('(')
                                        select sarg;

                        int i = 0;
                        foreach (var arg in arguments)
                        {
                            if (i > 0) output.Write(@", ");
                            output.Write(@"{0}", arg);
                            i++;
                        }

                        output.WriteLine(@");");
                        output.WriteLine(@"        }");
                        output.WriteLine();

                        if ((extension.Name.Contains("Attrib") || extension.Name.Contains("Uniform")) && extension.Call.Contains("UInt32 index"))
                        {
                            output.WriteLine(@"        public static {0}", extension.Call.Trim(';').Replace("UInt32 index", "Int32 index"));
                            output.WriteLine(@"        {");
                            output.WriteLine("            if (index < 0) throw new ArgumentOutOfRangeException(\"index\");");

                            output.Write(@"            Delegates.gl{0}(", name);

                            i = 0;
                            foreach (var arg in arguments)
                            {
                                if (i > 0) output.Write(@", ");
                                output.Write(@"{0}", arg.Replace("index", "(UInt32)index"));
                                i++;
                            }

                            output.WriteLine(@");");
                            output.WriteLine(@"        }");
                            output.WriteLine();
                        }
                        else if (extension.Call.Contains("UInt32 index")) Console.WriteLine(extension.Name);
                    }
                }

                output.WriteLine(append2);
            }

            if (Directory.Exists("../OpenGLManPages"))
            {
                File.Copy(OUTPUT1, "../OpenGLManPages/" + OUTPUT1, true);
                File.Copy(output2, "../OpenGLManPages/" + output2, true);
                File.Copy(INPUT, "../OpenGLManPages/" + INPUT, true);
            }
        }

        static IEnumerable<string> ReadFrom(string file)
        {
            bool gl4 = false;
            using (StreamReader stream = new StreamReader(file))
            {
                string line = "";
                while (!stream.EndOfStream && (!(line.Contains("OPENGL4") && !gl4)))
                {
                    line = stream.ReadLine().Trim();
                    if (line.Contains("#define OPENGL4")) gl4 = true;
                    yield return line;
                }
            }
        }
    }
}
