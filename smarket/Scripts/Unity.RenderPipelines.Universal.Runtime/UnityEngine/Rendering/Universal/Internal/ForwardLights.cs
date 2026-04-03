using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class ForwardLights
	{
		private static class LightConstantBuffer
		{
			public static int _MainLightPosition;

			public static int _MainLightColor;

			public static int _MainLightOcclusionProbesChannel;

			public static int _MainLightLayerMask;

			public static int _AdditionalLightsCount;

			public static int _AdditionalLightsPosition;

			public static int _AdditionalLightsColor;

			public static int _AdditionalLightsAttenuation;

			public static int _AdditionalLightsSpotDir;

			public static int _AdditionalLightOcclusionProbeChannel;

			public static int _AdditionalLightsLayerMasks;
		}

		internal struct InitParams
		{
			public LightCookieManager lightCookieManager;

			public bool forwardPlus;

			internal static InitParams Create()
			{
				return default(InitParams);
			}
		}

		private class SetupLightPassData
		{
			internal UniversalRenderingData renderingData;

			internal UniversalCameraData cameraData;

			internal UniversalLightData lightData;

			internal ForwardLights forwardLights;
		}

		private int m_AdditionalLightsBufferId;

		private int m_AdditionalLightsIndicesId;

		private const string k_SetupLightConstants = "Setup Light Constants";

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_ProfilingSamplerFPSetup;

		private static readonly ProfilingSampler m_ProfilingSamplerFPComplete;

		private static readonly ProfilingSampler m_ProfilingSamplerFPUpload;

		private MixedLightingSetup m_MixedLightingSetup;

		private Vector4[] m_AdditionalLightPositions;

		private Vector4[] m_AdditionalLightColors;

		private Vector4[] m_AdditionalLightAttenuations;

		private Vector4[] m_AdditionalLightSpotDirections;

		private Vector4[] m_AdditionalLightOcclusionProbeChannels;

		private float[] m_AdditionalLightsLayerMasks;

		private bool m_UseStructuredBuffer;

		private bool m_UseForwardPlus;

		private int m_DirectionalLightCount;

		private int m_ActualTileWidth;

		private int2 m_TileResolution;

		private JobHandle m_CullingHandle;

		private NativeArray<uint> m_ZBins;

		private GraphicsBuffer m_ZBinsBuffer;

		private NativeArray<uint> m_TileMasks;

		private GraphicsBuffer m_TileMasksBuffer;

		private LightCookieManager m_LightCookieManager;

		private ReflectionProbeManager m_ReflectionProbeManager;

		private int m_WordsPerTile;

		private float m_ZBinScale;

		private float m_ZBinOffset;

		private int m_LightCount;

		private int m_BinCount;

		private static ProfilingSampler s_SetupForwardLights;

		internal ReflectionProbeManager reflectionProbeManager => default(ReflectionProbeManager);

		public ForwardLights()
		{
		}

		internal ForwardLights(InitParams initParams)
		{
		}

		private void CreateForwardPlusBuffers()
		{
		}

		private static int AlignByteCount(int count, int align)
		{
			return 0;
		}

		private static void GetViewParams(bool isOrthographic, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias)
		{
			viewPlaneBot = default(float);
			viewPlaneTop = default(float);
			viewToViewportScaleBias = default(float4);
		}

		internal static JobHandle ScheduleClusteringJobs(bool hasMainLight, bool supportsAdditionalLights, NativeArray<VisibleLight> lights, NativeArray<VisibleReflectionProbe> probes, NativeArray<uint> zBins, NativeArray<uint> tileMasks, Fixed2<float4x4> worldToViews, Fixed2<float4x4> viewToClips, int viewCount, int2 screenResolution, float nearClipPlane, float farClipPlane, bool isOrthographic, out int localLightCount, out int directionalLightCount, out int binCount, out float zBinScale, out float zBinOffset, out int2 tileResolution, out int actualTileWidth, out int wordsPerTile)
		{
			localLightCount = default(int);
			directionalLightCount = default(int);
			binCount = default(int);
			zBinScale = default(float);
			zBinOffset = default(float);
			tileResolution = default(int2);
			actualTileWidth = default(int);
			wordsPerTile = default(int);
			return default(JobHandle);
		}

		internal void PreSetup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
		}

		public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
		}

		internal void SetupLights(UnsafeCommandBuffer cmd, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
		{
		}

		internal void Cleanup()
		{
		}

		private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, bool supportsLightLayers, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive)
		{
			lightPos = default(Vector4);
			lightColor = default(Vector4);
			lightAttenuation = default(Vector4);
			lightSpotDir = default(Vector4);
			lightOcclusionProbeChannel = default(Vector4);
			lightLayerMask = default(uint);
			isSubtractive = default(bool);
		}

		private void SetupShaderLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData)
		{
		}

		private void SetupMainLightConstants(UnsafeCommandBuffer cmd, UniversalLightData lightData)
		{
		}

		private void SetupAdditionalLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData)
		{
		}

		private int SetupPerObjectLightIndices(CullingResults cullResults, UniversalLightData lightData)
		{
			return 0;
		}
	}
}
