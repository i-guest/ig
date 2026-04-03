using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
	{
		private static class AdditionalShadowsConstantBuffer
		{
			public static readonly int _AdditionalLightsWorldToShadow;

			public static readonly int _AdditionalShadowParams;

			public static readonly int _AdditionalShadowOffset0;

			public static readonly int _AdditionalShadowOffset1;

			public static readonly int _AdditionalShadowFadeParams;

			public static readonly int _AdditionalShadowmapSize;

			public static readonly int _AdditionalLightsShadowmapID;

			public static readonly int _AdditionalLightsWorldToShadow_SSBO;

			public static readonly int _AdditionalShadowParams_SSBO;
		}

		private class PassData
		{
			internal int shadowmapID;

			internal bool emptyShadowmap;

			internal bool setKeywordForEmptyShadowmap;

			internal bool useStructuredBuffer;

			internal bool stripShadowsOffVariants;

			internal Matrix4x4 viewMatrix;

			internal Vector2Int allocatedShadowAtlasSize;

			internal TextureHandle shadowmapTexture;

			internal UniversalLightData lightData;

			internal UniversalShadowData shadowData;

			internal AdditionalLightsShadowCasterPass pass;

			internal readonly RendererList[] shadowRendererLists;

			internal readonly RendererListHandle[] shadowRendererListsHdl;
		}

		[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO #from(2021.1) #breakingFrom(2023.1)", true)]
		public static int m_AdditionalShadowsBufferId;

		[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO #from(2021.1) #breakingFrom(2023.1)", true)]
		public static int m_AdditionalShadowsIndicesId;

		internal RTHandle m_AdditionalLightsShadowmapHandle;

		private int renderTargetWidth;

		private int renderTargetHeight;

		private bool m_CreateEmptyShadowmap;

		private bool m_SetKeywordForEmptyShadowmap;

		private bool m_IssuedMessageAboutShadowSlicesTooMany;

		private bool m_IssuedMessageAboutShadowMapsRescale;

		private bool m_IssuedMessageAboutShadowMapsTooBig;

		private bool m_IssuedMessageAboutRemovedShadowSlices;

		private static bool m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall;

		private static bool m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall;

		private readonly bool m_UseStructuredBuffer;

		private float m_MaxShadowDistanceSq;

		private float m_CascadeBorder;

		private bool[] m_VisibleLightIndexToIsCastingShadows;

		private short[] m_VisibleLightIndexToAdditionalLightIndex;

		private short[] m_AdditionalLightIndexToVisibleLightIndex;

		private Vector4[] m_AdditionalLightIndexToShadowParams;

		private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;

		private ShadowSliceData[] m_AdditionalLightsShadowSlices;

		private readonly List<byte> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;

		private readonly List<short> m_ShadowSliceToAdditionalLightIndex;

		private readonly Dictionary<int, ulong> m_ShadowRequestsHashes;

		private readonly ProfilingSampler m_ProfilingSetupSampler;

		private RenderTextureDescriptor m_AdditionalLightShadowDescriptor;

		private const int k_ShadowmapBufferBits = 16;

		private const float k_LightTypeIdentifierInShadowParams_Spot = 0f;

		private const float k_LightTypeIdentifierInShadowParams_Point = 1f;

		private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture";

		private static readonly Vector4 c_DefaultShadowParams;

		private static Vector4 s_EmptyAdditionalShadowFadeParams;

		private static Vector4[] s_EmptyAdditionalLightIndexToShadowParams;

		private static bool isAdditionalShadowParamsDirty;

		private const int k_EmptyShadowMapDimensions = 1;

		private bool m_EmptyShadowmapNeedsClear;

		private const string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture";

		private RTHandle m_EmptyAdditionalLightShadowmapTexture;

		private PassData m_PassData;

		public AdditionalLightsShadowCasterPass(RenderPassEvent evt)
		{
		}

		public void Dispose()
		{
		}

		internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels)
		{
			return 0f;
		}

		internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering)
		{
			return 0f;
		}

		private ulong ResolutionLog2ForHash(int resolution)
		{
			return 0uL;
		}

		private ulong ComputeShadowRequestHash(UniversalLightData lightData, UniversalShadowData shadowData)
		{
			return 0uL;
		}

		private float GetLightTypeIdentifierForShadowParams(LightType lightType)
		{
			return 0f;
		}

		private bool UsesBakedShadows(Light light)
		{
			return false;
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

		private bool AnyAdditionalLightHasMixedShadows(UniversalLightData lightData)
		{
			return false;
		}

		private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UniversalLightData lightData, UniversalShadowData shadowData)
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

		public int GetShadowLightIndexFromLightIndex(int visibleLightIndex)
		{
			return 0;
		}

		private void Clear()
		{
		}

		internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer)
		{
		}

		private void RenderAdditionalShadowmapAtlas(RasterCommandBuffer cmd, ref PassData data, bool useRenderGraph)
		{
		}

		private void SetupAdditionalLightsShadowReceiverConstants(RasterCommandBuffer cmd, Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows)
		{
		}

		private void InitPassData(ref PassData passData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData)
		{
		}

		private void InitRendererLists(ref CullingResults cullResults, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph)
		{
		}

		internal TextureHandle Render(RenderGraph graph, ContextContainer frameData)
		{
			return default(TextureHandle);
		}
	}
}
