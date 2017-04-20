using System;
using System.Runtime.InteropServices;

namespace SharpGL
{
    public partial class GL
    {
        private static readonly uint[] uintAuxArray = new uint[1];
        private static uint currentProgram = 0;

        public static uint GenBuffer()
        {
            uintAuxArray[0] = 0;
            GenBuffers(1, uintAuxArray);
            return uintAuxArray[0];
        }

        public static uint GenTexture()
        {
            uintAuxArray[0] = 0;
            GenTextures(1, uintAuxArray);
            return uintAuxArray[0];
        }

        public static uint GenVertexArray()
        {
            uintAuxArray[0] = 0;
            GenVertexArrays(1, uintAuxArray);
            return uintAuxArray[0];
        }

        public static uint GenFrameBuffer()
        {
            uintAuxArray[0] = 0;
            GenFramebuffers(1, uintAuxArray);
            return uintAuxArray[0];
        }

        public static string GetProgramInfoLog(UInt32 program)
        {
            int[] length = new int[1];
            GetProgramiv(program, ProgramParameter.InfoLogLength, length);
            if (length[0] == 0) return String.Empty;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(length[0]);
            GetProgramInfoLog(program, sb.Capacity, length, sb);
            return sb.ToString();
        }

        public static string GetShaderInfoLog(UInt32 shader)
        {
            int[] length = new int[1];
            GetShaderiv(shader, ShaderParameter.InfoLogLength, length);
            if (length[0] == 0) return String.Empty;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(length[0]);
            GetShaderInfoLog(shader, sb.Capacity, length, sb);
            return sb.ToString();
        }

        public static void ShaderSource(UInt32 shader, string source)
        {
            ShaderSource(shader, 1, new[] { source }, new[] { source.Length });
        }

        public static void BufferData<T>(BufferTarget target, Int32 size, [In, Out] T[] data, BufferUsageHint usage)
            where T : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferData(target, new IntPtr(size), data_ptr.AddrOfPinnedObject(), usage);
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static void BufferData<T>(BufferTarget target, Int32 position, Int32 size, [In, Out] T[] data, BufferUsageHint usage)
            where T : struct
        {
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferData(target, new IntPtr(size), (IntPtr)((int)data_ptr.AddrOfPinnedObject() + position), usage);
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static uint CreateVBO<T>(BufferTarget target, [In, Out] T[] data, BufferUsageHint hint)
            where T : struct
        {
            uint vboHandle = GenBuffer();
            if (vboHandle == 0) return 0;

            BindBuffer(target, vboHandle);
            BufferData(target, data.Length * Marshal.SizeOf(typeof(T)), data, hint);
            BindBuffer(target, 0);
            return vboHandle;
        }

        public static uint CreateVBO<T>(BufferTarget target, [In, OutAttribute] T[] data, BufferUsageHint hint, int length)
            where T : struct
        {
            uint vboHandle = GenBuffer();
            if (vboHandle == 0) return 0;

            BindBuffer(target, vboHandle);
            BufferData(target, length * Marshal.SizeOf(typeof(T)), data, hint);
            BindBuffer(target, 0);
            return vboHandle;
        }

        public static uint CreateVBO<T>(BufferTarget target, [In, OutAttribute] T[] data, BufferUsageHint hint, int position, int length)
            where T : struct
        {
            uint vboHandle = GenBuffer();
            if (vboHandle == 0) return 0;

            BindBuffer(target, vboHandle);
            BufferData(target, position * Marshal.SizeOf(typeof(T)), length * Marshal.SizeOf(typeof(T)), data, hint);
            BindBuffer(target, 0);
            return vboHandle;
        }


        public static void DeleteBuffer(uint buffer)
        {
            uintAuxArray[0] = buffer;
            DeleteBuffers(1, uintAuxArray);
            uintAuxArray[0] = 0;
        }

        public static void DeleteVertexArray(uint vao)
        {
            uintAuxArray[0] = vao;
            DeleteVertexArrays(1, uintAuxArray);
            uintAuxArray[0] = 0;
        }

        

    }
}
