using System;
using Unity.Collections;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal struct OccluderContext : IDisposable
	{
		private static class ShaderIDs
		{
			public static readonly int _SrcDepth;

			public static readonly int _DstDepth;

			public static readonly int OccluderDepthPyramidConstants;
		}

		public const int k_FirstDepthMipIndex = 3;

		public const int k_MaxOccluderMips = 8;

		public const int k_MaxSilhouettePlanes = 6;

		public const int k_MaxSubviewsPerView = 6;

		public int version;

		public Vector2Int depthBufferSize;

		public NativeArray<OccluderDerivedData> subviewData;

		public int subviewValidMask;

		public NativeArray<OccluderMipBounds> occluderMipBounds;

		public Vector2Int occluderMipLayoutSize;

		public Vector2Int occluderDepthPyramidSize;

		public RTHandle occluderDepthPyramid;

		public int occlusionDebugOverlaySize;

		public GraphicsBuffer occlusionDebugOverlay;

		public bool debugNeedsClear;

		public ComputeBuffer constantBuffer;

		public NativeArray<OccluderDepthPyramidConstants> constantBufferData;

		public int subviewCount => 0;

		public Vector2 depthBufferSizeInOccluderPixels => default(Vector2);

		public bool IsSubviewValid(int subviewIndex)
		{
			return false;
		}

		public void Dispose()
		{
		}

		private void UpdateMipBounds()
		{
		}

		private void AllocateTexturesIfNecessary(bool debugOverlayEnabled)
		{
		}

		internal static void SetKeyword(ComputeCommandBuffer cmd, ComputeShader cs, in LocalKeyword keyword, bool value)
		{
		}

		private OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, NativeArray<Plane> silhouettePlanes)
		{
			return default(OccluderDepthPyramidConstants);
		}

		public void CreateFarDepthPyramid(ComputeCommandBuffer cmd, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, in OccluderHandles occluderHandles, NativeArray<Plane> silhouettePlanes, ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel)
		{
		}

		public OccluderHandles Import(RenderGraph renderGraph)
		{
			return default(OccluderHandles);
		}

		public void PrepareOccluders(in OccluderParameters occluderParams)
		{
		}

		internal OcclusionCullingDebugOutput GetDebugOutput()
		{
			return default(OcclusionCullingDebugOutput);
		}
	}
}
