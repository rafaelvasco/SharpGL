using System;

namespace SharpGL
{
    public enum ActiveAttribType
    {
        Float = 0x1406,
        FloatVec2 = 0x8B50,
        FloatVec3 = 0x8B51,
        FloatVec4 = 0x8B52,
        FloatMat2 = 0x8B5A,
        FloatMat3 = 0x8B5B,
        FloatMat4 = 0x8B5C
    }

    public enum ActiveUniformBlockParameter
    {
        UniformBlockBinding = 0x8A3F,
        UniformBlockDataSize = 0x8A40,
        UniformBlockNameLength = 0x8A41,
        UniformBlockActiveUniforms = 0x8A42,
        UniformBlockActiveUniformIndices = 0x8A43,
        UniformBlockReferencedByVertexShader = 0x8A44,
        UniformBlockReferencedByFragmentShader = 0x8A46
    }

    public enum ActiveUniformType
    {
        Int = 0x1404,
        Float = 0x1406,
        FloatVec2 = 0x8B50,
        FloatVec3 = 0x8B51,
        FloatVec4 = 0x8B52,
        IntVec2 = 0x8B53,
        IntVec3 = 0x8B54,
        IntVec4 = 0x8B55,
        Bool = 0x8B56,
        BoolVec2 = 0x8B57,
        BoolVec3 = 0x8B58,
        BoolVec4 = 0x8B59,
        FloatMat2 = 0x8B5A,
        FloatMat3 = 0x8B5B,
        FloatMat4 = 0x8B5C,
        Sampler1D = 0x8B5D,
        Sampler2D = 0x8B5E,
        Sampler3D = 0x8B5F,
        SamplerCube = 0x8B60,
        Sampler1DShadow = 0x8B61,
        Sampler2DShadow = 0x8B62,
        Sampler2DRect = 0x8B63,
        Sampler2DRectShadow = 0x8B64,
        FloatMat2x3 = 0x8B65,
        FloatMat2x4 = 0x8B66,
        FloatMat3x2 = 0x8B67,
        FloatMat3x4 = 0x8B68,
        FloatMat4x2 = 0x8B69,
        FloatMat4x3 = 0x8B6A,
        Sampler1DArray = 0x8DC0,
        Sampler2DArray = 0x8DC1,
        SamplerBuffer = 0x8DC2,
        Sampler1DArrayShadow = 0x8DC3,
        Sampler2DArrayShadow = 0x8DC4,
        SamplerCubeShadow = 0x8DC5,
        UnsignedIntVec2 = 0x8DC6,
        UnsignedIntVec3 = 0x8DC7,
        UnsignedIntVec4 = 0x8DC8,
        IntSampler1D = 0x8DC9,
        IntSampler2D = 0x8DCA,
        IntSampler3D = 0x8DCB,
        IntSamplerCube = 0x8DCC,
        IntSampler2DRect = 0x8DCD,
        IntSampler1DArray = 0x8DCE,
        IntSampler2DArray = 0x8DCF,
        IntSamplerBuffer = 0x8DD0,
        UnsignedIntSampler1D = 0x8DD1,
        UnsignedIntSampler2D = 0x8DD2,
        UnsignedIntSampler3D = 0x8DD3,
        UnsignedIntSamplerCube = 0x8DD4,
        UnsignedIntSampler2DRect = 0x8DD5,
        UnsignedIntSampler1DArray = 0x8DD6,
        UnsignedIntSampler2DArray = 0x8DD7,
        UnsignedIntSamplerBuffer = 0x8DD8,
        Sampler2DMultisample = 0x9108,
        IntSampler2DMultisample = 0x9109,
        UnsignedIntSampler2DMultisample = 0x910A,
        Sampler2DMultisampleArray = 0x910B,
        IntSampler2DMultisampleArray = 0x910C,
        UnsignedIntSampler2DMultisampleArray = 0x910D
    }

    public enum ArbSync
    {
        SyncFlushCommandsBit = 0x00000001,
        MaxServerWaitTimeout = 0x9111,
        ObjectType = 0x9112,
        SyncCondition = 0x9113,
        SyncStatus = 0x9114,
        SyncFlags = 0x9115,
        SyncFence = 0x9116,
        SyncGpuCommandsComplete = 0x9117,
        Unsignaled = 0x9118,
        Signaled = 0x9119,
        AlreadySignaled = 0x911A,
        TimeoutExpired = 0x911B,
        ConditionSatisfied = 0x911C,
        WaitFailed = 0x911D,
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)
    }

    public enum AtomicCounterParameterName
    {
        AtomicCounterBufferBinding = 0x92C1,
        AtomicCounterBufferDataSize = 0x92C4,
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
        AtomicCounterBufferReferencedByComputeShader = 0x90ED
    }

    public enum BeginFeedbackMode
    {
        Points = 0x0000,
        Lines = 0x0001,
        Triangles = 0x0004
    }

    public enum BeginMode
    {
        Points = 0x0000,
        Lines = 0x0001,
        LineLoop = 0x0002,
        LineStrip = 0x0003,
        Triangles = 0x0004,
        TriangleStrip = 0x0005,
        TriangleFan = 0x0006,
        LinesAdjacency = 0xA,
        LineStripAdjacency = 0xB,
        TrianglesAdjacency = 0xC,
        TriangleStripAdjacency = 0xD,
        Patches = 0xE,
        [Obsolete("OpenGL 4 Core does not support quads.")]
        Quads = 0x0007,
        [Obsolete("OpenGL 4 Core does not support quads.")]
        QuadStrip = 0x0008
    }

    public enum BlendEquationMode
    {
        FuncAdd = 0x8006,
        Min = 0x8007,
        Max = 0x8008,
        FuncSubtract = 0x800A,
        FuncReverseSubtract = 0x800B
    }

    public enum BlendingFactorDest
    {
        Zero = 0,
        SrcColor = 0x0300,
        OneMinusSrcColor = 0x0301,
        SrcAlpha = 0x0302,
        OneMinusSrcAlpha = 0x0303,
        DstAlpha = 0x0304,
        OneMinusDstAlpha = 0x0305,
        DstColor = 0x0306,
        OneMinusDstColor = 0x0307,
        ConstantColor = 0x8001,
        ConstantColorExt = 0x8001,
        OneMinusConstantColor = 0x8002,
        OneMinusConstantColorExt = 0x8002,
        ConstantAlpha = 0x8003,
        ConstantAlphaExt = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        OneMinusConstantAlphaExt = 0x8004,
        One = 1
    }

    public enum BlendingFactorSrc
    {
        Zero = 0,
        SrcAlpha = 0x0302,
        OneMinusSrcAlpha = 0x0303,
        DstAlpha = 0x0304,
        OneMinusDstAlpha = 0x0305,
        DstColor = 0x0306,
        OneMinusDstColor = 0x0307,
        SrcAlphaSaturate = 0x0308,
        ConstantColor = 0x8001,
        ConstantColorExt = 0x8001,
        OneMinusConstantColor = 0x8002,
        OneMinusConstantColorExt = 0x8002,
        ConstantAlpha = 0x8003,
        ConstantAlphaExt = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        OneMinusConstantAlphaExt = 0x8004,
        One = 1
    }

    public enum BlitFramebufferFilter
    {
        Nearest = 0x2600,
        Linear = 0x2601
    }

    public enum BufferAccess
    {
        ReadOnly = 0x88B8,
        WriteOnly = 0x88B9,
        ReadWrite = 0x88BA
    }

    [Flags]
    public enum BufferAccessMask
    {
        MapReadBit = 0x0001,
        MapWriteBit = 0x0002,
        MapInvalidateRangeBit = 0x0004,
        MapInvalidateBufferBit = 0x0008,
        MapFlushExplicitBit = 0x0010,
        MapUnsynchronizedBit = 0x0020
    }

    public enum BufferParameterName
    {
        BufferSize = 0x8764,
        BufferUsage = 0x8765,
        BufferAccess = 0x88BB,
        BufferMapped = 0x88BC
    }

    public enum BufferPointer
    {
        BufferMapPointer = 0x88BD
    }

    public enum BufferTarget
    {
        ArrayBuffer = 0x8892,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        UniformBuffer = 0x8A11,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DrawIndirectBuffer = 0x8F3F,
        AtomicCounterBuffer = 0x92C0,
        DispatchIndirectBuffer = 0x90EE,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2
    }

    public enum BufferUsageHint
    {
        StreamDraw = 0x88E0,
        StreamRead = 0x88E1,
        StreamCopy = 0x88E2,
        StaticDraw = 0x88E4,
        StaticRead = 0x88E5,
        StaticCopy = 0x88E6,
        DynamicDraw = 0x88E8,
        DynamicRead = 0x88E9,
        DynamicCopy = 0x88EA
    }

    public enum ClampColorMode
    {
        False = 0,
        FixedOnly = 0x891D,
        True = 1
    }

    public enum ClampColorTarget
    {
        ClampVertexColor = 0x891A,
        ClampFragmentColor = 0x891B,
        ClampReadColor = 0x891C
    }

    public enum ClearBuffer
    {
        Color = 0x1800,
        Depth = 0x1801,
        Stencil = 0x1802,
        DepthStencil = 0x84F9
    }

    [Flags]
    public enum ClearBufferMask
    {
        DepthBufferBit = 0x00000100,
        AccumBufferBit = 0x00000200,
        StencilBufferBit = 0x00000400,
        ColorBufferBit = 0x00004000
    }

    public enum ClipControlOrigin
    {
        LowerLeft = 0x8CA1,
        UpperLeft = 0x8CA2
    }

    public enum ClipControlDepth
    {
        NegativeOneToOne = 0x935E,
        ZeroToOne = 0x935F
    }

    public enum ConditionalRenderType
    {
        QueryWait = 0x8E13,
        QueryNoWait = 0x8E14,
        QueryByRegionWait = 0x8E15,
        QueryByRegionNoWait = 0x8E16
    }

    public enum CullFaceMode
    {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408
    }

    public enum DepthFunction
    {
        Never = 0x0200,
        Less = 0x0201,
        Equal = 0x0202,
        Lequal = 0x0203,
        Greater = 0x0204,
        Notequal = 0x0205,
        Gequal = 0x0206,
        Always = 0x0207
    }

    public enum DrawBuffersEnum
    {
        None = 0,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment15 = 0x8CEF
    }

    public enum DrawBufferMode
    {
        None = 0,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        Back = 0x0405,
        Left = 0x0406,
        Right = 0x0407,
        FrontAndBack = 0x0408,
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment15 = 0x8CEF
    }

    public enum DrawElementsType
    {
        UnsignedByte = 0x1401,
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405
    }

    public enum EnableCap
    {
        //PointSmooth = ((int)0x0B10),
        LineSmooth = 0x0B20,
        //LineStipple = ((int)0x0B24),
        PolygonSmooth = 0x0B41,
        //PolygonStipple = ((int)0x0B42),
        CullFace = 0x0B44,
        //Lighting = ((int)0x0B50),
        //ColorMaterial = ((int)0x0B57),
        //Fog = ((int)0x0B60),
        DepthTest = 0x0B71,
        StencilTest = 0x0B90,
        //Normalize = ((int)0x0BA1),
        //AlphaTest = ((int)0x0BC0),
        Dither = 0x0BD0,
        Blend = 0x0BE2,
        IndexLogicOp = 0x0BF1,
        ColorLogicOp = 0x0BF2,
        ScissorTest = 0x0C11,
        /*TextureGenS = ((int)0x0C60),
        TextureGenT = ((int)0x0C61),
        TextureGenR = ((int)0x0C62),
        TextureGenQ = ((int)0x0C63),*/
        AutoNormal = 0x0D80,
        Map1Color4 = 0x0D90,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        Texture1D = 0x0DE0,
        Texture2D = 0x0DE1,
        PolygonOffsetPoint = 0x2A01,
        PolygonOffsetLine = 0x2A02,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
        /*Light0 = ((int)0x4000),
        Light1 = ((int)0x4001),
        Light2 = ((int)0x4002),
        Light3 = ((int)0x4003),
        Light4 = ((int)0x4004),
        Light5 = ((int)0x4005),
        Light6 = ((int)0x4006),
        Light7 = ((int)0x4007),*/
        Convolution1D = 0x8010,
        Convolution1DExt = 0x8010,
        Convolution2D = 0x8011,
        Convolution2DExt = 0x8011,
        Separable2D = 0x8012,
        Separable2DExt = 0x8012,
        Histogram = 0x8024,
        HistogramExt = 0x8024,
        MinmaxExt = 0x802E,
        PolygonOffsetFill = 0x8037,
        //RescaleNormal = ((int)0x803A),
        RescaleNormalExt = 0x803A,
        Texture3DExt = 0x806F,
        VertexArray = 0x8074,
        NormalArray = 0x8075,
        ColorArray = 0x8076,
        IndexArray = 0x8077,
        TextureCoordArray = 0x8078,
        EdgeFlagArray = 0x8079,
        InterlaceSgix = 0x8094,
        Multisample = 0x809D,
        SampleAlphaToCoverage = 0x809E,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOne = 0x809F,
        SampleAlphaToOneSgis = 0x809F,
        SampleCoverage = 0x80A0,
        SampleMaskSgis = 0x80A0,
        TextureColorTableSgi = 0x80BC,
        ColorTable = 0x80D0,
        ColorTableSgi = 0x80D0,
        PostConvolutionColorTable = 0x80D1,
        PostConvolutionColorTableSgi = 0x80D1,
        PostColorMatrixColorTable = 0x80D2,
        PostColorMatrixColorTableSgi = 0x80D2,
        Texture4DSgis = 0x8134,
        PixelTexGenSgix = 0x8139,
        SpriteSgix = 0x8148,
        ReferencePlaneSgix = 0x817D,
        IrInstrument1Sgix = 0x817F,
        CalligraphicFragmentSgix = 0x8183,
        FramezoomSgix = 0x818B,
        FogOffsetSgix = 0x8198,
        SharedTexturePaletteExt = 0x81FB,
        AsyncHistogramSgix = 0x832C,
        PixelTextureSgis = 0x8353,
        AsyncTexImageSgix = 0x835C,
        AsyncDrawPixelsSgix = 0x835D,
        AsyncReadPixelsSgix = 0x835E,
        FragmentLightingSgix = 0x8400,
        FragmentColorMaterialSgix = 0x8401,
        FragmentLight0Sgix = 0x840C,
        FragmentLight1Sgix = 0x840D,
        FragmentLight2Sgix = 0x840E,
        FragmentLight3Sgix = 0x840F,
        FragmentLight4Sgix = 0x8410,
        FragmentLight5Sgix = 0x8411,
        FragmentLight6Sgix = 0x8412,
        FragmentLight7Sgix = 0x8413,
        //FogCoordArray = ((int)0x8457),
        ColorSum = 0x8458,
        SecondaryColorArray = 0x845E,
        TextureCubeMap = 0x8513,
        ProgramPointSize = 0x8642,
        VertexProgramPointSize = 0x8642,
        //VertexProgramTwoSide = ((int)0x8643),
        DepthClamp = 0x864F,
        TextureCubeMapSeamless = 0x884F,
        PointSprite = 0x8861,
        RasterizerDiscard = 0x8C89,
        FramebufferSrgb = 0x8DB9,
        SampleMask = 0x8E51,
        PrimitiveRestart = 0x8F9D
    }

    public enum ErrorCode
    {
        NoError = 0,
        InvalidEnum = 0x0500,
        InvalidValue = 0x0501,
        InvalidOperation = 0x0502,
        StackOverflow = 0x0503,
        StackUnderflow = 0x0504,
        OutOfMemory = 0x0505,
        InvalidFramebufferOperation = 0x0506,
        InvalidFramebufferOperationExt = 0x0506,
        TableTooLargeExt = 0x8031,
        TextureTooLargeExt = 0x8065
    }

    public enum FramebufferAttachment
    {
        DepthStencilAttachment = 0x821A,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment0Ext = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment1Ext = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment2Ext = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment3Ext = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment4Ext = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment5Ext = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment6Ext = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment7Ext = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment8Ext = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment9Ext = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment10Ext = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment11Ext = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment12Ext = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment13Ext = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment14Ext = 0x8CEE,
        ColorAttachment15 = 0x8CEF,
        ColorAttachment15Ext = 0x8CEF,
        DepthAttachment = 0x8D00,
        DepthAttachmentExt = 0x8D00,
        StencilAttachment = 0x8D20,
        StencilAttachmentExt = 0x8D20
    }

    public enum FramebufferErrorCode
    {
        FramebufferUndefined = 0x8219,
        FramebufferComplete = 0x8CD5,
        FramebufferCompleteExt = 0x8CD5,
        FramebufferIncompleteAttachment = 0x8CD6,
        FramebufferIncompleteAttachmentExt = 0x8CD6,
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        FramebufferIncompleteMissingAttachmentExt = 0x8CD7,
        FramebufferIncompleteDimensionsExt = 0x8CD9,
        FramebufferIncompleteFormatsExt = 0x8CDA,
        FramebufferIncompleteDrawBuffer = 0x8CDB,
        FramebufferIncompleteDrawBufferExt = 0x8CDB,
        FramebufferIncompleteReadBuffer = 0x8CDC,
        FramebufferIncompleteReadBufferExt = 0x8CDC,
        FramebufferUnsupported = 0x8CDD,
        FramebufferUnsupportedExt = 0x8CDD,
        FramebufferIncompleteMultisample = 0x8D56,
        FramebufferIncompleteLayerTargets = 0x8DA8,
        FramebufferIncompleteLayerCount = 0x8DA9
    }

    public enum FramebufferPName
    {
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314
    }

    public enum FramebufferParameterName
    {
        FramebufferAttachmentColorEncoding = 0x8210,
        FramebufferAttachmentComponentType = 0x8211,
        FramebufferAttachmentRedSize = 0x8212,
        FramebufferAttachmentGreenSize = 0x8213,
        FramebufferAttachmentBlueSize = 0x8214,
        FramebufferAttachmentAlphaSize = 0x8215,
        FramebufferAttachmentDepthSize = 0x8216,
        FramebufferAttachmentStencilSize = 0x8217,
        FramebufferAttachmentObjectType = 0x8CD0,
        FramebufferAttachmentObjectTypeExt = 0x8CD0,
        FramebufferAttachmentObjectName = 0x8CD1,
        FramebufferAttachmentObjectNameExt = 0x8CD1,
        FramebufferAttachmentTextureLevel = 0x8CD2,
        FramebufferAttachmentTextureLevelExt = 0x8CD2,
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        FramebufferAttachmentTextureCubeMapFaceExt = 0x8CD3,
        FramebufferAttachmentTexture3DZoffsetExt = 0x8CD4,
        FramebufferAttachmentTextureLayer = 0x8CD4,
        FramebufferAttachmentLayered = 0x8DA7
    }

    public enum FramebufferTarget
    {
        ReadFramebuffer = 0x8CA8,
        DrawFramebuffer = 0x8CA9,
        Framebuffer = 0x8D40,
        FramebufferExt = 0x8D40
    }

    public enum FrontFaceDirection
    {
        Cw = 0x0900,
        Ccw = 0x0901
    }

    public enum GenerateMipmapTarget
    {
        Texture1D = 0x0DE0,
        Texture2D = 0x0DE1,
        Texture3D = 0x806F,
        TextureCubeMap = 0x8513,
        Texture1DArray = 0x8C18,
        Texture2DArray = 0x8C1A,
        Texture2DMultisample = 0x9100,
        Texture2DMultisampleArray = 0x9102
    }

    public enum GetMultisamplePName
    {
        SamplePosition = 0x8E50
    }

    public enum GetPName
    {
        ActiveTexture = 0x84E0,
        AliasedLineWidthRange = 0x846E,
        ArrayBufferBinding = 0x8894,
        Blend = 0x0BE2,
        BlendColor = 0x8005,
        [Obsolete("Use BlendColor instead.")]
        BlendColorExt = 0x8005,
        BlendDstAlpha = 0x80CA,
        BlendDstRgb = 0x80C8,
        BlendEquationAlpha = 0x883D,
        BlendEquationRgb = 0x8009,
        BlendSrcAlpha = 0x80CB,
        BlendSrcRgb = 0x80C9,
        ColorClearValue = 0x0C22,
        ColorLogicOp = 0x0BF2,
        ColorWritemask = 0x0C23,
        CompressedTextureFormats = 0x86A3,
        MaxComputeShaderStorageBlocks = 0x90DB,
        MaxCombinedShaderStorageBlocks = 0x90DC,
        MaxComputeUniformBlocks = 0x91BB,
        MaxComputeTextureImageUnits = 0x91BC,
        MaxComputeUniformComponents = 0x8263,
        MaxComputeAtomicCounters = 0x8265,
        MaxComputeAtomicCounterBuffers = 0x8264,
        MaxCombinedComputeUniformComponents = 0x8266,
        MaxComputeWorkGroupInvocations = 0x90EB,
        MaxComputeWorkGroupCount = 0x91BE,
        MaxComputeWorkGroupSize = 0x91BF,
        DispatchIndirectBufferBinding = 0x90EF,
        MaxDebugGroupStackDepth = 0x826C,
        DebugGroupStackDepth = 0x826D,
        ContextFlags = 0x821E,
        CullFace = 0x0B44,
        CurrentProgram = 0x8B8D,
        DepthClearValue = 0x0B73,
        DepthFunc = 0x0B74,
        DepthRange = 0x0B70,
        DepthScale = 0x0D1E,
        DepthTest = 0x0B71,
        DepthWritemask = 0x0B72,
        Dither = 0x0BD0,
        Doublebuffer = 0x0C32,
        DrawBuffer = 0x0C01,
        DrawBuffer0 = 0x8825,
        DrawBuffer1 = 0x8826,
        DrawBuffer10 = 0x882F,
        DrawBuffer11 = 0x8830,
        DrawBuffer12 = 0x8831,
        DrawBuffer13 = 0x8832,
        DrawBuffer14 = 0x8833,
        DrawBuffer15 = 0x8834,
        DrawBuffer2 = 0x8827,
        DrawBuffer3 = 0x8828,
        DrawBuffer4 = 0x8829,
        DrawBuffer5 = 0x882A,
        DrawBuffer6 = 0x882B,
        DrawBuffer7 = 0x882C,
        DrawBuffer8 = 0x882D,
        DrawBuffer9 = 0x882E,
        DrawFramebufferBinding = 0x8CA6,
        ReadFramebufferBinding = 0x8CAA,
        ElementArrayBufferBinding = 0x8895,
        FragmentShaderDerivativeHint = 0x8B8B,
        ImplementationColorReadFormat = 0x8B9B,
        ImplementationColorReadType = 0x8B9A,
        LineSmooth = 0x0B20,
        LineSmoothHint = 0x0C52,
        LineWidth = 0x0B21,
        LayerProvokingVertex = 0x825E,
        LogicOpMode = 0x0BF0,
        MajorVersion = 0x821B,
        Max3DTextureSize = 0x8073,
        MaxArrayTextureLayers = 0x88FF,
        MaxClipDistances = 0x0D32,
        MaxColorTextureSamples = 0x910E,
        MaxCombinedAtomicCounters = 0x92D7,
        MaxCombinedFragmentUniformComponents = 0x8A33,
        MaxCombinedGeometryUniformComponents = 0x8A32,
        MaxCombinedTextureImageUnits = 0x8B4D,
        MaxCombinedUniformBlocks = 0x8A2E,
        MaxCombinedVertexUniformComponents = 0x8A31,
        MaxCubeMapTextureSize = 0x851C,
        MaxDepthTextureSamples = 0x910F,
        MaxDrawBuffers = 0x8824,
        MaxElementsIndices = 0x80E9,
        MaxElementsVertices = 0x80E8,
        MaxFragmentAtomicCounters = 0x92D6,
        MaxFragmentShaderStorageBlocks = 0x90DA,
        MaxFragmentInputComponents = 0x9125,
        MaxFragmentUniformComponents = 0x8B49,
        MaxFragmentUniformVectors = 0x8DFD,
        MaxFragmentUniformBlocks = 0x8A2D,
        MaxFramebufferWidth = 0x9315,
        MaxFramebufferHeight = 0x9316,
        MaxFramebufferLayers = 0x9317,
        MaxFramebufferSamples = 0x9318,
        MaxGeometryAtomicCounters = 0x92D5,
        MaxGeometryShaderStorageBlocks = 0x90D7,
        MaxGeometryInputComponents = 0x9123,
        MaxGeometryOutputComponents = 0x9124,
        MaxGeometryTextureImageUnits = 0x8C29,
        MaxGeometryUniformBlocks = 0x8A2C,
        MaxGeometryUniformComponents = 0x8DDF,
        MaxIntegerSamples = 0x9110,
        MinMapBufferAlignment = 0x90BC,
        MaxLabelLength = 0x82E8,
        MaxProgramTexelOffset = 0x8905,
        MinProgramTexelOffset = 0x8904,
        MaxRectangleTextureSize = 0x84F8,
        MaxRenderbufferSize = 0x84E8,
        MaxSampleMaskWords = 0x8E59,
        MaxServerWaitTimeout = 0x9111,
        MaxShaderStorageBufferBindings,
        MaxTessControlAtomicCounters,
        MaxTessEvaluationAtomicCounters,
        MaxTessControlShaderStorageBlocks,
        MaxTessEvaluationShaderStorageBlocks,
        MaxTextureBufferSize = 0x8C2B,
        MaxTextureImageUnits = 0x8872,
        MaxTextureLodBias = 0x84FD,
        MaxTextureSize = 0x0D33,
        MaxUniformBlockSize = 0x8A30,
        MaxUniformBufferBindings = 0x8A2F,
        MaxUniformLocations = 0x826E,
        MaxVaryingComponents = 0x8B4B,
        MaxVaryingVectors = 0x8DFC,
        MaxVaryingFloats = 0x8B4B,
        MaxVertexAtomicCounters = 0x92D2,
        MaxVertexAttribs = 0x8869,
        MaxVertexShaderStorageBlocks = 0x90D6,
        MaxVertexTextureImageUnits = 0x8B4C,
        MaxVertexUniformComponents = 0x8B4A,
        MaxVertexUniformVectors = 0x8DFB,
        MaxVertexOutputComponents = 0x9122,
        MaxVertexUniformBlocks = 0x8A2B,
        MaxViewportDims = 0x0D3A,
        MaxViewports = 0x825B,
        MinorVersion = 0x821C,
        NumCompressedTextureFormats = 0x86A2,
        NumExtensions = 0x821D,
        NumProgramBinaryFormats = 0x87FE,
        NumShaderBinaryFormats = 0x8DF9,
        PackAlignment = 0x0D05,
        PackImageHeight = 0x806C,
        [Obsolete("Use PackImageHeight instead.")]
        PackImageHeightExt = 0x806C,
        PackLsbFirst = 0x0D01,
        PackRowLength = 0x0D02,
        PackSkipImages = 0x806B,
        [Obsolete("Use PackSkipImages instead.")]
        PackSkipImagesExt = 0x806B,
        PackSkipPixels = 0x0D04,
        PackSkipRows = 0x0D03,
        PackSwapBytes = 0x0D00,
        PixelPackBufferBinding = 0x88ED,
        PixelUnpackBufferBinding = 0x88EF,
        PointFadeThresholdSize = 0x8128,
        PrimitiveRestartIndex = 0x8F9E,
        ProgramBinaryFormats = 0x87FF,
        ProgramPipelineBinding = 0x825A,
        ProgramPointSize = 0x8642,
        ProvokingVertex = 0x8E4F,
        PointSize = 0x0B11,
        PointSizeGranularity = 0x0B13,
        PointSizeRange = 0x0B12,
        PolygonOffsetFactor = 0x8038,
        PolygonOffsetFill = 0x8037,
        PolygonOffsetLine = 0x2A02,
        PolygonOffsetPoint = 0x2A01,
        PolygonOffsetUnits = 0x2A00,
        PolygonSmooth = 0x0B41,
        PolygonSmoothHint = 0x0C53,
        ReadBuffer = 0x0C02,
        RenderbufferBinding = 0x8CA7,
        SampleBuffers = 0x80A8,
        SampleCoverageInvert = 0x80AB,
        SampleCoverageValue = 0x80AA,
        SamplerBinding = 0x8919,
        Samples = 0x80A9,
        ScissorBox = 0x0C10,
        ScissorTest = 0x0C11,
        ShaderCompiler = 0x8DFA,
        ShaderStorageBufferBinding = 0x90D3,
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        ShaderStorageBufferStart = 0x90D4,
        ShaderStorageBufferSize = 0x90D5,
        SmoothLineWidthGranularity = 0x0B23,
        SmoothLineWidthRange = 0x0B22,
        SmoothPointSizeGranularity = 0x0B13,
        SmoothPointSizeRange = 0x0B12,
        StencilBackFail = 0x8801,
        StencilBackPassDepthFail = 0x8802,
        StencilBackPassDepthPass = 0x8803,
        StencilBackRef = 0x8CA3,
        StencilBackValueMask = 0x8CA4,
        StencilBackWritemask = 0x8CA5,
        StencilClearValue = 0x0B91,
        StencilFail = 0x0B94,
        StencilFunc = 0x0B92,
        StencilPassDepthFail = 0x0B95,
        StencilPassDepthPass = 0x0B96,
        StencilRef = 0x0B97,
        StencilTest = 0x0B90,
        StencilValueMask = 0x0B93,
        StencilWritemask = 0x0B98,
        Stereo = 0x0C33,
        SubpixelBits = 0x0D50,
        TextureBinding1D = 0x8068,
        TextureBinding1DArray = 0x8C1C,
        TextureBinding2D = 0x8069,
        TextureBinding2DArray = 0x8C1D,
        TextureBinding2DMultisample = 0x9104,
        TextureBinding2DMultisampleArray = 0x9105,
        TextureBinding3D = 0x806A,
        TextureBindingBuffer = 0x8C2C,
        TextureBindingCubeMap = 0x8514,
        TextureBindingRectangle = 0x84F6,
        TextureCompressionHint = 0x84EF,
        TextureBufferOffsetAlignment = 0x919F,
        Timestamp = 0x8E28,
        TransformFeedbackBufferBinding = 0x8C8F,
        TransformFeedbackBufferStart = 0x8C84,
        TransformFeedbackBufferSize = 0x8C85,
        UniformBufferBinding = 0x8A28,
        UniformBufferOffsetAlignment = 0x8A34,
        UniformBufferStart = 0x8A29,
        UniformBufferSize = 0x8A2A,
        UnpackAlignment = 0x0CF5,
        UnpackImageHeight = 0x806E,
        [Obsolete("Use UnpackImageHeight instead.")]
        UnpackImageHeightExt = 0x806E,
        UnpackLsbFirst = 0x0CF1,
        UnpackRowLength = 0x0CF2,
        UnpackSkipImages = 0x806D,
        [Obsolete("Use UnpackSkipImages instead.")]
        UnpackSkipImagesExt = 0x806D,
        UnpackSkipPixels = 0x0CF4,
        UnpackSkipRows = 0x0CF3,
        UnpackSwapBytes = 0x0CF0,
        VertexArrayBinding = 0x85B5,
        VertexBindingDivisor = 0x82D6,
        VertexBindingOffset = 0x82D7,
        VertexBindingStride = 0x82D8,
        MaxVertexAttribRelativeOffset = 0x82D9,
        MaxVertexAttribBindings = 0x82DA,
        Viewport = 0x0BA2,
        ViewportBoundsRange = 0x825D,
        ViewportIndexProvokingVertex = 0x825F,
        ViewportSubpixelBits = 0x825C,
        MaxElementIndex = 0x8D6B
    }

    public enum GetPointerParameter
    {
        DebugCallbackFunction = 0x8244,
        DebugCallbackUserParam = 0x8245
    }

    public enum GetQueryObjectParam
    {
        QueryResult = 0x8866,
        QueryResultAvailable = 0x8867
    }

    public enum GetQueryParam
    {
        QueryCounterBits = 0x8864,
        CurrentQuery = 0x8865
    }

    public enum GetTextureParameter
    {
        TextureWidth = 0x1000,
        TextureHeight = 0x1001,
        TextureComponents = 0x1003,
        TextureInternalFormat = 0x1003,
        TextureBorderColor = 0x1004,
        TextureBorder = 0x1005,
        TextureMagFilter = 0x2800,
        TextureMinFilter = 0x2801,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureRedSize = 0x805C,
        TextureGreenSize = 0x805D,
        TextureBlueSize = 0x805E,
        TextureAlphaSize = 0x805F,
        TextureLuminanceSize = 0x8060,
        TextureIntensitySize = 0x8061,
        TexturePriority = 0x8066,
        TextureResident = 0x8067,
        TextureDepth = 0x8071,
        TextureDepthExt = 0x8071,
        TextureWrapR = 0x8072,
        TextureWrapRExt = 0x8072,
        DetailTextureLevelSgis = 0x809A,
        DetailTextureModeSgis = 0x809B,
        DetailTextureFuncPointsSgis = 0x809C,
        SharpenTextureFuncPointsSgis = 0x80B0,
        ShadowAmbientSgix = 0x80BF,
        DualTextureSelectSgis = 0x8124,
        QuadTextureSelectSgis = 0x8125,
        Texture4DsizeSgis = 0x8136,
        TextureWrapQSgis = 0x8137,
        TextureMinLod = 0x813A,
        TextureMinLodSgis = 0x813A,
        TextureMaxLod = 0x813B,
        TextureMaxLodSgis = 0x813B,
        TextureBaseLevel = 0x813C,
        TextureBaseLevelSgis = 0x813C,
        TextureMaxLevel = 0x813D,
        TextureMaxLevelSgis = 0x813D,
        TextureFilter4SizeSgis = 0x8147,
        TextureClipmapCenterSgix = 0x8171,
        TextureClipmapFrameSgix = 0x8172,
        TextureClipmapOffsetSgix = 0x8173,
        TextureClipmapVirtualDepthSgix = 0x8174,
        TextureClipmapLodOffsetSgix = 0x8175,
        TextureClipmapDepthSgix = 0x8176,
        PostTextureFilterBiasSgix = 0x8179,
        PostTextureFilterScaleSgix = 0x817A,
        TextureLodBiasSSgix = 0x818E,
        TextureLodBiasTSgix = 0x818F,
        TextureLodBiasRSgix = 0x8190,
        GenerateMipmap = 0x8191,
        GenerateMipmapSgis = 0x8191,
        TextureCompareSgix = 0x819A,
        TextureCompareOperatorSgix = 0x819B,
        TextureLequalRSgix = 0x819C,
        TextureGequalRSgix = 0x819D,
        TextureMaxClampSSgix = 0x8369,
        TextureMaxClampTSgix = 0x836A,
        TextureMaxClampRSgix = 0x836B,
        TextureCompressedImageSize = 0x86A0,
        TextureCompressed = 0x86A1,
        TextureDepthSize = 0x884A,
        DepthTextureMode = 0x884B,
        TextureCompareMode = 0x884C,
        TextureCompareFunc = 0x884D,
        TextureStencilSize = 0x88F1,
        TextureRedType = 0x8C10,
        TextureGreenType = 0x8C11,
        TextureBlueType = 0x8C12,
        TextureAlphaType = 0x8C13,
        TextureLuminanceType = 0x8C14,
        TextureIntensityType = 0x8C15,
        TextureDepthType = 0x8C16,
        TextureSharedSize = 0x8C3F,
        TextureSamples = 0x9106,
        TextureFixedSampleLocations = 0x9107,
        TextureBufferOffset = 0x919D
    }

    public enum GetTextureLevelParameter
    {
        TextureWidth = 0x1000,
        TextureHeight = 0x1001,
        TextureDepth = 0x8071,
        TextureInternalFormat = 0x1003,
        TextureRedSize = 0x805C,
        TextureGreenSize = 0x805D,
        TextureBlueSize = 0x805E,
        TextureAlphaSize = 0x805F,
        TextureDepthSize = 0x884A,
        TextureCompressed = 0x86A1,
        TextureCompressedImageSize = 0x86A0,
        TextureBufferOffset = 0x919D
    }

    public enum GraphicResetStatus
    {
        NoError = 0,
        GuiltyContextReset = 0x8253,
        InnocentContextReset = 0x8254,
        UnknownContextReset = 0x8255
    }

    public enum HintMode
    {
        DontCare = 0x1100,
        Fastest = 0x1101,
        Nicest = 0x1102
    }

    public enum HintTarget
    {
        PerspectiveCorrectionHint = 0x0C50,
        PointSmoothHint = 0x0C51,
        LineSmoothHint = 0x0C52,
        PolygonSmoothHint = 0x0C53,
        FogHint = 0x0C54,
        PackCmykHintExt = 0x800E,
        UnpackCmykHintExt = 0x800F,
        TextureMultiBufferHintSgix = 0x812E,
        GenerateMipmapHint = 0x8192,
        GenerateMipmapHintSgis = 0x8192,
        ConvolutionHintSgix = 0x8316,
        VertexPreclipHintSgix = 0x83EF,
        TextureCompressionHint = 0x84EF,
        FragmentShaderDerivativeHint = 0x8B8B
    }

    public enum LogicOp
    {
        Clear = 0x1500,
        And = 0x1501,
        AndReverse = 0x1502,
        Copy = 0x1503,
        AndInverted = 0x1504,
        Noop = 0x1505,
        Xor = 0x1506,
        Or = 0x1507,
        Nor = 0x1508,
        Equiv = 0x1509,
        Invert = 0x150A,
        OrReverse = 0x150B,
        CopyInverted = 0x150C,
        OrInverted = 0x150D,
        Nand = 0x150E,
        Set = 0x150F
    }

    public enum MaterialFace
    {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408
    }

    public enum NvTransformFeedback2
    {
        TransformFeedbackNv = 0x8E22,
        TransformFeedbackBufferPausedNv = 0x8E23,
        TransformFeedbackBufferActiveNv = 0x8E24,
        TransformFeedbackBindingNv = 0x8E25
    }

    public enum ObjectLabel
    {
        Buffer = 0x82E0,
        Shader = 0x82E1,
        Program = 0x82E2,
        VertexArray = 0x8074,
        Query = 0x82E3,
        ProgramPipeline = 0x82E4,
        TransformFeedback = 0x8E22,
        Sampler = 0x82E6,
        Texture = 0x1702,
        RenderBuffer = 0x8D41,
        FrameBuffer = 0x8D40
    }

    public enum PixelFormat
    {
        ColorIndex = 0x1900,
        StencilIndex = 0x1901,
        DepthComponent = 0x1902,
        Red = 0x1903,
        Green = 0x1904,
        Blue = 0x1905,
        Alpha = 0x1906,
        Rgb = 0x1907,
        Rgba = 0x1908,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        AbgrExt = 0x8000,
        CmykExt = 0x800C,
        CmykaExt = 0x800D,
        Bgr = 0x80E0,
        Bgra = 0x80E1,
        Ycrcb422Sgix = 0x81BB,
        Ycrcb444Sgix = 0x81BC,
        Rg = 0x8227,
        RgInteger = 0x8228,
        DepthStencil = 0x84F9,
        RedInteger = 0x8D94,
        GreenInteger = 0x8D95,
        BlueInteger = 0x8D96,
        AlphaInteger = 0x8D97,
        RgbInteger = 0x8D98,
        RgbaInteger = 0x8D99,
        BgrInteger = 0x8D9A,
        BgraInteger = 0x8D9B
    }

    public enum PixelInternalFormat
    {
        DepthComponent = 0x1902,
        Alpha = 0x1906,
        Rgb = 0x1907,
        Rgba = 0x1908,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        R3G3B2 = 0x2A10,
        Alpha4 = 0x803B,
        Alpha8 = 0x803C,
        Alpha12 = 0x803D,
        Alpha16 = 0x803E,
        Luminance4 = 0x803F,
        Luminance8 = 0x8040,
        Luminance12 = 0x8041,
        Luminance16 = 0x8042,
        Luminance4Alpha4 = 0x8043,
        Luminance6Alpha2 = 0x8044,
        Luminance8Alpha8 = 0x8045,
        Luminance12Alpha4 = 0x8046,
        Luminance12Alpha12 = 0x8047,
        Luminance16Alpha16 = 0x8048,
        Intensity = 0x8049,
        Intensity4 = 0x804A,
        Intensity8 = 0x804B,
        Intensity12 = 0x804C,
        Intensity16 = 0x804D,
        Rgb2Ext = 0x804E,
        Rgb4 = 0x804F,
        Rgb5 = 0x8050,
        Rgb8 = 0x8051,
        Rgb10 = 0x8052,
        Rgb12 = 0x8053,
        Rgb16 = 0x8054,
        Rgba2 = 0x8055,
        Rgba4 = 0x8056,
        Rgb5A1 = 0x8057,
        Rgba8 = 0x8058,
        Rgb10A2 = 0x8059,
        Rgba12 = 0x805A,
        Rgba16 = 0x805B,
        DualAlpha4Sgis = 0x8110,
        DualAlpha8Sgis = 0x8111,
        DualAlpha12Sgis = 0x8112,
        DualAlpha16Sgis = 0x8113,
        DualLuminance4Sgis = 0x8114,
        DualLuminance8Sgis = 0x8115,
        DualLuminance12Sgis = 0x8116,
        DualLuminance16Sgis = 0x8117,
        DualIntensity4Sgis = 0x8118,
        DualIntensity8Sgis = 0x8119,
        DualIntensity12Sgis = 0x811A,
        DualIntensity16Sgis = 0x811B,
        DualLuminanceAlpha4Sgis = 0x811C,
        DualLuminanceAlpha8Sgis = 0x811D,
        QuadAlpha4Sgis = 0x811E,
        QuadAlpha8Sgis = 0x811F,
        QuadLuminance4Sgis = 0x8120,
        QuadLuminance8Sgis = 0x8121,
        QuadIntensity4Sgis = 0x8122,
        QuadIntensity8Sgis = 0x8123,
        DepthComponent16 = 0x81a5,
        DepthComponent16Sgix = 0x81A5,
        DepthComponent24 = 0x81a6,
        DepthComponent24Sgix = 0x81A6,
        DepthComponent32 = 0x81a7,
        DepthComponent32Sgix = 0x81A7,
        CompressedRed = 0x8225,
        CompressedRg = 0x8226,
        R8 = 0x8229,
        R16 = 0x822A,
        Rg8 = 0x822B,
        Rg16 = 0x822C,
        R16f = 0x822D,
        R32f = 0x822E,
        Rg16f = 0x822F,
        Rg32f = 0x8230,
        R8i = 0x8231,
        R8ui = 0x8232,
        R16i = 0x8233,
        R16ui = 0x8234,
        R32i = 0x8235,
        R32ui = 0x8236,
        Rg8i = 0x8237,
        Rg8ui = 0x8238,
        Rg16i = 0x8239,
        Rg16ui = 0x823A,
        Rg32i = 0x823B,
        Rg32ui = 0x823C,
        CompressedRgbS3tcDxt1Ext = 0x83F0,
        CompressedRgbaS3tcDxt1Ext = 0x83F1,
        CompressedRgbaS3tcDxt3Ext = 0x83F2,
        CompressedRgbaS3tcDxt5Ext = 0x83F3,
        CompressedAlpha = 0x84E9,
        CompressedLuminance = 0x84EA,
        CompressedLuminanceAlpha = 0x84EB,
        CompressedIntensity = 0x84EC,
        CompressedRgb = 0x84ED,
        CompressedRgba = 0x84EE,
        DepthStencil = 0x84F9,
        Rgba32f = 0x8814,
        Rgb32f = 0x8815,
        Rgba16f = 0x881A,
        Rgb16f = 0x881B,
        Depth24Stencil8 = 0x88F0,
        R11fG11fB10f = 0x8C3A,
        Rgb9E5 = 0x8C3D,
        Srgb = 0x8C40,
        Srgb8 = 0x8C41,
        SrgbAlpha = 0x8C42,
        Srgb8Alpha8 = 0x8C43,
        SluminanceAlpha = 0x8C44,
        Sluminance8Alpha8 = 0x8C45,
        Sluminance = 0x8C46,
        Sluminance8 = 0x8C47,
        CompressedSrgb = 0x8C48,
        CompressedSrgbAlpha = 0x8C49,
        CompressedSluminance = 0x8C4A,
        CompressedSluminanceAlpha = 0x8C4B,
        CompressedSrgbS3tcDxt1Ext = 0x8C4C,
        CompressedSrgbAlphaS3tcDxt1Ext = 0x8C4D,
        CompressedSrgbAlphaS3tcDxt3Ext = 0x8C4E,
        CompressedSrgbAlphaS3tcDxt5Ext = 0x8C4F,
        DepthComponent32f = 0x8CAC,
        Depth32fStencil8 = 0x8CAD,
        Rgba32ui = 0x8D70,
        Rgb32ui = 0x8D71,
        Rgba16ui = 0x8D76,
        Rgb16ui = 0x8D77,
        Rgba8ui = 0x8D7C,
        Rgb8ui = 0x8D7D,
        Rgba32i = 0x8D82,
        Rgb32i = 0x8D83,
        Rgba16i = 0x8D88,
        Rgb16i = 0x8D89,
        Rgba8i = 0x8D8E,
        Rgb8i = 0x8D8F,
        Float32UnsignedInt248Rev = 0x8DAD,
        CompressedRedRgtc1 = 0x8DBB,
        CompressedSignedRedRgtc1 = 0x8DBC,
        CompressedRgRgtc2 = 0x8DBD,
        CompressedSignedRgRgtc2 = 0x8DBE,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4
    }

    public enum PixelStoreParameter
    {
        UnpackSwapBytes = 0x0CF0,
        UnpackLsbFirst = 0x0CF1,
        UnpackRowLength = 0x0CF2,
        UnpackSkipRows = 0x0CF3,
        UnpackSkipPixels = 0x0CF4,
        UnpackAlignment = 0x0CF5,
        PackSwapBytes = 0x0D00,
        PackLsbFirst = 0x0D01,
        PackRowLength = 0x0D02,
        PackSkipRows = 0x0D03,
        PackSkipPixels = 0x0D04,
        PackAlignment = 0x0D05,
        PackSkipImages = 0x806B,
        PackSkipImagesExt = 0x806B,
        PackImageHeight = 0x806C,
        PackImageHeightExt = 0x806C,
        UnpackSkipImages = 0x806D,
        UnpackSkipImagesExt = 0x806D,
        UnpackImageHeight = 0x806E,
        UnpackImageHeightExt = 0x806E,
        PackSkipVolumesSgis = 0x8130,
        PackImageDepthSgis = 0x8131,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackImageDepthSgis = 0x8133,
        PixelTileWidthSgix = 0x8140,
        PixelTileHeightSgix = 0x8141,
        PixelTileGridWidthSgix = 0x8142,
        PixelTileGridHeightSgix = 0x8143,
        PixelTileGridDepthSgix = 0x8144,
        PixelTileCacheSizeSgix = 0x8145,
        PackResampleSgix = 0x842C,
        UnpackResampleSgix = 0x842D,
        PackSubsampleRateSgix = 0x85A0,
        UnpackSubsampleRateSgix = 0x85A1
    }

    public enum PixelType
    {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Int = 0x1404,
        UnsignedInt = 0x1405,
        Float = 0x1406,
        HalfFloat = 0x140B,
        Bitmap = 0x1A00,
        UnsignedByte332 = 0x8032,
        UnsignedByte332Ext = 0x8032,
        UnsignedShort4444 = 0x8033,
        UnsignedShort4444Ext = 0x8033,
        UnsignedShort5551 = 0x8034,
        UnsignedShort5551Ext = 0x8034,
        UnsignedInt8888 = 0x8035,
        UnsignedInt8888Ext = 0x8035,
        UnsignedInt1010102 = 0x8036,
        UnsignedInt1010102Ext = 0x8036,
        UnsignedByte233Reversed = 0x8362,
        UnsignedShort565 = 0x8363,
        UnsignedShort565Reversed = 0x8364,
        UnsignedShort4444Reversed = 0x8365,
        UnsignedShort1555Reversed = 0x8366,
        UnsignedInt8888Reversed = 0x8367,
        UnsignedInt2101010Reversed = 0x8368,
        UnsignedInt248 = 0x84FA,
        UnsignedInt10F11F11FRev = 0x8C3B,
        UnsignedInt5999Rev = 0x8C3E,
        Float32UnsignedInt248Rev = 0x8DAD
    }

    public enum PointParameterName
    {
        PointSizeMin = 0x8126,
        PointSizeMax = 0x8127,
        PointFadeThresholdSize = 0x8128,
        PointDistanceAttenuation = 0x8129,
        PointSpriteCoordOrigin = 0x8CA0
    }

    public enum PolygonMode
    {
        Point = 0x1B00,
        Line = 0x1B01,
        Fill = 0x1B02
    }

    public enum ProgramInterface
    {
        Uniform = 0x92E1,
        UniformBlock = 0x92E2,
        AtomicCounterBuffer = 0x92C0,
        ProgramInput = 0x92E3,
        ProgramOutput = 0x92E4,
        VertexSubroutine = 0x92E8,
        TessControlSubroutine = 0x92E9,
        TessEvaluationSubroutine = 0x92EA,
        GeometrySubroutine = 0x92EB,
        FragmentSubroutine = 0x92EC,
        ComputeSubroutine = 0x92ED,
        VertexSubroutineUniform = 0x92EE,
        TessControlSubroutineUniform = 0x92EF,
        TessEvaluationSubroutineUniform = 0x92F0,
        GeometrySubroutineUniform = 0x92F1,
        FragmentSubroutineUniform = 0x92F2,
        ComputeSubroutineUniform = 0x92F3,
        TransformFeedbackVarying = 0x92F4,
        BufferVariable = 0x92E5,
        ShaderStorageBlock = 0x92E6,
        TransformFeedbackBuffer = 0x8C8E
    }

    public enum ProgramInterfaceParameterName
    {
        ActiveResources = 0x92F5,
        MaxNameLength = 0x92F6,
        MaxNumActiveVariables = 0x92F7,
        MaxNumCompatibleSubroutines = 0x92F8
    }

    public enum ProgramParameter
    {
        ActiveUniformBlockMaxNameLength = 0x8A35,
        ActiveUniformBlocks = 0x8A36,
        DeleteStatus = 0x8B80,
        LinkStatus = 0x8B82,
        ValidateStatus = 0x8B83,
        InfoLogLength = 0x8B84,
        AttachedShaders = 0x8B85,
        ActiveUniforms = 0x8B86,
        ActiveUniformMaxLength = 0x8B87,
        ActiveAttributes = 0x8B89,
        ActiveAttributeMaxLength = 0x8B8A,
        TransformFeedbackVaryingMaxLength = 0x8C76,
        TransformFeedbackBufferMode = 0x8C7F,
        TransformFeedbackVaryings = 0x8C83,
        GeometryVerticesOut = 0x8DDA,
        GeometryInputType = 0x8DDB,
        GeometryOutputType = 0x8DDC
    }

    public enum ProgramResourceParameterName
    {
        NameLength = 0x92F9,
        Type = 0x92FA,
        ArraySize = 0x92FB,
        Offset = 0x92FC,
        BlockIndex = 0x92FD,
        ArrayStride = 0x92FE,
        MatrixStride = 0x92FF,
        IsRowMajor = 0x9300,
        AtomicCounterBufferIndex = 0x9301,
        TextureBuffer = 0x8C2A,
        BufferBinding = 0x9302,
        BufferDataSize = 0x9303,
        NumActiveVariables = 0x9304,
        ActiveVariables = 0x9305,
        ReferencedByVertexShader = 0x9306,
        ReferencedByTessControlShader = 0x9307,
        ReferencedByTessEvaluationShader = 0x9308,
        ReferencedByGeometryShader = 0x9309,
        ReferencedByFragmentShader = 0x930A,
        ReferencedByComputeShader = 0x930B,
        NumCompatibleSubroutines = 0x8E4A,
        CompatibleSubroutines = 0x8E4B,
        TopLevelArraySize = 0x930C,
        TopLevelArrayStride = 0x930D,
        Location = 0x930E,
        LocationIndex = 0x930F,
        IsPerPatch = 0x92E7,
        LocationComponent = 0x934A,
        TransformFeedbackBufferIndex = 0x934B,
        TransformFeedbackBufferStride = 0x934C
    }

    public enum ProgramStageParameterName
    {
        ActiveSubroutineUniforms = 0x8DE6,
        ActiveSubroutineUniformLocations = 0x8E47,
        ActiveSubroutines = 0x8DE5,
        ActiveSubroutineUniformMaxLength = 0x8E49,
        ActiveSubroutineMaxLength = 0x8E48
    }

    public enum ProvokingVertexMode
    {
        FirstVertexConvention = 0x8E4D,
        LastVertexConvention = 0x8E4E
    }

    public enum QueryTarget
    {
        SamplesPassed = 0x8914,
        PrimitivesGenerated = 0x8C87,
        TransformFeedbackPrimitivesWritten = 0x8C88,
        AnySamplesPassed = 0x8C2F,
        AnySamplesPassedConservative = 0x8D6A,
        TimeElapsed = 0x88BF,
        TimeStamp = 0x8E28
    }

    public enum ReadBufferMode
    {
        None = 0x0000,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        Back = 0x0405,
        Left = 0x0406,
        Right = 0x0407,
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment15 = 0x8CEF
    }

    public enum RenderbufferParameterName
    {
        RenderbufferSamples = 0x8CAB,
        RenderbufferWidth = 0x8D42,
        RenderbufferWidthExt = 0x8D42,
        RenderbufferHeight = 0x8D43,
        RenderbufferHeightExt = 0x8D43,
        RenderbufferInternalFormat = 0x8D44,
        RenderbufferInternalFormatExt = 0x8D44,
        RenderbufferRedSize = 0x8D50,
        RenderbufferRedSizeExt = 0x8D50,
        RenderbufferGreenSize = 0x8D51,
        RenderbufferGreenSizeExt = 0x8D51,
        RenderbufferBlueSize = 0x8D52,
        RenderbufferBlueSizeExt = 0x8D52,
        RenderbufferAlphaSize = 0x8D53,
        RenderbufferAlphaSizeExt = 0x8D53,
        RenderbufferDepthSize = 0x8D54,
        RenderbufferDepthSizeExt = 0x8D54,
        RenderbufferStencilSize = 0x8D55,
        RenderbufferStencilSizeExt = 0x8D55
    }

    public enum RenderbufferStorage
    {
        R3G3B2 = 0x2A10,
        Alpha4 = 0x803B,
        Alpha8 = 0x803C,
        Alpha12 = 0x803D,
        Alpha16 = 0x803E,
        Rgb4 = 0x804F,
        Rgb5 = 0x8050,
        Rgb8 = 0x8051,
        Rgb10 = 0x8052,
        Rgb12 = 0x8053,
        Rgb16 = 0x8054,
        Rgba2 = 0x8055,
        Rgba4 = 0x8056,
        Rgba8 = 0x8058,
        Rgb10A2 = 0x8059,
        Rgba12 = 0x805A,
        Rgba16 = 0x805B,
        DepthComponent16 = 0x81a5,
        DepthComponent24 = 0x81a6,
        DepthComponent32 = 0x81a7,
        R8 = 0x8229,
        R16 = 0x822A,
        Rg8 = 0x822B,
        Rg16 = 0x822C,
        R16f = 0x822D,
        R32f = 0x822E,
        Rg16f = 0x822F,
        Rg32f = 0x8230,
        R8i = 0x8231,
        R8ui = 0x8232,
        R16i = 0x8233,
        R16ui = 0x8234,
        R32i = 0x8235,
        R32ui = 0x8236,
        Rg8i = 0x8237,
        Rg8ui = 0x8238,
        Rg16i = 0x8239,
        Rg16ui = 0x823A,
        Rg32i = 0x823B,
        Rg32ui = 0x823C,
        Rgba32f = 0x8814,
        Rgb32f = 0x8815,
        Rgba16f = 0x881A,
        Rgb16f = 0x881B,
        Depth24Stencil8 = 0x88F0,
        R11fG11fB10f = 0x8C3A,
        Rgb9E5 = 0x8C3D,
        Srgb8 = 0x8C41,
        Srgb8Alpha8 = 0x8C43,
        DepthComponent32f = 0x8CAC,
        Depth32fStencil8 = 0x8CAD,
        StencilIndex1 = 0x8D46,
        StencilIndex1Ext = 0x8D46,
        StencilIndex4 = 0x8D47,
        StencilIndex4Ext = 0x8D47,
        StencilIndex8 = 0x8D48,
        StencilIndex8Ext = 0x8D48,
        StencilIndex16 = 0x8D49,
        StencilIndex16Ext = 0x8D49,
        Rgba32ui = 0x8D70,
        Rgb32ui = 0x8D71,
        Rgba16ui = 0x8D76,
        Rgb16ui = 0x8D77,
        Rgba8ui = 0x8D7C,
        Rgb8ui = 0x8D7D,
        Rgba32i = 0x8D82,
        Rgb32i = 0x8D83,
        Rgba16i = 0x8D88,
        Rgb16i = 0x8D89,
        Rgba8i = 0x8D8E,
        Rgb8i = 0x8D8F
    }

    public enum RenderbufferTarget
    {
        Renderbuffer = 0x8D41,
        RenderbufferExt = 0x8D41
    }

    public enum ShaderParameter
    {
        ShaderType = 0x8B4F,
        DeleteStatus = 0x8B80,
        CompileStatus = 0x8B81,
        InfoLogLength = 0x8B84,
        ShaderSourceLength = 0x8B88
    }

    public enum ShaderType
    {
        FragmentShader = 0x8B30,
        VertexShader = 0x8B31,
        GeometryShader = 0x8DD9,
        TessControlShader = 0x8E88,
        TessEvaluationShader = 0x8E87,
        ComputeShader = 0x91B9
    }

    public enum SizedInternalFormat
    {
        Rgba8 = 0x8058,
        Rgba16 = 0x805B,
        R8 = 0x8229,
        R16 = 0x822A,
        Rg8 = 0x822B,
        Rg16 = 0x822C,
        R16f = 0x822D,
        R32f = 0x822E,
        Rg16f = 0x822F,
        Rg32f = 0x8230,
        R8i = 0x8231,
        R8ui = 0x8232,
        R16i = 0x8233,
        R16ui = 0x8234,
        R32i = 0x8235,
        R32ui = 0x8236,
        Rg8i = 0x8237,
        Rg8ui = 0x8238,
        Rg16i = 0x8239,
        Rg16ui = 0x823A,
        Rg32i = 0x823B,
        Rg32ui = 0x823C,
        Rgba32f = 0x8814,
        Rgba16f = 0x881A,
        Rgba32ui = 0x8D70,
        Rgba16ui = 0x8D76,
        Rgba8ui = 0x8D7C,
        Rgba32i = 0x8D82,
        Rgba16i = 0x8D88,
        Rgba8i = 0x8D8E
    }

    public enum StencilFace
    {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408
    }

    public enum StencilFunction
    {
        Never = 0x0200,
        Less = 0x0201,
        Equal = 0x0202,
        Lequal = 0x0203,
        Greater = 0x0204,
        Notequal = 0x0205,
        Gequal = 0x0206,
        Always = 0x0207
    }

    public enum StencilOp
    {
        Zero = 0,
        Invert = 0x150A,
        Keep = 0x1E00,
        Replace = 0x1E01,
        Incr = 0x1E02,
        Decr = 0x1E03,
        IncrWrap = 0x8507,
        DecrWrap = 0x8508
    }

    public enum StringName
    {
        Vendor = 0x1F00,
        Renderer = 0x1F01,
        Version = 0x1F02,
        Extensions = 0x1F03,
        ShadingLanguageVersion = 0x8B8C
    }

    public enum SubroutineParameterName
    {
        NumCompatibleSubroutines = 0x8E4A,
        CompatibleSubroutines = 0x8E4B,
        UniformSize = 0x8A38,
        UniformNameLength = 0x8A39
    }

    public enum TextureBufferTarget
    {
        TextureBuffer = 0x8C2A
    }

    public enum TextureParameter
    {
        Nearest = 0x2600,
        Linear = 0x2601,
        NearestMipMapNearest = 0x2700,
        LinearMipMapNearest = 0x2701,
        NearestMipMapLinear = 0x2702,
        LinearMipMapLinear = 0x2703,
        ClampToEdge = 0x812F,
        ClampToBorder = 0x812D,
        MirrorClampToEdge = 0x8743,
        MirroredRepeat = 0x8370,
        Repeat = 0x2901,
        Red = 0x1903,
        Green = 0x1904,
        Blue = 0x1905,
        Alpha = 0x1906,
        Zero = 0,
        One = 1,
        CompareRefToTexture = 0x884E,
        None = 0,
        StencilIndex = 0x1901,
        DepthComponent = 0x1902
    }

    public enum TextureParameterName
    {
        TextureBaseLevel = 0x813C,
        TextureBorderColor = 0x1004,
        TextureCompareMode = 0x884C,
        TextureCompareFunc = 0x884D,
        TextureLodBias = 0x8501,
        TextureMagFilter = 0x2800,
        TextureMaxLevel = 0x813D,
        TextureMaxLod = 0x813B,
        TextureMinFilter = 0x2801,
        TextureMinLod = 0x813A,
        TextureSwizzleR = 0x8E42,
        TextureSwizzleG = 0x8E43,
        TextureSwizzleB = 0x8E44,
        TextureSwizzleA = 0x8E45,
        TextureSwizzleRGBA = 0x8E46,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureWrapR = 0x8072
    }

    public enum TextureTarget
    {
        Texture1D = 0x0DE0,
        Texture2D = 0x0DE1,
        Texture3D = 0x806F,
        Texture1DArray = 0x8C18,
        Texture2DArray = 0x8C1A,
        TextureRectangle = 0x84F5,
        TextureCubeMap = 0x8513,
        TextureCubeMapArray = 0x9009,
        Texture2DMultisample = 0x9100,
        Texture2DMultisampleArray = 0x9102
    }

    public enum TextureTargetMultisample
    {
        Texture2DMultisample = 0x9100,
        ProxyTexture2DMultisample = 0x9101,
        Texture2DMultisampleArray = 0x9102,
        ProxyTexture2DMultisampleArray = 0x9103
    }

    public enum TextureUnit
    {
        Texture0 = 0x84C0,
        Texture1 = 0x84C1,
        Texture2 = 0x84C2,
        Texture3 = 0x84C3,
        Texture4 = 0x84C4,
        Texture5 = 0x84C5,
        Texture6 = 0x84C6,
        Texture7 = 0x84C7,
        Texture8 = 0x84C8,
        Texture9 = 0x84C9,
        Texture10 = 0x84CA,
        Texture11 = 0x84CB,
        Texture12 = 0x84CC,
        Texture13 = 0x84CD,
        Texture14 = 0x84CE,
        Texture15 = 0x84CF,
        Texture16 = 0x84D0,
        Texture17 = 0x84D1,
        Texture18 = 0x84D2,
        Texture19 = 0x84D3,
        Texture20 = 0x84D4,
        Texture21 = 0x84D5,
        Texture22 = 0x84D6,
        Texture23 = 0x84D7,
        Texture24 = 0x84D8,
        Texture25 = 0x84D9,
        Texture26 = 0x84DA,
        Texture27 = 0x84DB,
        Texture28 = 0x84DC,
        Texture29 = 0x84DD,
        Texture30 = 0x84DE,
        Texture31 = 0x84DF
    }

    public enum TransformFeedbackMode
    {
        InterleavedAttribs = 0x8C8C,
        SeparateAttribs = 0x8C8D
    }

    public enum TransformFeedbackParameterName
    {
        TransformFeedbackBufferBinding = 0x8C8F,
        TransformFeedbackBufferStart = 0x8C84,
        TransformFeedbackBufferSize = 0x8C85,
        TransformFeedbackPaused = 0x8E23,
        TransformFeedbackActive = 0x8E24
    }

    public enum Version32
    {
        ContextCoreProfileBit = 0x00000001,
        SyncFlushCommandsBit = 0x00000001,
        ContextCompatibilityProfileBit = 0x00000002,
        LinesAdjacency = 0x000A,
        LineStripAdjacency = 0x000B,
        TrianglesAdjacency = 0x000C,
        TriangleStripAdjacency = 0x000D,
        ProgramPointSize = 0x8642,
        DepthClamp = 0x864F,
        TextureCubeMapSeamless = 0x884F,
        GeometryVerticesOut = 0x8916,
        GeometryInputType = 0x8917,
        GeometryOutputType = 0x8918,
        MaxVaryingComponents = 0x8B4B,
        MaxGeometryTextureImageUnits = 0x8C29,
        FramebufferAttachmentTextureLayer = 0x8CD4,
        FramebufferAttachmentLayered = 0x8DA7,
        FramebufferIncompleteLayerTargets = 0x8DA8,
        GeometryShader = 0x8DD9,
        MaxGeometryUniformComponents = 0x8DDF,
        MaxGeometryOutputVertices = 0x8DE0,
        MaxGeometryTotalOutputComponents = 0x8DE1,
        QuadsFollowProvokingVertexConvention = 0x8E4C,
        FirstVertexConvention = 0x8E4D,
        LastVertexConvention = 0x8E4E,
        ProvokingVertex = 0x8E4F,
        SamplePosition = 0x8E50,
        SampleMask = 0x8E51,
        SampleMaskValue = 0x8E52,
        MaxSampleMaskWords = 0x8E59,
        Texture2DMultisample = 0x9100,
        ProxyTexture2DMultisample = 0x9101,
        Texture2DMultisampleArray = 0x9102,
        ProxyTexture2DMultisampleArray = 0x9103,
        TextureBinding2DMultisample = 0x9104,
        TextureBinding2DMultisampleArray = 0x9105,
        TextureSamples = 0x9106,
        TextureFixedSampleLocations = 0x9107,
        Sampler2DMultisample = 0x9108,
        IntSampler2DMultisample = 0x9109,
        UnsignedIntSampler2DMultisample = 0x910A,
        Sampler2DMultisampleArray = 0x910B,
        IntSampler2DMultisampleArray = 0x910C,
        UnsignedIntSampler2DMultisampleArray = 0x910D,
        MaxColorTextureSamples = 0x910E,
        MaxDepthTextureSamples = 0x910F,
        MaxIntegerSamples = 0x9110,
        MaxServerWaitTimeout = 0x9111,
        ObjectType = 0x9112,
        SyncCondition = 0x9113,
        SyncStatus = 0x9114,
        SyncFlags = 0x9115,
        SyncFence = 0x9116,
        SyncGpuCommandsComplete = 0x9117,
        Unsignaled = 0x9118,
        Signaled = 0x9119,
        AlreadySignaled = 0x911A,
        TimeoutExpired = 0x911B,
        ConditionSatisfied = 0x911C,
        WaitFailed = 0x911D,
        MaxVertexOutputComponents = 0x9122,
        MaxGeometryInputComponents = 0x9123,
        MaxGeometryOutputComponents = 0x9124,
        MaxFragmentInputComponents = 0x9125,
        ContextProfileMask = 0x9126,
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)
    }

    public enum VertexAttribParameter
    {
        ArrayEnabled = 0x8622,
        ArraySize = 0x8623,
        ArrayStride = 0x8624,
        ArrayType = 0x8625,
        CurrentVertexAttrib = 0x8626,
        ArrayNormalized = 0x886A,
        VertexAttribArrayInteger = 0x88FD,
        ArrayLong = 0x874E,
        ArrayDivisor = 0x88FE,
        RelativeOffset = 0x82D5
    }

    public enum VertexAttribPointerParameter
    {
        ArrayPointer = 0x8645
    }

    public enum VertexAttribFormat
    {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Int = 0x1404,
        UnsignedInt = 0x1405,
        Float = 0x1406,
        Double = 0x140A,
        HalfFloat = 0x140B,
        UnsignedUInt2101010Reversed = 0x8368,
        UnsignedInt2101010Reversed = 0x8D9F,
        UnsignedUInt101111Reversed = 0x8C3B
    }

    public enum VertexAttribPType
    {
        UnsignedUInt2101010Reversed = 0x8368,
        UnsignedInt2101010Reversed = 0x8D9F
    }

    public enum VertexAttribPointerType
    {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Int = 0x1404,
        UnsignedInt = 0x1405,
        Float = 0x1406,
        Double = 0x140A,
        HalfFloat = 0x140B,
        UnsignedUInt2101010Reversed = 0x8368,
        UnsignedInt2101010Reversed = 0x8D9F
    }
}
