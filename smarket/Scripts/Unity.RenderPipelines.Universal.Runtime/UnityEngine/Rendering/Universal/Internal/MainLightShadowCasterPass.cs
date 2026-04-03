using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class MainLightShadowCasterPass : ScriptableRenderPass
	{
		private static class MainLightShadowConstantBuffer
		{
			public static readonly int _WorldToShadow;

			public static readonly int _ShadowParams;

			public static readonly int _CascadeShadowSplitSpheres0;

			public static readonly int _CascadeShadowSplitSpheres1;

			public static readonly int _CascadeShadowSplitSpheres2;

			public static readonly int _CascadeShadowSplitSpheres3;

			public static readonly int _CascadeShadowSplitSphereRadii;

			public static readonly int _ShadowOffset0;

			public static readonly int _ShadowOffset1;

			public static readonly int _ShadowmapSize;

			public static readonly int _MainLightShadowmapID;
		}

		private class PassData
		{
			internal bool emptyShadowmap;

			internal bool setKeywordForEmptyShadowmap;

			internal UniversalRenderingData renderingData;

			internal UniversalCameraData cameraData;

			internal UniversalLightData lightData;

			internal UniversalShadowData shadowData;

			internal MainLightShadowCasterPass pass;

			internal TextureHandle shadowmapTexture;

			internal readonly RendererList[] shadowRendererLists;

			internal readonly RendererListHandle[] shadowRendererListsHandle;
		}

		internal RTHandle m_MainLightShadowmapTexture;

		private int m_RenderTargetWidth;

		private int m_RenderTargetHeight;

		private int m_ShadowCasterCascadesCount;

		private bool m_CreateEmptyShadowmap;

		private bool m_SetKeywordForEmptyShadowmap;

		private float m_CascadeBorder;

		private float m_MaxShadowDistanceSq;

		private RenderTextureDescriptor m_MainLightShadowDescriptor;

		private readonly Vector4[] m_CascadeSplitDistances;

		private readonly Matrix4x4[] m_MainLightShadowMatrices;

		private readonly ProfilingSampler m_ProfilingSetupSampler;

		private readonly ShadowSliceData[] m_CascadeSlices;

		private const int k_EmptyShadowMapDimensions = 1;

		private const int k_MaxCascades = 4;

		private const int k_ShadowmapBufferBits = 16;

		private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture";

		private static Vector4 s_EmptyShadowParams;

		private static readonly Vector4 s_EmptyShadowmapSize;

		private bool m_EmptyShadowmapNeedsClear;

		private RTHandle m_EmptyMainLightShadowmapTexture;

		private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture";

		private PassData m_PassData;

		public MainLightShadowCasterPass(RenderPassEvent evt)
		{
		}

		public void Dispose()
		{
		}

		public bool Setup(ref RenderingData renderingData)
		{
			return false;
		}

		public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData)
		{
			return false;
		}

		private void UpdateTextureDescriptorIfNeeded()
		{
		}

		private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, Light light, UniversalCameraData cameraData, UniversalShadowData shadowData)
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void Clear()
		{
		}

		internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer)
		{
		}

		private void RenderMainLightCascadeShadowmap(RasterCommandBuffer cmd, ref PassData data, bool isRenderGraph)
		{
		}

		private void SetupMainLightShadowReceiverConstants(RasterCommandBuffer cmd, ref VisibleLight shadowLight, UniversalShadowData shadowData)
		{
		}

		private void InitPassData(ref PassData passData, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData)
		{
		}

		private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph)
		{
		}

		internal TextureHandle Render(RenderGraph graph, ContextContainer frameData)
		{
			return default(TextureHandle);
		}
	}
}
