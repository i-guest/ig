using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
	{
		private enum BlurTypes
		{
			Bilateral = 0,
			Gaussian = 1,
			Kawase = 2
		}

		private enum ShaderPasses
		{
			AmbientOcclusion = 0,
			BilateralBlurHorizontal = 1,
			BilateralBlurVertical = 2,
			BilateralBlurFinal = 3,
			BilateralAfterOpaque = 4,
			GaussianBlurHorizontal = 5,
			GaussianBlurVertical = 6,
			GaussianAfterOpaque = 7,
			KawaseBlur = 8,
			KawaseAfterOpaque = 9
		}

		private struct SSAOMaterialParams
		{
			internal bool orthographicCamera;

			internal bool aoBlueNoise;

			internal bool aoInterleavedGradient;

			internal bool sampleCountHigh;

			internal bool sampleCountMedium;

			internal bool sampleCountLow;

			internal bool sourceDepthNormals;

			internal bool sourceDepthHigh;

			internal bool sourceDepthMedium;

			internal bool sourceDepthLow;

			internal Vector4 ssaoParams;

			internal SSAOMaterialParams(ref ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic)
			{
				orthographicCamera = false;
				aoBlueNoise = false;
				aoInterleavedGradient = false;
				sampleCountHigh = false;
				sampleCountMedium = false;
				sampleCountLow = false;
				sourceDepthNormals = false;
				sourceDepthHigh = false;
				sourceDepthMedium = false;
				sourceDepthLow = false;
				ssaoParams = default(Vector4);
			}

			internal bool Equals(ref SSAOMaterialParams other)
			{
				return false;
			}
		}

		private class SSAOPassData
		{
			internal bool afterOpaque;

			internal ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions BlurQuality;

			internal Material material;

			internal float directLightingStrength;

			internal TextureHandle cameraColor;

			internal TextureHandle AOTexture;

			internal TextureHandle finalTexture;

			internal TextureHandle blurTexture;

			internal TextureHandle cameraNormalsTexture;

			internal UniversalCameraData cameraData;
		}

		private readonly bool m_SupportsR8RenderTextureFormat;

		private int m_BlueNoiseTextureIndex;

		private Material m_Material;

		private Texture2D[] m_BlueNoiseTextures;

		private Vector4[] m_CameraTopLeftCorner;

		private Vector4[] m_CameraXExtent;

		private Vector4[] m_CameraYExtent;

		private Vector4[] m_CameraZExtent;

		private BlurTypes m_BlurType;

		private Matrix4x4[] m_CameraViewProjections;

		private ProfilingSampler m_ProfilingSampler;

		private RenderTextureDescriptor m_AOPassDescriptor;

		private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;

		private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";

		private const string k_AmbientOcclusionParamName = "_AmbientOcclusionParam";

		internal static readonly int s_AmbientOcclusionParamID;

		private static readonly int s_SSAOParamsID;

		private static readonly int s_SSAOBlueNoiseParamsID;

		private static readonly int s_BlueNoiseTextureID;

		private static readonly int s_SSAOFinalTextureID;

		private static readonly int s_CameraViewXExtentID;

		private static readonly int s_CameraViewYExtentID;

		private static readonly int s_CameraViewZExtentID;

		private static readonly int s_ProjectionParams2ID;

		private static readonly int s_CameraViewProjectionsID;

		private static readonly int s_CameraViewTopLeftCornerID;

		private static readonly int s_CameraNormalsTextureID;

		private RTHandle[] m_SSAOTextures;

		private SSAOPassData m_PassData;

		private ScriptableRenderer m_Renderer;

		private static readonly int[] m_BilateralTexturesIndices;

		private static readonly ShaderPasses[] m_BilateralPasses;

		private static readonly ShaderPasses[] m_BilateralAfterOpaquePasses;

		private static readonly int[] m_GaussianTexturesIndices;

		private static readonly ShaderPasses[] m_GaussianPasses;

		private static readonly ShaderPasses[] m_GaussianAfterOpaquePasses;

		private static readonly int[] m_KawaseTexturesIndices;

		private static readonly ShaderPasses[] m_KawasePasses;

		private static readonly ShaderPasses[] m_KawaseAfterOpaquePasses;

		private SSAOMaterialParams m_SSAOParamsPrev;

		internal ScreenSpaceAmbientOcclusionPass()
		{
		}

		internal bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Texture2D[] blueNoiseTextures)
		{
			return false;
		}

		private static bool IsAfterOpaquePass(ref ShaderPasses pass)
		{
			return false;
		}

		private void SetupKeywordsAndParameters(ref ScreenSpaceAmbientOcclusionSettings settings, ref UniversalCameraData cameraData)
		{
		}

		private void InitSSAOPassData(ref SSAOPassData data)
		{
		}

		private static Vector4 ComputeScaleBias(in UnsafeGraphContext context, in TextureHandle source, in TextureHandle destination)
		{
			return default(Vector4);
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		private void CreateRenderTextureHandles(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, out TextureHandle aoTexture, out TextureHandle blurTexture, out TextureHandle finalTexture)
		{
			aoTexture = default(TextureHandle);
			blurTexture = default(TextureHandle);
			finalTexture = default(TextureHandle);
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ShaderPasses pass)
		{
		}

		private static void GetPassOrder(BlurTypes blurType, bool isAfterOpaque, out int[] textureIndices, out ShaderPasses[] shaderPasses)
		{
			textureIndices = null;
			shaderPasses = null;
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public void Dispose()
		{
		}
	}
}
