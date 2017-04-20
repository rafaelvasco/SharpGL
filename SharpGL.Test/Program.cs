using System;
using SharpGlfw;

namespace SharpGL.Test
{
    class Program
    {
        static void Main()
        {
            
            if (!Glfw.Init())
            {
                Glfw.Terminate();
                throw new Exception("GLFW Failed to Initialize");
            }

            Glfw.WindowHint(WindowAttrib.Resizable, false);
            
            var window = Glfw.CreateWindow(1024, 768, "Test");

            if (window.Equals(GlfwWindow.Null))
            {
                Glfw.Terminate();
                throw new Exception("GLFW failed to create window");
            }

            Glfw.CenterWindow(window);

            Glfw.MakeContextCurrent(window);

            string glVersion = GL.GetString(StringName.Version);

            Console.WriteLine("OpenGL Version: {0}", glVersion);

            Glfw.SwapInterval(1);

            /* Initialize Rendering Data */
            /* ==================================================================================== */

            float[] renderBuffer = {
                0.0f, 0.5f, 0.0f, 1.0f, 0.0f, 0.0f,
                0.5f, -0.5f, 0.0f, 0.0f, 1.0f, 0.0f,
                -0.5f, -0.5f, 0.0f, 0.0f, 0.0f, 1.0f
            };

            uint vbo = GL.CreateVBO(BufferTarget.ArrayBuffer, renderBuffer, BufferUsageHint.StaticDraw);

            uint vao = GL.GenVertexArray();

            GL.BindVertexArray(vao);

            GL.EnableVertexAttribArray(0);
            GL.EnableVertexAttribArray(1);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);

            int stride = 6 * sizeof (float);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, stride, IntPtr.Zero);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, stride, new IntPtr(3 * sizeof(float)));

            string vertexShaderSrc = @"
                
                #version 400

                layout(location = 0) in vec3 vertexPos;
                layout(location = 1) in vec3 vertexColor;

                out vec3 fragmentColor;

                void main() {
                
                    gl_Position = vec4(vertexPos, 1.0);

                    fragmentColor = vertexColor;

                }                

            ";

            string fragShaderSrc = @"
                
                #version 400

                in vec3 fragmentColor;
                
                out vec4 finalColor;

                void main() {

                    finalColor = vec4(fragmentColor, 1.0);            

                }
    
            ";


            uint vShader = GL.CreateShader(ShaderType.VertexShader);

            GL.ShaderSource(vShader, vertexShaderSrc);

            GL.CompileShader(vShader);

            string log = GL.GetShaderInfoLog(vShader);

            if (!string.IsNullOrEmpty(log))
            {
                throw new Exception("Error on Vertex Shader: " + log);
            }

            uint fShader = GL.CreateShader(ShaderType.FragmentShader);

            GL.ShaderSource(fShader, fragShaderSrc);

            GL.CompileShader(fShader);

            log = GL.GetShaderInfoLog(fShader);

            if (!string.IsNullOrEmpty(log))
            {
                throw new Exception("Error on Fragment Shader: " + log);
            }

            uint shaderProg = GL.CreateProgram();

            GL.AttachShader(shaderProg, vShader);
            GL.AttachShader(shaderProg, fShader);

            GL.LinkProgram(shaderProg);

            /* ==================================================================================== */

            while (!Glfw.WindowShouldClose(window))
            {

                Glfw.PollEvents();

                if (Glfw.GetKey(window, Key.Escape))
                {
                    Glfw.SetWindowShouldClose(window, true);
                }

                GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                /* DRAW TRIANGLE */

                GL.UseProgram(shaderProg);

                GL.BindVertexArray(vao);

                GL.DrawArrays(BeginMode.Triangles, 0, 3);

                GL.UseProgram(0);

                Glfw.SwapBuffers(window);
            }

            GL.DeleteShader(vShader);
            GL.DeleteShader(fShader);
            GL.DeleteBuffer(vbo);
            GL.DeleteVertexArray(vao);

            Glfw.DestroyWindow(window);
            Glfw.Terminate();
        }
    }
}
