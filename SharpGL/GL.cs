﻿using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpGL
{
    /// <summary>
    /// 
    /// OpenGL 4 Lightweight Bindings
    /// 
    /// Thanks to the work of @giawa at
    /// https://github.com/giawa/opengl4csharp
    /// 
    /// </summary>

    public partial class GL
    {
        public static void ActiveShaderProgram(UInt32 pipeline, UInt32 program)
        {
            Delegates.glActiveShaderProgram(pipeline, program);
        }

        public static void ActiveTexture(TextureUnit texture)
        {
            Delegates.glActiveTexture(texture);
        }

        public static void AttachShader(UInt32 program, UInt32 shader)
        {
            Delegates.glAttachShader(program, shader);
        }

        public static void BeginConditionalRender(UInt32 id, ConditionalRenderType mode)
        {
            Delegates.glBeginConditionalRender(id, mode);
        }

        public static void EndConditionalRender()
        {
            Delegates.glEndConditionalRender();
        }

        public static void BeginQuery(QueryTarget target, UInt32 id)
        {
            Delegates.glBeginQuery(target, id);
        }

        public static void EndQuery(QueryTarget target)
        {
            Delegates.glEndQuery(target);
        }

        public static void BeginQueryIndexed(UInt32 target, UInt32 index, UInt32 id)
        {
            Delegates.glBeginQueryIndexed(target, index, id);
        }

        public static void EndQueryIndexed(QueryTarget target, UInt32 index)
        {
            Delegates.glEndQueryIndexed(target, index);
        }

        public static void BeginTransformFeedback(BeginFeedbackMode primitiveMode)
        {
            Delegates.glBeginTransformFeedback(primitiveMode);
        }

        public static void EndTransformFeedback()
        {
            Delegates.glEndTransformFeedback();
        }

        public static void BindAttribLocation(UInt32 program, UInt32 index, String name)
        {
            Delegates.glBindAttribLocation(program, index, name);
        }

        public static void BindAttribLocation(UInt32 program, Int32 index, String name)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glBindAttribLocation(program, (UInt32)index, name);
        }

        public static void BindBuffer(BufferTarget target, UInt32 buffer)
        {
            Delegates.glBindBuffer(target, buffer);
        }

        public static void BindBufferBase(BufferTarget target, UInt32 index, UInt32 buffer)
        {
            Delegates.glBindBufferBase(target, index, buffer);
        }

        public static void BindBufferRange(BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size)
        {
            Delegates.glBindBufferRange(target, index, buffer, offset, size);
        }

        public static void BindBuffersBase(BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers)
        {
            Delegates.glBindBuffersBase(target, first, count, buffers);
        }

        public static void BindBuffersRange(BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes)
        {
            Delegates.glBindBuffersRange(target, first, count, buffers, offsets, sizes);
        }

        public static void BindFragDataLocation(UInt32 program, UInt32 colorNumber, String name)
        {
            Delegates.glBindFragDataLocation(program, colorNumber, name);
        }

        public static void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name)
        {
            Delegates.glBindFragDataLocationIndexed(program, colorNumber, index, name);
        }

        public static void BindFramebuffer(FramebufferTarget target, UInt32 framebuffer)
        {
            Delegates.glBindFramebuffer(target, framebuffer);
        }

        public static void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, BufferAccess access, PixelInternalFormat format)
        {
            Delegates.glBindImageTexture(unit, texture, level, layered, layer, access, format);
        }

        public static void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures)
        {
            Delegates.glBindImageTextures(first, count, textures);
        }

        public static void BindProgramPipeline(UInt32 pipeline)
        {
            Delegates.glBindProgramPipeline(pipeline);
        }

        public static void BindRenderbuffer(RenderbufferTarget target, UInt32 renderbuffer)
        {
            Delegates.glBindRenderbuffer(target, renderbuffer);
        }

        public static void BindSampler(UInt32 unit, UInt32 sampler)
        {
            Delegates.glBindSampler(unit, sampler);
        }

        public static void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers)
        {
            Delegates.glBindSamplers(first, count, samplers);
        }

        public static void BindTexture(TextureTarget target, UInt32 texture)
        {
            Delegates.glBindTexture(target, texture);
        }

        public static void BindTextures(UInt32 first, Int32 count, UInt32[] textures)
        {
            Delegates.glBindTextures(first, count, textures);
        }

        public static void BindTextureUnit(UInt32 unit, UInt32 texture)
        {
            Delegates.glBindTextureUnit(unit, texture);
        }

        public static void BindTransformFeedback(NvTransformFeedback2 target, UInt32 id)
        {
            Delegates.glBindTransformFeedback(target, id);
        }

        public static void BindVertexArray(UInt32 vao)
        {
            Delegates.glBindVertexArray(vao);
        }

        public static void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, IntPtr stride)
        {
            Delegates.glBindVertexBuffer(bindingindex, buffer, offset, stride);
        }

        public static void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
        {
            Delegates.glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
        }

        public static void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
        {
            Delegates.glBindVertexBuffers(first, count, buffers, offsets, strides);
        }

        public static void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
        {
            Delegates.glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
        }

        public static void BlendColor(Single red, Single green, Single blue, Single alpha)
        {
            Delegates.glBlendColor(red, green, blue, alpha);
        }

        public static void BlendEquation(BlendEquationMode mode)
        {
            Delegates.glBlendEquation(mode);
        }

        public static void BlendEquationi(UInt32 buf, BlendEquationMode mode)
        {
            Delegates.glBlendEquationi(buf, mode);
        }

        public static void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
        {
            Delegates.glBlendEquationSeparate(modeRGB, modeAlpha);
        }

        public static void BlendEquationSeparatei(UInt32 buf, BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
        {
            Delegates.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
        }

        public static void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
        {
            Delegates.glBlendFunc(sfactor, dfactor);
        }

        public static void BlendFunci(UInt32 buf, BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
        {
            Delegates.glBlendFunci(buf, sfactor, dfactor);
        }

        public static void BlendFuncSeparate(BlendingFactorSrc srcRGB, BlendingFactorDest dstRGB, BlendingFactorSrc srcAlpha, BlendingFactorDest dstAlpha)
        {
            Delegates.glBlendFuncSeparate(srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public static void BlendFuncSeparatei(UInt32 buf, BlendingFactorSrc srcRGB, BlendingFactorDest dstRGB, BlendingFactorSrc srcAlpha, BlendingFactorDest dstAlpha)
        {
            Delegates.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            Delegates.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        public static void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            Delegates.glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        public static void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage)
        {
            Delegates.glBufferData(target, size, data, usage);
        }

        public static void NamedBufferData(UInt32 buffer, Int32 size, IntPtr data, BufferUsageHint usage)
        {
            Delegates.glNamedBufferData(buffer, size, data, usage);
        }

        public static void BufferStorage(BufferTarget target, IntPtr size, IntPtr data, UInt32 flags)
        {
            Delegates.glBufferStorage(target, size, data, flags);
        }

        public static void NamedBufferStorage(UInt32 buffer, Int32 size, IntPtr data, UInt32 flags)
        {
            Delegates.glNamedBufferStorage(buffer, size, data, flags);
        }

        public static void BufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data)
        {
            Delegates.glBufferSubData(target, offset, size, data);
        }

        public static void NamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, IntPtr data)
        {
            Delegates.glNamedBufferSubData(buffer, offset, size, data);
        }

        public static FramebufferErrorCode CheckFramebufferStatus(FramebufferTarget target)
        {
            return Delegates.glCheckFramebufferStatus(target);
        }

        public static FramebufferErrorCode CheckNamedFramebufferStatus(UInt32 framebuffer, FramebufferTarget target)
        {
            return Delegates.glCheckNamedFramebufferStatus(framebuffer, target);
        }

        public static void ClampColor(ClampColorTarget target, ClampColorMode clamp)
        {
            Delegates.glClampColor(target, clamp);
        }

        public static void Clear(ClearBufferMask mask)
        {
            Delegates.glClear(mask);
        }

        public static void ClearBufferiv(ClearBuffer buffer, Int32 drawbuffer, Int32[] value)
        {
            Delegates.glClearBufferiv(buffer, drawbuffer, value);
        }

        public static void ClearBufferuiv(ClearBuffer buffer, Int32 drawbuffer, UInt32[] value)
        {
            Delegates.glClearBufferuiv(buffer, drawbuffer, value);
        }

        public static void ClearBufferfv(ClearBuffer buffer, Int32 drawbuffer, Single[] value)
        {
            Delegates.glClearBufferfv(buffer, drawbuffer, value);
        }

        public static void ClearBufferfi(ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil)
        {
            Delegates.glClearBufferfi(buffer, drawbuffer, depth, stencil);
        }

        public static void ClearNamedFramebufferiv(UInt32 framebuffer, ClearBuffer buffer, Int32 drawbuffer, Int32[] value)
        {
            Delegates.glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
        }

        public static void ClearNamedFramebufferuiv(UInt32 framebuffer, ClearBuffer buffer, Int32 drawbuffer, UInt32[] value)
        {
            Delegates.glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
        }

        public static void ClearNamedFramebufferfv(UInt32 framebuffer, ClearBuffer buffer, Int32 drawbuffer, Single[] value)
        {
            Delegates.glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
        }

        public static void ClearNamedFramebufferfi(UInt32 framebuffer, ClearBuffer buffer, Single depth, Int32 stencil)
        {
            Delegates.glClearNamedFramebufferfi(framebuffer, buffer, depth, stencil);
        }

        public static void ClearBufferData(BufferTarget target, SizedInternalFormat internalFormat, PixelInternalFormat format, PixelType type, IntPtr data)
        {
            Delegates.glClearBufferData(target, internalFormat, format, type, data);
        }

        public static void ClearNamedBufferData(UInt32 buffer, SizedInternalFormat internalFormat, PixelInternalFormat format, PixelType type, IntPtr data)
        {
            Delegates.glClearNamedBufferData(buffer, internalFormat, format, type, data);
        }

        public static void ClearBufferSubData(BufferTarget target, SizedInternalFormat internalFormat, IntPtr offset, IntPtr size, PixelInternalFormat format, PixelType type, IntPtr data)
        {
            Delegates.glClearBufferSubData(target, internalFormat, offset, size, format, type, data);
        }

        public static void ClearNamedBufferSubData(UInt32 buffer, SizedInternalFormat internalFormat, IntPtr offset, Int32 size, PixelInternalFormat format, PixelType type, IntPtr data)
        {
            Delegates.glClearNamedBufferSubData(buffer, internalFormat, offset, size, format, type, data);
        }

        public static void ClearColor(Single red, Single green, Single blue, Single alpha)
        {
            Delegates.glClearColor(red, green, blue, alpha);
        }

        public static void ClearDepth(Double depth)
        {
            Delegates.glClearDepth(depth);
        }

        public static void ClearDepthf(Single depth)
        {
            Delegates.glClearDepthf(depth);
        }

        public static void ClearStencil(Int32 s)
        {
            Delegates.glClearStencil(s);
        }

        public static void ClearTexImage(UInt32 texture, Int32 level, PixelInternalFormat format, PixelType type, IntPtr data)
        {
            Delegates.glClearTexImage(texture, level, format, type, data);
        }

        public static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelInternalFormat format, PixelType type, IntPtr data)
        {
            Delegates.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
        }

        public static ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
        {
            return Delegates.glClientWaitSync(sync, flags, timeout);
        }

        public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth)
        {
            Delegates.glClipControl(origin, depth);
        }

        public static void ColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
        {
            Delegates.glColorMask(red, green, blue, alpha);
        }

        public static void ColorMaski(UInt32 buf, Boolean red, Boolean green, Boolean blue, Boolean alpha)
        {
            Delegates.glColorMaski(buf, red, green, blue, alpha);
        }

        public static void CompileShader(UInt32 shader)
        {
            Delegates.glCompileShader(shader);
        }

        public static void CompressedTexImage1D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage1D(target, level, internalFormat, width, border, imageSize, data);
        }

        public static void CompressedTexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage2D(target, level, internalFormat, width, height, border, imageSize, data);
        }

        public static void CompressedTexImage3D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage3D(target, level, internalFormat, width, height, depth, border, imageSize, data);
        }

        public static void CompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }

        public static void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelInternalFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
        }

        public static void CompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public static void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelInternalFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public static void CompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public static void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelInternalFormat format, Int32 imageSize, IntPtr data)
        {
            Delegates.glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        public static void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
        {
            Delegates.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
        }

        public static void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, Int32 size)
        {
            Delegates.glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
        }

        public static void CopyImageSubData(UInt32 srcName, BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
        {
            Delegates.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        }

        public static void CopyTexImage1D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 border)
        {
            Delegates.glCopyTexImage1D(target, level, internalFormat, x, y, width, border);
        }

        public static void CopyTexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
        {
            Delegates.glCopyTexImage2D(target, level, internalFormat, x, y, width, height, border);
        }

        public static void CopyTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
        {
            Delegates.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
        }

        public static void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
        {
            Delegates.glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
        }

        public static void CopyTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public static void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
        }

        public static void CopyTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        public static void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        public static void CreateBuffers(Int32 n, UInt32[] buffers)
        {
            Delegates.glCreateBuffers(n, buffers);
        }

        public static void CreateFramebuffers(Int32 n, UInt32[] ids)
        {
            Delegates.glCreateFramebuffers(n, ids);
        }

        public static UInt32 CreateProgram()
        {
            return Delegates.glCreateProgram();
        }

        public static void CreateProgramPipelines(Int32 n, UInt32[] pipelines)
        {
            Delegates.glCreateProgramPipelines(n, pipelines);
        }

        public static void CreateQueries(QueryTarget target, Int32 n, UInt32[] ids)
        {
            Delegates.glCreateQueries(target, n, ids);
        }

        public static void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers)
        {
            Delegates.glCreateRenderbuffers(n, renderbuffers);
        }

        public static void CreateSamplers(Int32 n, UInt32[] samplers)
        {
            Delegates.glCreateSamplers(n, samplers);
        }

        public static UInt32 CreateShader(ShaderType shaderType)
        {
            return Delegates.glCreateShader(shaderType);
        }

        public static UInt32 CreateShaderProgramv(ShaderType type, Int32 count, String strings)
        {
            return Delegates.glCreateShaderProgramv(type, count, strings);
        }

        public static void CreateTextures(TextureTarget target, Int32 n, UInt32[] textures)
        {
            Delegates.glCreateTextures(target, n, textures);
        }

        public static void CreateTransformFeedbacks(Int32 n, UInt32[] ids)
        {
            Delegates.glCreateTransformFeedbacks(n, ids);
        }

        public static void CreateVertexArrays(Int32 n, UInt32[] arrays)
        {
            Delegates.glCreateVertexArrays(n, arrays);
        }

        public static void CullFace(CullFaceMode mode)
        {
            Delegates.glCullFace(mode);
        }

        public static void DeleteBuffers(Int32 n, UInt32[] buffers)
        {
            Delegates.glDeleteBuffers(n, buffers);
        }

        public static void DeleteFramebuffers(Int32 n, UInt32[] framebuffers)
        {
            Delegates.glDeleteFramebuffers(n, framebuffers);
        }

        public static void DeleteProgram(UInt32 program)
        {
            Delegates.glDeleteProgram(program);
        }

        public static void DeleteProgramPipelines(Int32 n, UInt32[] pipelines)
        {
            Delegates.glDeleteProgramPipelines(n, pipelines);
        }

        public static void DeleteQueries(Int32 n, UInt32[] ids)
        {
            Delegates.glDeleteQueries(n, ids);
        }

        public static void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers)
        {
            Delegates.glDeleteRenderbuffers(n, renderbuffers);
        }

        public static void DeleteSamplers(Int32 n, UInt32[] samplers)
        {
            Delegates.glDeleteSamplers(n, samplers);
        }

        public static void DeleteShader(UInt32 shader)
        {
            Delegates.glDeleteShader(shader);
        }

        public static void DeleteSync(IntPtr sync)
        {
            Delegates.glDeleteSync(sync);
        }

        public static void DeleteTextures(Int32 n, UInt32[] textures)
        {
            Delegates.glDeleteTextures(n, textures);
        }

        public static void DeleteTransformFeedbacks(Int32 n, UInt32[] ids)
        {
            Delegates.glDeleteTransformFeedbacks(n, ids);
        }

        public static void DeleteVertexArrays(Int32 n, UInt32[] arrays)
        {
            Delegates.glDeleteVertexArrays(n, arrays);
        }

        public static void DepthFunc(DepthFunction func)
        {
            Delegates.glDepthFunc(func);
        }

        public static void DepthMask(Boolean flag)
        {
            Delegates.glDepthMask(flag);
        }

        public static void DepthRange(Double nearVal, Double farVal)
        {
            Delegates.glDepthRange(nearVal, farVal);
        }

        public static void DepthRangef(Single nearVal, Single farVal)
        {
            Delegates.glDepthRangef(nearVal, farVal);
        }

        public static void DepthRangeArrayv(UInt32 first, Int32 count, Double[] v)
        {
            Delegates.glDepthRangeArrayv(first, count, v);
        }

        public static void DepthRangeIndexed(UInt32 index, Double nearVal, Double farVal)
        {
            Delegates.glDepthRangeIndexed(index, nearVal, farVal);
        }

        public static void DetachShader(UInt32 program, UInt32 shader)
        {
            Delegates.glDetachShader(program, shader);
        }

        public static void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z)
        {
            Delegates.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
        }

        public static void DispatchComputeIndirect(IntPtr indirect)
        {
            Delegates.glDispatchComputeIndirect(indirect);
        }

        public static void DrawArrays(BeginMode mode, Int32 first, Int32 count)
        {
            Delegates.glDrawArrays(mode, first, count);
        }

        public static void DrawArraysIndirect(BeginMode mode, IntPtr indirect)
        {
            Delegates.glDrawArraysIndirect(mode, indirect);
        }

        public static void DrawArraysInstanced(BeginMode mode, Int32 first, Int32 count, Int32 primcount)
        {
            Delegates.glDrawArraysInstanced(mode, first, count, primcount);
        }

        public static void DrawArraysInstancedBaseInstance(BeginMode mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance)
        {
            Delegates.glDrawArraysInstancedBaseInstance(mode, first, count, primcount, baseinstance);
        }

        public static void DrawBuffer(DrawBufferMode buf)
        {
            Delegates.glDrawBuffer(buf);
        }

        public static void NamedFramebufferDrawBuffer(UInt32 framebuffer, DrawBufferMode buf)
        {
            Delegates.glNamedFramebufferDrawBuffer(framebuffer, buf);
        }

        public static void DrawBuffers(Int32 n, DrawBuffersEnum[] bufs)
        {
            Delegates.glDrawBuffers(n, bufs);
        }

        public static void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, DrawBufferMode[] bufs)
        {
            Delegates.glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
        }

        public static void DrawElements(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices)
        {
            Delegates.glDrawElements(mode, count, type, indices);
        }

        public static void DrawElementsBaseVertex(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
        {
            Delegates.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
        }

        public static void DrawElementsIndirect(BeginMode mode, DrawElementsType type, IntPtr indirect)
        {
            Delegates.glDrawElementsIndirect(mode, type, indirect);
        }

        public static void DrawElementsInstanced(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 primcount)
        {
            Delegates.glDrawElementsInstanced(mode, count, type, indices, primcount);
        }

        public static void DrawElementsInstancedBaseInstance(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 primcount, UInt32 baseinstance)
        {
            Delegates.glDrawElementsInstancedBaseInstance(mode, count, type, indices, primcount, baseinstance);
        }

        public static void DrawElementsInstancedBaseVertex(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex)
        {
            Delegates.glDrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
        }

        public static void DrawElementsInstancedBaseVertexBaseInstance(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance)
        {
            Delegates.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, primcount, basevertex, baseinstance);
        }

        public static void DrawRangeElements(BeginMode mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices)
        {
            Delegates.glDrawRangeElements(mode, start, end, count, type, indices);
        }

        public static void DrawRangeElementsBaseVertex(BeginMode mode, UInt32 start, UInt32 end, Int32 count, DrawElementsType type, IntPtr indices, Int32 basevertex)
        {
            Delegates.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
        }

        public static void DrawTransformFeedback(NvTransformFeedback2 mode, UInt32 id)
        {
            Delegates.glDrawTransformFeedback(mode, id);
        }

        public static void DrawTransformFeedbackInstanced(BeginMode mode, UInt32 id, Int32 primcount)
        {
            Delegates.glDrawTransformFeedbackInstanced(mode, id, primcount);
        }

        public static void DrawTransformFeedbackStream(NvTransformFeedback2 mode, UInt32 id, UInt32 stream)
        {
            Delegates.glDrawTransformFeedbackStream(mode, id, stream);
        }

        public static void DrawTransformFeedbackStreamInstanced(BeginMode mode, UInt32 id, UInt32 stream, Int32 primcount)
        {
            Delegates.glDrawTransformFeedbackStreamInstanced(mode, id, stream, primcount);
        }

        public static void Enable(EnableCap cap)
        {
            Delegates.glEnable(cap);
        }

        public static void Disable(EnableCap cap)
        {
            Delegates.glDisable(cap);
        }

        public static void Enablei(EnableCap cap, UInt32 index)
        {
            Delegates.glEnablei(cap, index);
        }

        public static void Disablei(EnableCap cap, UInt32 index)
        {
            Delegates.glDisablei(cap, index);
        }

        public static void EnableVertexAttribArray(UInt32 index)
        {
            Delegates.glEnableVertexAttribArray(index);
        }

        public static void EnableVertexAttribArray(Int32 index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glEnableVertexAttribArray((UInt32)index);
        }

        public static void DisableVertexAttribArray(UInt32 index)
        {
            Delegates.glDisableVertexAttribArray(index);
        }

        public static void DisableVertexAttribArray(Int32 index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glDisableVertexAttribArray((UInt32)index);
        }

        public static void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
        {
            Delegates.glEnableVertexArrayAttrib(vaobj, index);
        }

        public static void EnableVertexArrayAttrib(UInt32 vaobj, Int32 index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glEnableVertexArrayAttrib(vaobj, (UInt32)index);
        }

        public static void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
        {
            Delegates.glDisableVertexArrayAttrib(vaobj, index);
        }

        public static void DisableVertexArrayAttrib(UInt32 vaobj, Int32 index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glDisableVertexArrayAttrib(vaobj, (UInt32)index);
        }

        public static IntPtr FenceSync(ArbSync condition, UInt32 flags)
        {
            return Delegates.glFenceSync(condition, flags);
        }

        public static void Finish()
        {
            Delegates.glFinish();
        }

        public static void Flush()
        {
            Delegates.glFlush();
        }

        public static void FlushMappedBufferRange(BufferTarget target, IntPtr offset, IntPtr length)
        {
            Delegates.glFlushMappedBufferRange(target, offset, length);
        }

        public static void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length)
        {
            Delegates.glFlushMappedNamedBufferRange(buffer, offset, length);
        }

        public static void FramebufferParameteri(FramebufferTarget target, FramebufferPName pname, Int32 param)
        {
            Delegates.glFramebufferParameteri(target, pname, param);
        }

        public static void NamedFramebufferParameteri(UInt32 framebuffer, FramebufferPName pname, Int32 param)
        {
            Delegates.glNamedFramebufferParameteri(framebuffer, pname, param);
        }

        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
        {
            Delegates.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public static void NamedFramebufferRenderbuffer(UInt32 framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
        {
            Delegates.glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
        }

        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture(target, attachment, texture, level);
        }

        public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture1D(target, attachment, textarget, texture, level);
        }

        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level)
        {
            Delegates.glFramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 layer)
        {
            Delegates.glFramebufferTexture3D(target, attachment, textarget, texture, level, layer);
        }

        public static void NamedFramebufferTexture(UInt32 framebuffer, FramebufferAttachment attachment, UInt32 texture, Int32 level)
        {
            Delegates.glNamedFramebufferTexture(framebuffer, attachment, texture, level);
        }

        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
        {
            Delegates.glFramebufferTextureLayer(target, attachment, texture, level, layer);
        }

        public static void NamedFramebufferTextureLayer(UInt32 framebuffer, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
        {
            Delegates.glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
        }

        public static void FrontFace(FrontFaceDirection mode)
        {
            Delegates.glFrontFace(mode);
        }

        public static void GenBuffers(Int32 n, [Out] UInt32[] buffers)
        {
            Delegates.glGenBuffers(n, buffers);
        }

        public static void GenerateMipmap(GenerateMipmapTarget target)
        {
            Delegates.glGenerateMipmap(target);
        }

        public static void GenerateTextureMipmap(UInt32 texture)
        {
            Delegates.glGenerateTextureMipmap(texture);
        }

        public static void GenFramebuffers(Int32 n, [Out] UInt32[] ids)
        {
            Delegates.glGenFramebuffers(n, ids);
        }

        public static void GenProgramPipelines(Int32 n, [Out] UInt32[] pipelines)
        {
            Delegates.glGenProgramPipelines(n, pipelines);
        }

        public static void GenQueries(Int32 n, [Out] UInt32[] ids)
        {
            Delegates.glGenQueries(n, ids);
        }

        public static void GenRenderbuffers(Int32 n, [Out] UInt32[] renderbuffers)
        {
            Delegates.glGenRenderbuffers(n, renderbuffers);
        }

        public static void GenSamplers(Int32 n, [Out] UInt32[] samplers)
        {
            Delegates.glGenSamplers(n, samplers);
        }

        public static void GenTextures(Int32 n, [Out] UInt32[] textures)
        {
            Delegates.glGenTextures(n, textures);
        }

        public static void GenTransformFeedbacks(Int32 n, [Out] UInt32[] ids)
        {
            Delegates.glGenTransformFeedbacks(n, ids);
        }

        public static void GenVertexArrays(Int32 n, [Out] UInt32[] arrays)
        {
            Delegates.glGenVertexArrays(n, arrays);
        }

        public static void GetBooleanv(GetPName pname, [Out] Boolean[] data)
        {
            Delegates.glGetBooleanv(pname, data);
        }

        public static void GetDoublev(GetPName pname, [Out] Double[] data)
        {
            Delegates.glGetDoublev(pname, data);
        }

        public static void GetFloatv(GetPName pname, [Out] Single[] data)
        {
            Delegates.glGetFloatv(pname, data);
        }

        public static void GetIntegerv(GetPName pname, [Out] Int32[] data)
        {
            Delegates.glGetIntegerv(pname, data);
        }

        public static void GetInteger64v(ArbSync pname, [Out] Int64[] data)
        {
            Delegates.glGetInteger64v(pname, data);
        }

        public static void GetBooleani_v(GetPName target, UInt32 index, [Out] Boolean[] data)
        {
            Delegates.glGetBooleani_v(target, index, data);
        }

        public static void GetIntegeri_v(GetPName target, UInt32 index, [Out] Int32[] data)
        {
            Delegates.glGetIntegeri_v(target, index, data);
        }

        public static void GetFloati_v(GetPName target, UInt32 index, [Out] Single[] data)
        {
            Delegates.glGetFloati_v(target, index, data);
        }

        public static void GetDoublei_v(GetPName target, UInt32 index, [Out] Double[] data)
        {
            Delegates.glGetDoublei_v(target, index, data);
        }

        public static void GetInteger64i_v(GetPName target, UInt32 index, [Out] Int64[] data)
        {
            Delegates.glGetInteger64i_v(target, index, data);
        }

        public static void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, AtomicCounterParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);
        }

        public static void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] size, [Out] ActiveAttribType[] type, [Out] StringBuilder name)
        {
            Delegates.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
        }

        public static void GetActiveAttrib(UInt32 program, Int32 index, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] size, [Out] ActiveAttribType[] type, [Out] StringBuilder name)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetActiveAttrib(program, (UInt32)index, bufSize, length, size, type, name);
        }

        public static void GetActiveSubroutineName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, [Out] Int32[] length, [Out] StringBuilder name)
        {
            Delegates.glGetActiveSubroutineName(program, shadertype, index, bufsize, length, name);
        }

        public static void GetActiveSubroutineUniformiv(UInt32 program, ShaderType shadertype, UInt32 index, SubroutineParameterName pname, [Out] Int32[] values)
        {
            Delegates.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
        }

        public static void GetActiveSubroutineUniformiv(UInt32 program, ShaderType shadertype, Int32 index, SubroutineParameterName pname, [Out] Int32[] values)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetActiveSubroutineUniformiv(program, shadertype, (UInt32)index, pname, values);
        }

        public static void GetActiveSubroutineUniformName(UInt32 program, ShaderType shadertype, UInt32 index, Int32 bufsize, [Out] Int32[] length, [Out] StringBuilder name)
        {
            Delegates.glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);
        }

        public static void GetActiveSubroutineUniformName(UInt32 program, ShaderType shadertype, Int32 index, Int32 bufsize, [Out] Int32[] length, [Out] StringBuilder name)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetActiveSubroutineUniformName(program, shadertype, (UInt32)index, bufsize, length, name);
        }

        public static void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] size, [Out] ActiveUniformType[] type, [Out] StringBuilder name)
        {
            Delegates.glGetActiveUniform(program, index, bufSize, length, size, type, name);
        }

        public static void GetActiveUniform(UInt32 program, Int32 index, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] size, [Out] ActiveUniformType[] type, [Out] StringBuilder name)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetActiveUniform(program, (UInt32)index, bufSize, length, size, type, name);
        }

        public static void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, ActiveUniformBlockParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
        }

        public static void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder uniformBlockName)
        {
            Delegates.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        }

        public static void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder uniformName)
        {
            Delegates.glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
        }

        public static void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, [Out] UInt32[] uniformIndices, ActiveUniformType pname, [Out] Int32[] @params)
        {
            Delegates.glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
        }

        public static void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32[] count, [Out] UInt32[] shaders)
        {
            Delegates.glGetAttachedShaders(program, maxCount, count, shaders);
        }

        public static Int32 GetAttribLocation(UInt32 program, String name)
        {
            return Delegates.glGetAttribLocation(program, name);
        }

        public static void GetBufferParameteriv(BufferTarget target, BufferParameterName value, [Out] Int32[] data)
        {
            Delegates.glGetBufferParameteriv(target, value, data);
        }

        public static void GetBufferParameteri64v(BufferTarget target, BufferParameterName value, [Out] Int64[] data)
        {
            Delegates.glGetBufferParameteri64v(target, value, data);
        }

        public static void GetNamedBufferParameteriv(UInt32 buffer, BufferParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetNamedBufferParameteriv(buffer, pname, @params);
        }

        public static void GetNamedBufferParameteri64v(UInt32 buffer, BufferParameterName pname, [Out] Int64[] @params)
        {
            Delegates.glGetNamedBufferParameteri64v(buffer, pname, @params);
        }

        public static void GetBufferPointerv(BufferTarget target, BufferPointer pname, [Out] IntPtr @params)
        {
            Delegates.glGetBufferPointerv(target, pname, @params);
        }

        public static void GetNamedBufferPointerv(UInt32 buffer, BufferPointer pname, [Out] IntPtr @params)
        {
            Delegates.glGetNamedBufferPointerv(buffer, pname, @params);
        }

        public static void GetBufferSubData(BufferTarget target, IntPtr offset, IntPtr size, [Out] IntPtr data)
        {
            Delegates.glGetBufferSubData(target, offset, size, data);
        }

        public static void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, [Out] IntPtr data)
        {
            Delegates.glGetNamedBufferSubData(buffer, offset, size, data);
        }

        public static void GetCompressedTexImage(TextureTarget target, Int32 level, [Out] IntPtr pixels)
        {
            Delegates.glGetCompressedTexImage(target, level, pixels);
        }

        public static void GetnCompressedTexImage(TextureTarget target, Int32 level, Int32 bufSize, [Out] IntPtr pixels)
        {
            Delegates.glGetnCompressedTexImage(target, level, bufSize, pixels);
        }

        public static void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, [Out] IntPtr pixels)
        {
            Delegates.glGetCompressedTextureImage(texture, level, bufSize, pixels);
        }

        public static void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, [Out] IntPtr pixels)
        {
            Delegates.glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
        }

        public static ErrorCode GetError()
        {
            return Delegates.glGetError();
        }

        public static Int32 GetFragDataIndex(UInt32 program, String name)
        {
            return Delegates.glGetFragDataIndex(program, name);
        }

        public static Int32 GetFragDataLocation(UInt32 program, String name)
        {
            return Delegates.glGetFragDataLocation(program, name);
        }

        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
        }

        public static void GetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, FramebufferAttachment attachment, FramebufferParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);
        }

        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferPName pname, [Out] Int32[] @params)
        {
            Delegates.glGetFramebufferParameteriv(target, pname, @params);
        }

        public static void GetNamedFramebufferParameteriv(UInt32 framebuffer, FramebufferPName pname, [Out] Int32[] param)
        {
            Delegates.glGetNamedFramebufferParameteriv(framebuffer, pname, param);
        }

        public static GraphicResetStatus GetGraphicsResetStatus()
        {
            return Delegates.glGetGraphicsResetStatus();
        }

        public static void GetInternalformativ(TextureTarget target, PixelInternalFormat internalFormat, GetPName pname, Int32 bufSize, [Out] Int32[] @params)
        {
            Delegates.glGetInternalformativ(target, internalFormat, pname, bufSize, @params);
        }

        public static void GetInternalformati64v(TextureTarget target, PixelInternalFormat internalFormat, GetPName pname, Int32 bufSize, [Out] Int64[] @params)
        {
            Delegates.glGetInternalformati64v(target, internalFormat, pname, bufSize, @params);
        }

        public static void GetMultisamplefv(GetMultisamplePName pname, UInt32 index, [Out] Single[] val)
        {
            Delegates.glGetMultisamplefv(pname, index, val);
        }

        public static void GetObjectLabel(ObjectLabel identifier, UInt32 name, Int32 bifSize, [Out] Int32[] length, [Out] StringBuilder label)
        {
            Delegates.glGetObjectLabel(identifier, name, bifSize, length, label);
        }

        public static void GetObjectPtrLabel([Out] IntPtr ptr, Int32 bifSize, [Out] Int32[] length, [Out] StringBuilder label)
        {
            Delegates.glGetObjectPtrLabel(ptr, bifSize, length, label);
        }

        public static void GetPointerv(GetPointerParameter pname, [Out] IntPtr @params)
        {
            Delegates.glGetPointerv(pname, @params);
        }

        public static void GetProgramiv(UInt32 program, ProgramParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetProgramiv(program, pname, @params);
        }

        public static void GetProgramBinary(UInt32 program, Int32 bufsize, [Out] Int32[] length, [Out] Int32[] binaryFormat, [Out] IntPtr binary)
        {
            Delegates.glGetProgramBinary(program, bufsize, length, binaryFormat, binary);
        }

        public static void GetProgramInfoLog(UInt32 program, Int32 maxLength, [Out] Int32[] length, [Out] StringBuilder infoLog)
        {
            Delegates.glGetProgramInfoLog(program, maxLength, length, infoLog);
        }

        public static void GetProgramInterfaceiv(UInt32 program, ProgramInterface programInterface, ProgramInterfaceParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetProgramInterfaceiv(program, programInterface, pname, @params);
        }

        public static void GetProgramPipelineiv(UInt32 pipeline, Int32 pname, [Out] Int32[] @params)
        {
            Delegates.glGetProgramPipelineiv(pipeline, pname, @params);
        }

        public static void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder infoLog)
        {
            Delegates.glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
        }

        public static void GetProgramResourceiv(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 propCount, [Out] ProgramResourceParameterName[] props, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] @params)
        {
            Delegates.glGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, @params);
        }

        public static UInt32 GetProgramResourceIndex(UInt32 program, ProgramInterface programInterface, String name)
        {
            return Delegates.glGetProgramResourceIndex(program, programInterface, name);
        }

        public static Int32 GetProgramResourceLocation(UInt32 program, ProgramInterface programInterface, String name)
        {
            return Delegates.glGetProgramResourceLocation(program, programInterface, name);
        }

        public static Int32 GetProgramResourceLocationIndex(UInt32 program, ProgramInterface programInterface, String name)
        {
            return Delegates.glGetProgramResourceLocationIndex(program, programInterface, name);
        }

        public static void GetProgramResourceName(UInt32 program, ProgramInterface programInterface, UInt32 index, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder name)
        {
            Delegates.glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
        }

        public static void GetProgramStageiv(UInt32 program, ShaderType shadertype, ProgramStageParameterName pname, [Out] Int32[] values)
        {
            Delegates.glGetProgramStageiv(program, shadertype, pname, values);
        }

        public static void GetQueryIndexediv(QueryTarget target, UInt32 index, GetQueryParam pname, [Out] Int32[] @params)
        {
            Delegates.glGetQueryIndexediv(target, index, pname, @params);
        }

        public static void GetQueryiv(QueryTarget target, GetQueryParam pname, [Out] Int32[] @params)
        {
            Delegates.glGetQueryiv(target, pname, @params);
        }

        public static void GetQueryObjectiv(UInt32 id, GetQueryObjectParam pname, [Out] Int32[] @params)
        {
            Delegates.glGetQueryObjectiv(id, pname, @params);
        }

        public static void GetQueryObjectuiv(UInt32 id, GetQueryObjectParam pname, [Out] UInt32[] @params)
        {
            Delegates.glGetQueryObjectuiv(id, pname, @params);
        }

        public static void GetQueryObjecti64v(UInt32 id, GetQueryObjectParam pname, [Out] Int64[] @params)
        {
            Delegates.glGetQueryObjecti64v(id, pname, @params);
        }

        public static void GetQueryObjectui64v(UInt32 id, GetQueryObjectParam pname, [Out] UInt64[] @params)
        {
            Delegates.glGetQueryObjectui64v(id, pname, @params);
        }

        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetRenderbufferParameteriv(target, pname, @params);
        }

        public static void GetNamedRenderbufferParameteriv(UInt32 renderbuffer, RenderbufferParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params);
        }

        public static void GetSamplerParameterfv(UInt32 sampler, Int32 pname, [Out] Single[] @params)
        {
            Delegates.glGetSamplerParameterfv(sampler, pname, @params);
        }

        public static void GetSamplerParameteriv(UInt32 sampler, Int32 pname, [Out] Int32[] @params)
        {
            Delegates.glGetSamplerParameteriv(sampler, pname, @params);
        }

        public static void GetSamplerParameterIiv(UInt32 sampler, TextureParameterName pname, [Out] Int32[] @params)
        {
            Delegates.glGetSamplerParameterIiv(sampler, pname, @params);
        }

        public static void GetSamplerParameterIuiv(UInt32 sampler, TextureParameterName pname, [Out] UInt32[] @params)
        {
            Delegates.glGetSamplerParameterIuiv(sampler, pname, @params);
        }

        public static void GetShaderiv(UInt32 shader, ShaderParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetShaderiv(shader, pname, @params);
        }

        public static void GetShaderInfoLog(UInt32 shader, Int32 maxLength, [Out] Int32[] length, [Out] StringBuilder infoLog)
        {
            Delegates.glGetShaderInfoLog(shader, maxLength, length, infoLog);
        }

        public static void GetShaderPrecisionFormat(ShaderType shaderType, Int32 precisionType, [Out] Int32[] range, [Out] Int32[] precision)
        {
            Delegates.glGetShaderPrecisionFormat(shaderType, precisionType, range, precision);
        }

        public static void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32[] length, [Out] StringBuilder source)
        {
            Delegates.glGetShaderSource(shader, bufSize, length, source);
        }

        public static String GetString(StringName name)
        {
            return Marshal.PtrToStringAnsi(Delegates.glGetString(name));
        }

        public static String GetStringi(StringName name, UInt32 index)
        {
            return Marshal.PtrToStringAnsi(Delegates.glGetStringi(name, index));
        }

        public static UInt32 GetSubroutineIndex(UInt32 program, ShaderType shadertype, String name)
        {
            return Delegates.glGetSubroutineIndex(program, shadertype, name);
        }

        public static Int32 GetSubroutineUniformLocation(UInt32 program, ShaderType shadertype, String name)
        {
            return Delegates.glGetSubroutineUniformLocation(program, shadertype, name);
        }

        public static void GetSynciv(IntPtr sync, ArbSync pname, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] values)
        {
            Delegates.glGetSynciv(sync, pname, bufSize, length, values);
        }

        public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, [Out] IntPtr pixels)
        {
            Delegates.glGetTexImage(target, level, format, type, pixels);
        }

        public static void GetnTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, [Out] IntPtr pixels)
        {
            Delegates.glGetnTexImage(target, level, format, type, bufSize, pixels);
        }

        public static void GetTextureImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, [Out] IntPtr pixels)
        {
            Delegates.glGetTextureImage(texture, level, format, type, bufSize, pixels);
        }

        public static void GetTexLevelParameterfv(GetPName target, Int32 level, GetTextureLevelParameter pname, [Out] Single[] @params)
        {
            Delegates.glGetTexLevelParameterfv(target, level, pname, @params);
        }

        public static void GetTexLevelParameteriv(GetPName target, Int32 level, GetTextureLevelParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetTexLevelParameteriv(target, level, pname, @params);
        }

        public static void GetTextureLevelParameterfv(UInt32 texture, Int32 level, GetTextureLevelParameter pname, [Out] Single[] @params)
        {
            Delegates.glGetTextureLevelParameterfv(texture, level, pname, @params);
        }

        public static void GetTextureLevelParameteriv(UInt32 texture, Int32 level, GetTextureLevelParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetTextureLevelParameteriv(texture, level, pname, @params);
        }

        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, [Out] Single[] @params)
        {
            Delegates.glGetTexParameterfv(target, pname, @params);
        }

        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetTexParameteriv(target, pname, @params);
        }

        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetTexParameterIiv(target, pname, @params);
        }

        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, [Out] UInt32[] @params)
        {
            Delegates.glGetTexParameterIuiv(target, pname, @params);
        }

        public static void GetTextureParameterfv(UInt32 texture, GetTextureParameter pname, [Out] Single[] @params)
        {
            Delegates.glGetTextureParameterfv(texture, pname, @params);
        }

        public static void GetTextureParameteriv(UInt32 texture, GetTextureParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetTextureParameteriv(texture, pname, @params);
        }

        public static void GetTextureParameterIiv(UInt32 texture, GetTextureParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetTextureParameterIiv(texture, pname, @params);
        }

        public static void GetTextureParameterIuiv(UInt32 texture, GetTextureParameter pname, [Out] UInt32[] @params)
        {
            Delegates.glGetTextureParameterIuiv(texture, pname, @params);
        }

        public static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 bufSize, [Out] IntPtr pixels)
        {
            Delegates.glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
        }

        public static void GetTransformFeedbackiv(UInt32 xfb, TransformFeedbackParameterName pname, [Out] Int32[] param)
        {
            Delegates.glGetTransformFeedbackiv(xfb, pname, param);
        }

        public static void GetTransformFeedbacki_v(UInt32 xfb, TransformFeedbackParameterName pname, UInt32 index, [Out] Int32[] param)
        {
            Delegates.glGetTransformFeedbacki_v(xfb, pname, index, param);
        }

        public static void GetTransformFeedbacki64_v(UInt32 xfb, TransformFeedbackParameterName pname, UInt32 index, [Out] Int64[] param)
        {
            Delegates.glGetTransformFeedbacki64_v(xfb, pname, index, param);
        }

        public static void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32[] length, [Out] Int32[] size, [Out] ActiveAttribType[] type, [Out] StringBuilder name)
        {
            Delegates.glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
        }

        public static void GetUniformfv(UInt32 program, Int32 location, [Out] Single[] @params)
        {
            Delegates.glGetUniformfv(program, location, @params);
        }

        public static void GetUniformiv(UInt32 program, Int32 location, [Out] Int32[] @params)
        {
            Delegates.glGetUniformiv(program, location, @params);
        }

        public static void GetUniformuiv(UInt32 program, Int32 location, [Out] UInt32[] @params)
        {
            Delegates.glGetUniformuiv(program, location, @params);
        }

        public static void GetUniformdv(UInt32 program, Int32 location, [Out] Double[] @params)
        {
            Delegates.glGetUniformdv(program, location, @params);
        }

        public static void GetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, [Out] Single[] @params)
        {
            Delegates.glGetnUniformfv(program, location, bufSize, @params);
        }

        public static void GetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, [Out] Int32[] @params)
        {
            Delegates.glGetnUniformiv(program, location, bufSize, @params);
        }

        public static void GetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, [Out] UInt32[] @params)
        {
            Delegates.glGetnUniformuiv(program, location, bufSize, @params);
        }

        public static void GetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, [Out] Double[] @params)
        {
            Delegates.glGetnUniformdv(program, location, bufSize, @params);
        }

        public static UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName)
        {
            return Delegates.glGetUniformBlockIndex(program, uniformBlockName);
        }

        public static void GetUniformIndices(UInt32 program, Int32 uniformCount, String uniformNames, [Out] UInt32[] uniformIndices)
        {
            Delegates.glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
        }

        public static Int32 GetUniformLocation(UInt32 program, String name)
        {
            return Delegates.glGetUniformLocation(program, name);
        }

        public static void GetUniformSubroutineuiv(ShaderType shadertype, Int32 location, [Out] UInt32[] values)
        {
            Delegates.glGetUniformSubroutineuiv(shadertype, location, values);
        }

        public static void GetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, VertexAttribParameter pname, [Out] Int64[] param)
        {
            Delegates.glGetVertexArrayIndexed64iv(vaobj, index, pname, param);
        }

        public static void GetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, VertexAttribParameter pname, [Out] Int32[] param)
        {
            Delegates.glGetVertexArrayIndexediv(vaobj, index, pname, param);
        }

        public static void GetVertexArrayiv(UInt32 vaobj, VertexAttribParameter pname, [Out] Int32[] param)
        {
            Delegates.glGetVertexArrayiv(vaobj, pname, param);
        }

        public static void GetVertexAttribdv(UInt32 index, VertexAttribParameter pname, [Out] Double[] @params)
        {
            Delegates.glGetVertexAttribdv(index, pname, @params);
        }

        public static void GetVertexAttribdv(Int32 index, VertexAttribParameter pname, [Out] Double[] @params)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribdv((UInt32)index, pname, @params);
        }

        public static void GetVertexAttribfv(UInt32 index, VertexAttribParameter pname, [Out] Single[] @params)
        {
            Delegates.glGetVertexAttribfv(index, pname, @params);
        }

        public static void GetVertexAttribfv(Int32 index, VertexAttribParameter pname, [Out] Single[] @params)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribfv((UInt32)index, pname, @params);
        }

        public static void GetVertexAttribiv(UInt32 index, VertexAttribParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetVertexAttribiv(index, pname, @params);
        }

        public static void GetVertexAttribiv(Int32 index, VertexAttribParameter pname, [Out] Int32[] @params)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribiv((UInt32)index, pname, @params);
        }

        public static void GetVertexAttribIiv(UInt32 index, VertexAttribParameter pname, [Out] Int32[] @params)
        {
            Delegates.glGetVertexAttribIiv(index, pname, @params);
        }

        public static void GetVertexAttribIiv(Int32 index, VertexAttribParameter pname, [Out] Int32[] @params)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribIiv((UInt32)index, pname, @params);
        }

        public static void GetVertexAttribIuiv(UInt32 index, VertexAttribParameter pname, [Out] UInt32[] @params)
        {
            Delegates.glGetVertexAttribIuiv(index, pname, @params);
        }

        public static void GetVertexAttribIuiv(Int32 index, VertexAttribParameter pname, [Out] UInt32[] @params)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribIuiv((UInt32)index, pname, @params);
        }

        public static void GetVertexAttribLdv(UInt32 index, VertexAttribParameter pname, [Out] Double[] @params)
        {
            Delegates.glGetVertexAttribLdv(index, pname, @params);
        }

        public static void GetVertexAttribLdv(Int32 index, VertexAttribParameter pname, [Out] Double[] @params)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribLdv((UInt32)index, pname, @params);
        }

        public static void GetVertexAttribPointerv(UInt32 index, VertexAttribPointerParameter pname, [Out] IntPtr pointer)
        {
            Delegates.glGetVertexAttribPointerv(index, pname, pointer);
        }

        public static void GetVertexAttribPointerv(Int32 index, VertexAttribPointerParameter pname, [Out] IntPtr pointer)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glGetVertexAttribPointerv((UInt32)index, pname, pointer);
        }

        public static void Hint(HintTarget target, HintMode mode)
        {
            Delegates.glHint(target, mode);
        }

        public static void InvalidateBufferData(UInt32 buffer)
        {
            Delegates.glInvalidateBufferData(buffer);
        }

        public static void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length)
        {
            Delegates.glInvalidateBufferSubData(buffer, offset, length);
        }

        public static void InvalidateFramebuffer(FramebufferTarget target, Int32 numAttachments, FramebufferAttachment[] attachments)
        {
            Delegates.glInvalidateFramebuffer(target, numAttachments, attachments);
        }

        public static void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, FramebufferAttachment[] attachments)
        {
            Delegates.glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
        }

        public static void InvalidateSubFramebuffer(FramebufferTarget target, Int32 numAttachments, FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
        }

        public static void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
        }

        public static void InvalidateTexImage(UInt32 texture, Int32 level)
        {
            Delegates.glInvalidateTexImage(texture, level);
        }

        public static void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
        }

        public static Boolean IsBuffer(UInt32 buffer)
        {
            return Delegates.glIsBuffer(buffer);
        }

        public static Boolean IsEnabled(EnableCap cap)
        {
            return Delegates.glIsEnabled(cap);
        }

        public static Boolean IsEnabledi(EnableCap cap, UInt32 index)
        {
            return Delegates.glIsEnabledi(cap, index);
        }

        public static Boolean IsFramebuffer(UInt32 framebuffer)
        {
            return Delegates.glIsFramebuffer(framebuffer);
        }

        public static Boolean IsProgram(UInt32 program)
        {
            return Delegates.glIsProgram(program);
        }

        public static Boolean IsProgramPipeline(UInt32 pipeline)
        {
            return Delegates.glIsProgramPipeline(pipeline);
        }

        public static Boolean IsQuery(UInt32 id)
        {
            return Delegates.glIsQuery(id);
        }

        public static Boolean IsRenderbuffer(UInt32 renderbuffer)
        {
            return Delegates.glIsRenderbuffer(renderbuffer);
        }

        public static Boolean IsSampler(UInt32 id)
        {
            return Delegates.glIsSampler(id);
        }

        public static Boolean IsShader(UInt32 shader)
        {
            return Delegates.glIsShader(shader);
        }

        public static Boolean IsSync(IntPtr sync)
        {
            return Delegates.glIsSync(sync);
        }

        public static Boolean IsTexture(UInt32 texture)
        {
            return Delegates.glIsTexture(texture);
        }

        public static Boolean IsTransformFeedback(UInt32 id)
        {
            return Delegates.glIsTransformFeedback(id);
        }

        public static Boolean IsVertexArray(UInt32 array)
        {
            return Delegates.glIsVertexArray(array);
        }

        public static void LineWidth(Single width)
        {
            Delegates.glLineWidth(width);
        }

        public static void LinkProgram(UInt32 program)
        {
            Delegates.glLinkProgram(program);
        }

        public static void LogicOp(LogicOp opcode)
        {
            Delegates.glLogicOp(opcode);
        }

        public static IntPtr MapBuffer(BufferTarget target, BufferAccess access)
        {
            return Delegates.glMapBuffer(target, access);
        }

        public static IntPtr MapNamedBuffer(UInt32 buffer, BufferAccess access)
        {
            return Delegates.glMapNamedBuffer(buffer, access);
        }

        public static IntPtr MapBufferRange(BufferTarget target, IntPtr offset, IntPtr length, BufferAccessMask access)
        {
            return Delegates.glMapBufferRange(target, offset, length, access);
        }

        public static IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length, UInt32 access)
        {
            return Delegates.glMapNamedBufferRange(buffer, offset, length, access);
        }

        public static void MemoryBarrier(UInt32 barriers)
        {
            Delegates.glMemoryBarrier(barriers);
        }

        public static void MemoryBarrierByRegion(UInt32 barriers)
        {
            Delegates.glMemoryBarrierByRegion(barriers);
        }

        public static void MinSampleShading(Single value)
        {
            Delegates.glMinSampleShading(value);
        }

        public static void MultiDrawArrays(BeginMode mode, Int32[] first, Int32[] count, Int32 drawcount)
        {
            Delegates.glMultiDrawArrays(mode, first, count, drawcount);
        }

        public static void MultiDrawArraysIndirect(BeginMode mode, IntPtr indirect, Int32 drawcount, Int32 stride)
        {
            Delegates.glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
        }

        public static void MultiDrawElements(BeginMode mode, Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount)
        {
            Delegates.glMultiDrawElements(mode, count, type, indices, drawcount);
        }

        public static void MultiDrawElementsBaseVertex(BeginMode mode, Int32[] count, DrawElementsType type, IntPtr indices, Int32 drawcount, Int32[] basevertex)
        {
            Delegates.glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
        }

        public static void MultiDrawElementsIndirect(BeginMode mode, DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride)
        {
            Delegates.glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
        }

        public static void ObjectLabel(ObjectLabel identifier, UInt32 name, Int32 length, String label)
        {
            Delegates.glObjectLabel(identifier, name, length, label);
        }

        public static void ObjectPtrLabel(IntPtr ptr, Int32 length, String label)
        {
            Delegates.glObjectPtrLabel(ptr, length, label);
        }

        public static void PatchParameteri(Int32 pname, Int32 value)
        {
            Delegates.glPatchParameteri(pname, value);
        }

        public static void PatchParameterfv(Int32 pname, Single[] values)
        {
            Delegates.glPatchParameterfv(pname, values);
        }

        public static void PixelStoref(PixelStoreParameter pname, Single param)
        {
            Delegates.glPixelStoref(pname, param);
        }

        public static void PixelStorei(PixelStoreParameter pname, Int32 param)
        {
            Delegates.glPixelStorei(pname, param);
        }

        public static void PointParameterf(PointParameterName pname, Single param)
        {
            Delegates.glPointParameterf(pname, param);
        }

        public static void PointParameteri(PointParameterName pname, Int32 param)
        {
            Delegates.glPointParameteri(pname, param);
        }

        public static void PointParameterfv(PointParameterName pname, Single[] @params)
        {
            Delegates.glPointParameterfv(pname, @params);
        }

        public static void PointParameteriv(PointParameterName pname, Int32[] @params)
        {
            Delegates.glPointParameteriv(pname, @params);
        }

        public static void PointSize(Single size)
        {
            Delegates.glPointSize(size);
        }

        public static void PolygonMode(MaterialFace face, PolygonMode mode)
        {
            Delegates.glPolygonMode(face, mode);
        }

        public static void PolygonOffset(Single factor, Single units)
        {
            Delegates.glPolygonOffset(factor, units);
        }

        public static void PrimitiveRestartIndex(UInt32 index)
        {
            Delegates.glPrimitiveRestartIndex(index);
        }

        public static void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length)
        {
            Delegates.glProgramBinary(program, binaryFormat, binary, length);
        }

        public static void ProgramParameteri(UInt32 program, Version32 pname, Int32 value)
        {
            Delegates.glProgramParameteri(program, pname, value);
        }

        public static void ProgramUniform1f(UInt32 program, Int32 location, Single v0)
        {
            Delegates.glProgramUniform1f(program, location, v0);
        }

        public static void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1)
        {
            Delegates.glProgramUniform2f(program, location, v0, v1);
        }

        public static void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2)
        {
            Delegates.glProgramUniform3f(program, location, v0, v1, v2);
        }

        public static void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3)
        {
            Delegates.glProgramUniform4f(program, location, v0, v1, v2, v3);
        }

        public static void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0)
        {
            Delegates.glProgramUniform1i(program, location, v0);
        }

        public static void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1)
        {
            Delegates.glProgramUniform2i(program, location, v0, v1);
        }

        public static void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
        {
            Delegates.glProgramUniform3i(program, location, v0, v1, v2);
        }

        public static void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            Delegates.glProgramUniform4i(program, location, v0, v1, v2, v3);
        }

        public static void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0)
        {
            Delegates.glProgramUniform1ui(program, location, v0);
        }

        public static void ProgramUniform2ui(UInt32 program, Int32 location, Int32 v0, UInt32 v1)
        {
            Delegates.glProgramUniform2ui(program, location, v0, v1);
        }

        public static void ProgramUniform3ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, UInt32 v2)
        {
            Delegates.glProgramUniform3ui(program, location, v0, v1, v2);
        }

        public static void ProgramUniform4ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, UInt32 v3)
        {
            Delegates.glProgramUniform4ui(program, location, v0, v1, v2, v3);
        }

        public static void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single[] value)
        {
            Delegates.glProgramUniform1fv(program, location, count, value);
        }

        public static void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single[] value)
        {
            Delegates.glProgramUniform2fv(program, location, count, value);
        }

        public static void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single[] value)
        {
            Delegates.glProgramUniform3fv(program, location, count, value);
        }

        public static void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single[] value)
        {
            Delegates.glProgramUniform4fv(program, location, count, value);
        }

        public static void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glProgramUniform1iv(program, location, count, value);
        }

        public static void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glProgramUniform2iv(program, location, count, value);
        }

        public static void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glProgramUniform3iv(program, location, count, value);
        }

        public static void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glProgramUniform4iv(program, location, count, value);
        }

        public static void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glProgramUniform1uiv(program, location, count, value);
        }

        public static void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glProgramUniform2uiv(program, location, count, value);
        }

        public static void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glProgramUniform3uiv(program, location, count, value);
        }

        public static void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glProgramUniform4uiv(program, location, count, value);
        }

        public static void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix2fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix3fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix4fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
        }

        public static void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
        }

        public static void ProvokingVertex(ProvokingVertexMode provokeMode)
        {
            Delegates.glProvokingVertex(provokeMode);
        }

        public static void QueryCounter(UInt32 id, Int32 target)
        {
            Delegates.glQueryCounter(id, target);
        }

        public static void ReadBuffer(ReadBufferMode mode)
        {
            Delegates.glReadBuffer(mode);
        }

        public static void NamedFramebufferReadBuffer(UInt32 framebuffer, BeginMode mode)
        {
            Delegates.glNamedFramebufferReadBuffer(framebuffer, mode);
        }

        public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32[] data)
        {
            Delegates.glReadPixels(x, y, width, height, format, type, data);
        }

        public static void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 bufSize, Int32[] data)
        {
            Delegates.glReadnPixels(x, y, width, height, format, type, bufSize, data);
        }

        public static void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorage internalFormat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorage(target, internalFormat, width, height);
        }

        public static void NamedRenderbufferStorage(UInt32 renderbuffer, RenderbufferStorage internalFormat, Int32 width, Int32 height)
        {
            Delegates.glNamedRenderbufferStorage(renderbuffer, internalFormat, width, height);
        }

        public static void RenderbufferStorageMultisample(RenderbufferTarget target, Int32 samples, RenderbufferStorage internalFormat, Int32 width, Int32 height)
        {
            Delegates.glRenderbufferStorageMultisample(target, samples, internalFormat, width, height);
        }

        public static void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, RenderbufferStorage internalFormat, Int32 width, Int32 height)
        {
            Delegates.glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalFormat, width, height);
        }

        public static void SampleCoverage(Single value, Boolean invert)
        {
            Delegates.glSampleCoverage(value, invert);
        }

        public static void SampleMaski(UInt32 maskNumber, UInt32 mask)
        {
            Delegates.glSampleMaski(maskNumber, mask);
        }

        public static void SamplerParameterf(UInt32 sampler, Int32 pname, Single param)
        {
            Delegates.glSamplerParameterf(sampler, pname, param);
        }

        public static void SamplerParameteri(UInt32 sampler, Int32 pname, Int32 param)
        {
            Delegates.glSamplerParameteri(sampler, pname, param);
        }

        public static void SamplerParameterfv(UInt32 sampler, Int32 pname, Single[] @params)
        {
            Delegates.glSamplerParameterfv(sampler, pname, @params);
        }

        public static void SamplerParameteriv(UInt32 sampler, Int32 pname, Int32[] @params)
        {
            Delegates.glSamplerParameteriv(sampler, pname, @params);
        }

        public static void SamplerParameterIiv(UInt32 sampler, TextureParameterName pname, Int32[] @params)
        {
            Delegates.glSamplerParameterIiv(sampler, pname, @params);
        }

        public static void SamplerParameterIuiv(UInt32 sampler, TextureParameterName pname, UInt32[] @params)
        {
            Delegates.glSamplerParameterIuiv(sampler, pname, @params);
        }

        public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glScissor(x, y, width, height);
        }

        public static void ScissorArrayv(UInt32 first, Int32 count, Int32[] v)
        {
            Delegates.glScissorArrayv(first, count, v);
        }

        public static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
        {
            Delegates.glScissorIndexed(index, left, bottom, width, height);
        }

        public static void ScissorIndexedv(UInt32 index, Int32[] v)
        {
            Delegates.glScissorIndexedv(index, v);
        }

        public static void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryFormat, IntPtr binary, Int32 length)
        {
            Delegates.glShaderBinary(count, shaders, binaryFormat, binary, length);
        }

        public static void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length)
        {
            Delegates.glShaderSource(shader, count, @string, length);
        }

        public static void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding)
        {
            Delegates.glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
        }

        public static void StencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
        {
            Delegates.glStencilFunc(func, @ref, mask);
        }

        public static void StencilFuncSeparate(StencilFace face, StencilFunction func, Int32 @ref, UInt32 mask)
        {
            Delegates.glStencilFuncSeparate(face, func, @ref, mask);
        }

        public static void StencilMask(UInt32 mask)
        {
            Delegates.glStencilMask(mask);
        }

        public static void StencilMaskSeparate(StencilFace face, UInt32 mask)
        {
            Delegates.glStencilMaskSeparate(face, mask);
        }

        public static void StencilOp(StencilOp sfail, StencilOp dpfail, StencilOp dppass)
        {
            Delegates.glStencilOp(sfail, dpfail, dppass);
        }

        public static void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
        {
            Delegates.glStencilOpSeparate(face, sfail, dpfail, dppass);
        }

        public static void TexBuffer(TextureBufferTarget target, SizedInternalFormat internalFormat, UInt32 buffer)
        {
            Delegates.glTexBuffer(target, internalFormat, buffer);
        }

        public static void TextureBuffer(UInt32 texture, SizedInternalFormat internalFormat, UInt32 buffer)
        {
            Delegates.glTextureBuffer(texture, internalFormat, buffer);
        }

        public static void TexBufferRange(BufferTarget target, SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, IntPtr size)
        {
            Delegates.glTexBufferRange(target, internalFormat, buffer, offset, size);
        }

        public static void TextureBufferRange(UInt32 texture, SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, Int32 size)
        {
            Delegates.glTextureBufferRange(texture, internalFormat, buffer, offset, size);
        }

        public static void TexImage1D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexImage1D(target, level, internalFormat, width, border, format, type, data);
        }

        public static void TexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexImage2D(target, level, internalFormat, width, height, border, format, type, data);
        }

        public static void TexImage2DMultisample(TextureTargetMultisample target, Int32 samples, PixelInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations)
        {
            Delegates.glTexImage2DMultisample(target, samples, internalFormat, width, height, fixedsamplelocations);
        }

        public static void TexImage3D(TextureTarget target, Int32 level, PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexImage3D(target, level, internalFormat, width, height, depth, border, format, type, data);
        }

        public static void TexImage3DMultisample(TextureTargetMultisample target, Int32 samples, PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
        {
            Delegates.glTexImage3DMultisample(target, samples, internalFormat, width, height, depth, fixedsamplelocations);
        }

        public static void TexParameterf(TextureTarget target, TextureParameterName pname, Single param)
        {
            Delegates.glTexParameterf(target, pname, param);
        }

        public static void TexParameteri(TextureTarget target, TextureParameterName pname, Int32 param)
        {
            Delegates.glTexParameteri(target, pname, param);
        }

        public static void TextureParameterf(UInt32 texture, TextureParameter pname, Single param)
        {
            Delegates.glTextureParameterf(texture, pname, param);
        }

        public static void TextureParameteri(UInt32 texture, TextureParameter pname, Int32 param)
        {
            Delegates.glTextureParameteri(texture, pname, param);
        }

        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, Single[] @params)
        {
            Delegates.glTexParameterfv(target, pname, @params);
        }

        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, Int32[] @params)
        {
            Delegates.glTexParameteriv(target, pname, @params);
        }

        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, Int32[] @params)
        {
            Delegates.glTexParameterIiv(target, pname, @params);
        }

        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, UInt32[] @params)
        {
            Delegates.glTexParameterIuiv(target, pname, @params);
        }

        public static void TextureParameterfv(UInt32 texture, TextureParameter pname, Single[] paramtexture)
        {
            Delegates.glTextureParameterfv(texture, pname, paramtexture);
        }

        public static void TextureParameteriv(UInt32 texture, TextureParameter pname, Int32[] param)
        {
            Delegates.glTextureParameteriv(texture, pname, param);
        }

        public static void TextureParameterIiv(UInt32 texture, TextureParameter pname, Int32[] @params)
        {
            Delegates.glTextureParameterIiv(texture, pname, @params);
        }

        public static void TextureParameterIuiv(UInt32 texture, TextureParameter pname, UInt32[] @params)
        {
            Delegates.glTextureParameterIuiv(texture, pname, @params);
        }

        public static void TexStorage1D(TextureTarget target, Int32 levels, SizedInternalFormat internalFormat, Int32 width)
        {
            Delegates.glTexStorage1D(target, levels, internalFormat, width);
        }

        public static void TextureStorage1D(UInt32 texture, Int32 levels, SizedInternalFormat internalFormat, Int32 width)
        {
            Delegates.glTextureStorage1D(texture, levels, internalFormat, width);
        }

        public static void TexStorage2D(TextureTarget target, Int32 levels, SizedInternalFormat internalFormat, Int32 width, Int32 height)
        {
            Delegates.glTexStorage2D(target, levels, internalFormat, width, height);
        }

        public static void TextureStorage2D(UInt32 texture, Int32 levels, SizedInternalFormat internalFormat, Int32 width, Int32 height)
        {
            Delegates.glTextureStorage2D(texture, levels, internalFormat, width, height);
        }

        public static void TexStorage2DMultisample(TextureTarget target, Int32 samples, SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations)
        {
            Delegates.glTexStorage2DMultisample(target, samples, internalFormat, width, height, fixedsamplelocations);
        }

        public static void TextureStorage2DMultisample(UInt32 texture, Int32 samples, SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations)
        {
            Delegates.glTextureStorage2DMultisample(texture, samples, internalFormat, width, height, fixedsamplelocations);
        }

        public static void TexStorage3D(TextureTarget target, Int32 levels, SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glTexStorage3D(target, levels, internalFormat, width, height, depth);
        }

        public static void TextureStorage3D(UInt32 texture, Int32 levels, SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth)
        {
            Delegates.glTextureStorage3D(texture, levels, internalFormat, width, height, depth);
        }

        public static void TexStorage3DMultisample(TextureTarget target, Int32 samples, SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
        {
            Delegates.glTexStorage3DMultisample(target, samples, internalFormat, width, height, depth, fixedsamplelocations);
        }

        public static void TextureStorage3DMultisample(UInt32 texture, Int32 samples, SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations)
        {
            Delegates.glTextureStorage3DMultisample(texture, samples, internalFormat, width, height, depth, fixedsamplelocations);
        }

        public static void TexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }

        public static void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
        }

        public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public static void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public static void TexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public static void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        public static void TextureBarrier()
        {
            Delegates.glTextureBarrier();
        }

        public static void TextureView(UInt32 texture, TextureTarget target, UInt32 origtexture, PixelInternalFormat internalFormat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers)
        {
            Delegates.glTextureView(texture, target, origtexture, internalFormat, minlevel, numlevels, minlayer, numlayers);
        }

        public static void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer)
        {
            Delegates.glTransformFeedbackBufferBase(xfb, index, buffer);
        }

        public static void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, Int32 size)
        {
            Delegates.glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
        }

        public static void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, TransformFeedbackMode bufferMode)
        {
            Delegates.glTransformFeedbackVaryings(program, count, varyings, bufferMode);
        }

        public static void Uniform1f(Int32 location, Single v0)
        {
            Delegates.glUniform1f(location, v0);
        }

        public static void Uniform2f(Int32 location, Single v0, Single v1)
        {
            Delegates.glUniform2f(location, v0, v1);
        }

        public static void Uniform3f(Int32 location, Single v0, Single v1, Single v2)
        {
            Delegates.glUniform3f(location, v0, v1, v2);
        }

        public static void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3)
        {
            Delegates.glUniform4f(location, v0, v1, v2, v3);
        }

        public static void Uniform1i(Int32 location, Int32 v0)
        {
            Delegates.glUniform1i(location, v0);
        }

        public static void Uniform2i(Int32 location, Int32 v0, Int32 v1)
        {
            Delegates.glUniform2i(location, v0, v1);
        }

        public static void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2)
        {
            Delegates.glUniform3i(location, v0, v1, v2);
        }

        public static void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            Delegates.glUniform4i(location, v0, v1, v2, v3);
        }

        public static void Uniform1ui(Int32 location, UInt32 v0)
        {
            Delegates.glUniform1ui(location, v0);
        }

        public static void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1)
        {
            Delegates.glUniform2ui(location, v0, v1);
        }

        public static void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            Delegates.glUniform3ui(location, v0, v1, v2);
        }

        public static void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            Delegates.glUniform4ui(location, v0, v1, v2, v3);
        }

        public static void Uniform1fv(Int32 location, Int32 count, Single[] value)
        {
            Delegates.glUniform1fv(location, count, value);
        }

        public static void Uniform2fv(Int32 location, Int32 count, Single[] value)
        {
            Delegates.glUniform2fv(location, count, value);
        }

        public static void Uniform3fv(Int32 location, Int32 count, Single[] value)
        {
            Delegates.glUniform3fv(location, count, value);
        }

        public static void Uniform4fv(Int32 location, Int32 count, Single[] value)
        {
            Delegates.glUniform4fv(location, count, value);
        }

        public static void Uniform1iv(Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glUniform1iv(location, count, value);
        }

        public static void Uniform2iv(Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glUniform2iv(location, count, value);
        }

        public static void Uniform3iv(Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glUniform3iv(location, count, value);
        }

        public static void Uniform4iv(Int32 location, Int32 count, Int32[] value)
        {
            Delegates.glUniform4iv(location, count, value);
        }

        public static void Uniform1uiv(Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glUniform1uiv(location, count, value);
        }

        public static void Uniform2uiv(Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glUniform2uiv(location, count, value);
        }

        public static void Uniform3uiv(Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glUniform3uiv(location, count, value);
        }

        public static void Uniform4uiv(Int32 location, Int32 count, UInt32[] value)
        {
            Delegates.glUniform4uiv(location, count, value);
        }

        public static void UniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix2fv(location, count, transpose, value);
        }

        public static void UniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix3fv(location, count, transpose, value);
        }

        public static void UniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix4fv(location, count, transpose, value);
        }

        public static void UniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix2x3fv(location, count, transpose, value);
        }

        public static void UniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix3x2fv(location, count, transpose, value);
        }

        public static void UniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix2x4fv(location, count, transpose, value);
        }

        public static void UniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix4x2fv(location, count, transpose, value);
        }

        public static void UniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix3x4fv(location, count, transpose, value);
        }

        public static void UniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value)
        {
            Delegates.glUniformMatrix4x3fv(location, count, transpose, value);
        }

        public static void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
        {
            Delegates.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
        }

        public static void UniformSubroutinesuiv(ShaderType shadertype, Int32 count, UInt32[] indices)
        {
            Delegates.glUniformSubroutinesuiv(shadertype, count, indices);
        }

        public static Boolean UnmapBuffer(BufferTarget target)
        {
            return Delegates.glUnmapBuffer(target);
        }

        public static Boolean UnmapNamedBuffer(UInt32 buffer)
        {
            return Delegates.glUnmapNamedBuffer(buffer);
        }

        public static void UseProgram(UInt32 program)
        {
            Delegates.glUseProgram(program);
        }

        public static void UseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program)
        {
            Delegates.glUseProgramStages(pipeline, stages, program);
        }

        public static void ValidateProgram(UInt32 program)
        {
            Delegates.glValidateProgram(program);
        }

        public static void ValidateProgramPipeline(UInt32 pipeline)
        {
            Delegates.glValidateProgramPipeline(pipeline);
        }

        public static void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer)
        {
            Delegates.glVertexArrayElementBuffer(vaobj, buffer);
        }

        public static void VertexAttrib1f(UInt32 index, Single v0)
        {
            Delegates.glVertexAttrib1f(index, v0);
        }

        public static void VertexAttrib1f(Int32 index, Single v0)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib1f((UInt32)index, v0);
        }

        public static void VertexAttrib1s(UInt32 index, Int16 v0)
        {
            Delegates.glVertexAttrib1s(index, v0);
        }

        public static void VertexAttrib1s(Int32 index, Int16 v0)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib1s((UInt32)index, v0);
        }

        public static void VertexAttrib1d(UInt32 index, Double v0)
        {
            Delegates.glVertexAttrib1d(index, v0);
        }

        public static void VertexAttrib1d(Int32 index, Double v0)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib1d((UInt32)index, v0);
        }

        public static void VertexAttribI1i(UInt32 index, Int32 v0)
        {
            Delegates.glVertexAttribI1i(index, v0);
        }

        public static void VertexAttribI1i(Int32 index, Int32 v0)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI1i((UInt32)index, v0);
        }

        public static void VertexAttribI1ui(UInt32 index, UInt32 v0)
        {
            Delegates.glVertexAttribI1ui(index, v0);
        }

        public static void VertexAttribI1ui(Int32 index, UInt32 v0)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI1ui((UInt32)index, v0);
        }

        public static void VertexAttrib2f(UInt32 index, Single v0, Single v1)
        {
            Delegates.glVertexAttrib2f(index, v0, v1);
        }

        public static void VertexAttrib2f(Int32 index, Single v0, Single v1)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib2f((UInt32)index, v0, v1);
        }

        public static void VertexAttrib2s(UInt32 index, Int16 v0, Int16 v1)
        {
            Delegates.glVertexAttrib2s(index, v0, v1);
        }

        public static void VertexAttrib2s(Int32 index, Int16 v0, Int16 v1)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib2s((UInt32)index, v0, v1);
        }

        public static void VertexAttrib2d(UInt32 index, Double v0, Double v1)
        {
            Delegates.glVertexAttrib2d(index, v0, v1);
        }

        public static void VertexAttrib2d(Int32 index, Double v0, Double v1)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib2d((UInt32)index, v0, v1);
        }

        public static void VertexAttribI2i(UInt32 index, Int32 v0, Int32 v1)
        {
            Delegates.glVertexAttribI2i(index, v0, v1);
        }

        public static void VertexAttribI2i(Int32 index, Int32 v0, Int32 v1)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI2i((UInt32)index, v0, v1);
        }

        public static void VertexAttribI2ui(UInt32 index, UInt32 v0, UInt32 v1)
        {
            Delegates.glVertexAttribI2ui(index, v0, v1);
        }

        public static void VertexAttribI2ui(Int32 index, UInt32 v0, UInt32 v1)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI2ui((UInt32)index, v0, v1);
        }

        public static void VertexAttrib3f(UInt32 index, Single v0, Single v1, Single v2)
        {
            Delegates.glVertexAttrib3f(index, v0, v1, v2);
        }

        public static void VertexAttrib3f(Int32 index, Single v0, Single v1, Single v2)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib3f((UInt32)index, v0, v1, v2);
        }

        public static void VertexAttrib3s(UInt32 index, Int16 v0, Int16 v1, Int16 v2)
        {
            Delegates.glVertexAttrib3s(index, v0, v1, v2);
        }

        public static void VertexAttrib3s(Int32 index, Int16 v0, Int16 v1, Int16 v2)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib3s((UInt32)index, v0, v1, v2);
        }

        public static void VertexAttrib3d(UInt32 index, Double v0, Double v1, Double v2)
        {
            Delegates.glVertexAttrib3d(index, v0, v1, v2);
        }

        public static void VertexAttrib3d(Int32 index, Double v0, Double v1, Double v2)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib3d((UInt32)index, v0, v1, v2);
        }

        public static void VertexAttribI3i(UInt32 index, Int32 v0, Int32 v1, Int32 v2)
        {
            Delegates.glVertexAttribI3i(index, v0, v1, v2);
        }

        public static void VertexAttribI3i(Int32 index, Int32 v0, Int32 v1, Int32 v2)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI3i((UInt32)index, v0, v1, v2);
        }

        public static void VertexAttribI3ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            Delegates.glVertexAttribI3ui(index, v0, v1, v2);
        }

        public static void VertexAttribI3ui(Int32 index, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI3ui((UInt32)index, v0, v1, v2);
        }

        public static void VertexAttrib4f(UInt32 index, Single v0, Single v1, Single v2, Single v3)
        {
            Delegates.glVertexAttrib4f(index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4f(Int32 index, Single v0, Single v1, Single v2, Single v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4f((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4s(UInt32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3)
        {
            Delegates.glVertexAttrib4s(index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4s(Int32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4s((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4d(UInt32 index, Double v0, Double v1, Double v2, Double v3)
        {
            Delegates.glVertexAttrib4d(index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4d(Int32 index, Double v0, Double v1, Double v2, Double v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4d((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4Nub(UInt32 index, Byte v0, Byte v1, Byte v2, Byte v3)
        {
            Delegates.glVertexAttrib4Nub(index, v0, v1, v2, v3);
        }

        public static void VertexAttrib4Nub(Int32 index, Byte v0, Byte v1, Byte v2, Byte v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Nub((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttribI4i(UInt32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            Delegates.glVertexAttribI4i(index, v0, v1, v2, v3);
        }

        public static void VertexAttribI4i(Int32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4i((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttribI4ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            Delegates.glVertexAttribI4ui(index, v0, v1, v2, v3);
        }

        public static void VertexAttribI4ui(Int32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4ui((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttribL1d(UInt32 index, Double v0)
        {
            Delegates.glVertexAttribL1d(index, v0);
        }

        public static void VertexAttribL1d(Int32 index, Double v0)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL1d((UInt32)index, v0);
        }

        public static void VertexAttribL2d(UInt32 index, Double v0, Double v1)
        {
            Delegates.glVertexAttribL2d(index, v0, v1);
        }

        public static void VertexAttribL2d(Int32 index, Double v0, Double v1)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL2d((UInt32)index, v0, v1);
        }

        public static void VertexAttribL3d(UInt32 index, Double v0, Double v1, Double v2)
        {
            Delegates.glVertexAttribL3d(index, v0, v1, v2);
        }

        public static void VertexAttribL3d(Int32 index, Double v0, Double v1, Double v2)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL3d((UInt32)index, v0, v1, v2);
        }

        public static void VertexAttribL4d(UInt32 index, Double v0, Double v1, Double v2, Double v3)
        {
            Delegates.glVertexAttribL4d(index, v0, v1, v2, v3);
        }

        public static void VertexAttribL4d(Int32 index, Double v0, Double v1, Double v2, Double v3)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL4d((UInt32)index, v0, v1, v2, v3);
        }

        public static void VertexAttrib1fv(UInt32 index, Single[] v)
        {
            Delegates.glVertexAttrib1fv(index, v);
        }

        public static void VertexAttrib1fv(Int32 index, Single[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib1fv((UInt32)index, v);
        }

        public static void VertexAttrib1sv(UInt32 index, Int16[] v)
        {
            Delegates.glVertexAttrib1sv(index, v);
        }

        public static void VertexAttrib1sv(Int32 index, Int16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib1sv((UInt32)index, v);
        }

        public static void VertexAttrib1dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttrib1dv(index, v);
        }

        public static void VertexAttrib1dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib1dv((UInt32)index, v);
        }

        public static void VertexAttribI1iv(UInt32 index, Int32[] v)
        {
            Delegates.glVertexAttribI1iv(index, v);
        }

        public static void VertexAttribI1iv(Int32 index, Int32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI1iv((UInt32)index, v);
        }

        public static void VertexAttribI1uiv(UInt32 index, UInt32[] v)
        {
            Delegates.glVertexAttribI1uiv(index, v);
        }

        public static void VertexAttribI1uiv(Int32 index, UInt32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI1uiv((UInt32)index, v);
        }

        public static void VertexAttrib2fv(UInt32 index, Single[] v)
        {
            Delegates.glVertexAttrib2fv(index, v);
        }

        public static void VertexAttrib2fv(Int32 index, Single[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib2fv((UInt32)index, v);
        }

        public static void VertexAttrib2sv(UInt32 index, Int16[] v)
        {
            Delegates.glVertexAttrib2sv(index, v);
        }

        public static void VertexAttrib2sv(Int32 index, Int16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib2sv((UInt32)index, v);
        }

        public static void VertexAttrib2dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttrib2dv(index, v);
        }

        public static void VertexAttrib2dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib2dv((UInt32)index, v);
        }

        public static void VertexAttribI2iv(UInt32 index, Int32[] v)
        {
            Delegates.glVertexAttribI2iv(index, v);
        }

        public static void VertexAttribI2iv(Int32 index, Int32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI2iv((UInt32)index, v);
        }

        public static void VertexAttribI2uiv(UInt32 index, UInt32[] v)
        {
            Delegates.glVertexAttribI2uiv(index, v);
        }

        public static void VertexAttribI2uiv(Int32 index, UInt32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI2uiv((UInt32)index, v);
        }

        public static void VertexAttrib3fv(UInt32 index, Single[] v)
        {
            Delegates.glVertexAttrib3fv(index, v);
        }

        public static void VertexAttrib3fv(Int32 index, Single[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib3fv((UInt32)index, v);
        }

        public static void VertexAttrib3sv(UInt32 index, Int16[] v)
        {
            Delegates.glVertexAttrib3sv(index, v);
        }

        public static void VertexAttrib3sv(Int32 index, Int16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib3sv((UInt32)index, v);
        }

        public static void VertexAttrib3dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttrib3dv(index, v);
        }

        public static void VertexAttrib3dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib3dv((UInt32)index, v);
        }

        public static void VertexAttribI3iv(UInt32 index, Int32[] v)
        {
            Delegates.glVertexAttribI3iv(index, v);
        }

        public static void VertexAttribI3iv(Int32 index, Int32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI3iv((UInt32)index, v);
        }

        public static void VertexAttribI3uiv(UInt32 index, UInt32[] v)
        {
            Delegates.glVertexAttribI3uiv(index, v);
        }

        public static void VertexAttribI3uiv(Int32 index, UInt32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI3uiv((UInt32)index, v);
        }

        public static void VertexAttrib4fv(UInt32 index, Single[] v)
        {
            Delegates.glVertexAttrib4fv(index, v);
        }

        public static void VertexAttrib4fv(Int32 index, Single[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4fv((UInt32)index, v);
        }

        public static void VertexAttrib4sv(UInt32 index, Int16[] v)
        {
            Delegates.glVertexAttrib4sv(index, v);
        }

        public static void VertexAttrib4sv(Int32 index, Int16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4sv((UInt32)index, v);
        }

        public static void VertexAttrib4dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttrib4dv(index, v);
        }

        public static void VertexAttrib4dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4dv((UInt32)index, v);
        }

        public static void VertexAttrib4iv(UInt32 index, Int32[] v)
        {
            Delegates.glVertexAttrib4iv(index, v);
        }

        public static void VertexAttrib4iv(Int32 index, Int32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4iv((UInt32)index, v);
        }

        public static void VertexAttrib4bv(UInt32 index, SByte[] v)
        {
            Delegates.glVertexAttrib4bv(index, v);
        }

        public static void VertexAttrib4bv(Int32 index, SByte[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4bv((UInt32)index, v);
        }

        public static void VertexAttrib4ubv(UInt32 index, Byte[] v)
        {
            Delegates.glVertexAttrib4ubv(index, v);
        }

        public static void VertexAttrib4ubv(Int32 index, Byte[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4ubv((UInt32)index, v);
        }

        public static void VertexAttrib4usv(UInt32 index, UInt16[] v)
        {
            Delegates.glVertexAttrib4usv(index, v);
        }

        public static void VertexAttrib4usv(Int32 index, UInt16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4usv((UInt32)index, v);
        }

        public static void VertexAttrib4uiv(UInt32 index, UInt32[] v)
        {
            Delegates.glVertexAttrib4uiv(index, v);
        }

        public static void VertexAttrib4uiv(Int32 index, UInt32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4uiv((UInt32)index, v);
        }

        public static void VertexAttrib4Nbv(UInt32 index, SByte[] v)
        {
            Delegates.glVertexAttrib4Nbv(index, v);
        }

        public static void VertexAttrib4Nbv(Int32 index, SByte[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Nbv((UInt32)index, v);
        }

        public static void VertexAttrib4Nsv(UInt32 index, Int16[] v)
        {
            Delegates.glVertexAttrib4Nsv(index, v);
        }

        public static void VertexAttrib4Nsv(Int32 index, Int16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Nsv((UInt32)index, v);
        }

        public static void VertexAttrib4Niv(UInt32 index, Int32[] v)
        {
            Delegates.glVertexAttrib4Niv(index, v);
        }

        public static void VertexAttrib4Niv(Int32 index, Int32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Niv((UInt32)index, v);
        }

        public static void VertexAttrib4Nubv(UInt32 index, Byte[] v)
        {
            Delegates.glVertexAttrib4Nubv(index, v);
        }

        public static void VertexAttrib4Nubv(Int32 index, Byte[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Nubv((UInt32)index, v);
        }

        public static void VertexAttrib4Nusv(UInt32 index, UInt16[] v)
        {
            Delegates.glVertexAttrib4Nusv(index, v);
        }

        public static void VertexAttrib4Nusv(Int32 index, UInt16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Nusv((UInt32)index, v);
        }

        public static void VertexAttrib4Nuiv(UInt32 index, UInt32[] v)
        {
            Delegates.glVertexAttrib4Nuiv(index, v);
        }

        public static void VertexAttrib4Nuiv(Int32 index, UInt32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttrib4Nuiv((UInt32)index, v);
        }

        public static void VertexAttribI4bv(UInt32 index, SByte[] v)
        {
            Delegates.glVertexAttribI4bv(index, v);
        }

        public static void VertexAttribI4bv(Int32 index, SByte[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4bv((UInt32)index, v);
        }

        public static void VertexAttribI4ubv(UInt32 index, Byte[] v)
        {
            Delegates.glVertexAttribI4ubv(index, v);
        }

        public static void VertexAttribI4ubv(Int32 index, Byte[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4ubv((UInt32)index, v);
        }

        public static void VertexAttribI4sv(UInt32 index, Int16[] v)
        {
            Delegates.glVertexAttribI4sv(index, v);
        }

        public static void VertexAttribI4sv(Int32 index, Int16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4sv((UInt32)index, v);
        }

        public static void VertexAttribI4usv(UInt32 index, UInt16[] v)
        {
            Delegates.glVertexAttribI4usv(index, v);
        }

        public static void VertexAttribI4usv(Int32 index, UInt16[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4usv((UInt32)index, v);
        }

        public static void VertexAttribI4iv(UInt32 index, Int32[] v)
        {
            Delegates.glVertexAttribI4iv(index, v);
        }

        public static void VertexAttribI4iv(Int32 index, Int32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4iv((UInt32)index, v);
        }

        public static void VertexAttribI4uiv(UInt32 index, UInt32[] v)
        {
            Delegates.glVertexAttribI4uiv(index, v);
        }

        public static void VertexAttribI4uiv(Int32 index, UInt32[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribI4uiv((UInt32)index, v);
        }

        public static void VertexAttribL1dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttribL1dv(index, v);
        }

        public static void VertexAttribL1dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL1dv((UInt32)index, v);
        }

        public static void VertexAttribL2dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttribL2dv(index, v);
        }

        public static void VertexAttribL2dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL2dv((UInt32)index, v);
        }

        public static void VertexAttribL3dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttribL3dv(index, v);
        }

        public static void VertexAttribL3dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL3dv((UInt32)index, v);
        }

        public static void VertexAttribL4dv(UInt32 index, Double[] v)
        {
            Delegates.glVertexAttribL4dv(index, v);
        }

        public static void VertexAttribL4dv(Int32 index, Double[] v)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribL4dv((UInt32)index, v);
        }

        public static void VertexAttribP1ui(UInt32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            Delegates.glVertexAttribP1ui(index, type, normalized, value);
        }

        public static void VertexAttribP1ui(Int32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribP1ui((UInt32)index, type, normalized, value);
        }

        public static void VertexAttribP2ui(UInt32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            Delegates.glVertexAttribP2ui(index, type, normalized, value);
        }

        public static void VertexAttribP2ui(Int32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribP2ui((UInt32)index, type, normalized, value);
        }

        public static void VertexAttribP3ui(UInt32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            Delegates.glVertexAttribP3ui(index, type, normalized, value);
        }

        public static void VertexAttribP3ui(Int32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribP3ui((UInt32)index, type, normalized, value);
        }

        public static void VertexAttribP4ui(UInt32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            Delegates.glVertexAttribP4ui(index, type, normalized, value);
        }

        public static void VertexAttribP4ui(Int32 index, VertexAttribPType type, Boolean normalized, UInt32 value)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribP4ui((UInt32)index, type, normalized, value);
        }

        public static void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex)
        {
            Delegates.glVertexAttribBinding(attribindex, bindingindex);
        }

        public static void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex)
        {
            Delegates.glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
        }

        public static void VertexAttribDivisor(UInt32 index, UInt32 divisor)
        {
            Delegates.glVertexAttribDivisor(index, divisor);
        }

        public static void VertexAttribDivisor(Int32 index, UInt32 divisor)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribDivisor((UInt32)index, divisor);
        }

        public static void VertexAttribFormat(UInt32 attribindex, Int32 size, VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset)
        {
            Delegates.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
        }

        public static void VertexAttribIFormat(UInt32 attribindex, Int32 size, VertexAttribFormat type, UInt32 relativeoffset)
        {
            Delegates.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
        }

        public static void VertexAttribLFormat(UInt32 attribindex, Int32 size, VertexAttribFormat type, UInt32 relativeoffset)
        {
            Delegates.glVertexAttribLFormat(attribindex, size, type, relativeoffset);
        }

        public static void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset)
        {
            Delegates.glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
        }

        public static void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribFormat type, UInt32 relativeoffset)
        {
            Delegates.glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
        }

        public static void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribFormat type, UInt32 relativeoffset)
        {
            Delegates.glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
        }

        public static void VertexAttribPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
        }

        public static void VertexAttribPointer(Int32 index, Int32 size, VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribPointer((UInt32)index, size, type, normalized, stride, pointer);
        }

        public static void VertexAttribIPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribIPointer(index, size, type, stride, pointer);
        }

        public static void VertexAttribIPointer(Int32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribIPointer((UInt32)index, size, type, stride, pointer);
        }

        public static void VertexAttribLPointer(UInt32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
        {
            Delegates.glVertexAttribLPointer(index, size, type, stride, pointer);
        }

        public static void VertexAttribLPointer(Int32 index, Int32 size, VertexAttribPointerType type, Int32 stride, IntPtr pointer)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));
            Delegates.glVertexAttribLPointer((UInt32)index, size, type, stride, pointer);
        }

        public static void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor)
        {
            Delegates.glVertexBindingDivisor(bindingindex, divisor);
        }

        public static void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor)
        {
            Delegates.glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
        }

        public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            Delegates.glViewport(x, y, width, height);
        }

        public static void ViewportArrayv(UInt32 first, Int32 count, Single[] v)
        {
            Delegates.glViewportArrayv(first, count, v);
        }

        public static void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h)
        {
            Delegates.glViewportIndexedf(index, x, y, w, h);
        }

        public static void ViewportIndexedfv(UInt32 index, Single[] v)
        {
            Delegates.glViewportIndexedfv(index, v);
        }

        public static void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
        {
            Delegates.glWaitSync(sync, flags, timeout);
        }
    }
}
