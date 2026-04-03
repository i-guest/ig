namespace UnityEngine.Rendering
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\GPUDriven\\OcclusionCullingCommonShaderVariables.cs", needAccessors = false, generateCBuffer = true)]
	internal struct OcclusionCullingCommonShaderVariables
	{
		[HLSLArray(8, typeof(ShaderGenUInt4))]
		public unsafe fixed uint _OccluderMipBounds[32];

		[HLSLArray(6, typeof(Matrix4x4))]
		public unsafe fixed float _ViewProjMatrix[96];

		[HLSLArray(6, typeof(Vector4))]
		public unsafe fixed float _ViewOriginWorldSpace[24];

		[HLSLArray(6, typeof(Vector4))]
		public unsafe fixed float _FacingDirWorldSpace[24];

		[HLSLArray(6, typeof(Vector4))]
		public unsafe fixed float _RadialDirWorldSpace[24];

		public Vector4 _DepthSizeInOccluderPixels;

		public Vector4 _OccluderDepthPyramidSize;

		public uint _OccluderMipLayoutSizeX;

		public uint _OccluderMipLayoutSizeY;

		public uint _OcclusionTestDebugFlags;

		public uint _OcclusionCullingCommonPad0;

		public int _OcclusionTestCount;

		public int _OccluderSubviewIndices;

		public int _CullingSplitIndices;

		public int _CullingSplitMask;

		internal OcclusionCullingCommonShaderVariables(in OccluderContext occluderCtx, in InstanceOcclusionTestSubviewSettings subviewSettings, bool occlusionOverlayCountVisible, bool overrideOcclusionTestToAlwaysPass)
		{
			_DepthSizeInOccluderPixels = default(Vector4);
			_OccluderDepthPyramidSize = default(Vector4);
			_OccluderMipLayoutSizeX = 0u;
			_OccluderMipLayoutSizeY = 0u;
			_OcclusionTestDebugFlags = 0u;
			_OcclusionCullingCommonPad0 = 0u;
			_OcclusionTestCount = 0;
			_OccluderSubviewIndices = 0;
			_CullingSplitIndices = 0;
			_CullingSplitMask = 0;
		}
	}
}
