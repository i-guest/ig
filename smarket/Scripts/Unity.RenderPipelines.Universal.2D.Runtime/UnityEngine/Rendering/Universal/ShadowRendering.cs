using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal static class ShadowRendering
	{
		internal enum ShadowTestType
		{
			Always = 0,
			Unshadow = 1
		}

		private static readonly int k_LightPosID;

		private static readonly int k_ShadowRadiusID;

		private static readonly int k_ShadowColorMaskID;

		private static readonly int k_ShadowModelMatrixID;

		private static readonly int k_ShadowModelInvMatrixID;

		private static readonly int k_ShadowModelScaleID;

		private static readonly int k_ShadowContractionDistanceID;

		private static readonly int k_ShadowAlphaCutoffID;

		private static readonly int k_SoftShadowAngle;

		private static readonly int k_ShadowSoftnessFalloffIntensityID;

		private static readonly int k_ShadowShadowColorID;

		private static readonly int k_ShadowUnshadowColorID;

		private static readonly ProfilingSampler m_ProfilingSamplerShadows;

		private static readonly ProfilingSampler m_ProfilingSamplerShadowsA;

		private static readonly ProfilingSampler m_ProfilingSamplerShadowsR;

		private static readonly ProfilingSampler m_ProfilingSamplerShadowsG;

		private static readonly ProfilingSampler m_ProfilingSamplerShadowsB;

		private static readonly float k_MaxShadowSoftnessAngle;

		private static readonly Color k_ShadowColorLookup;

		private static readonly Color k_UnshadowColorLookup;

		private static RTHandle[] m_RenderTargets;

		private static int[] m_RenderTargetIds;

		private static RenderTargetIdentifier[] m_LightInputTextures;

		private static readonly ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup;

		public static uint maxTextureCount { get; private set; }

		public static RenderTargetIdentifier[] lightInputTextures => null;

		internal static void InitializeBudget(uint maxTextureCount)
		{
		}

		private static Material CreateMaterial(Shader shader, int offset, int pass)
		{
			return null;
		}

		private static Material GetProjectedShadowMaterial(Material material, Func<Renderer2DResources, Shader> shaderFunc, int offset, int pass)
		{
			return null;
		}

		internal static Material GetProjectedShadowMaterial(this Renderer2DData rendererData)
		{
			return null;
		}

		internal static Material GetProjectedUnshadowMaterial(this Renderer2DData rendererData)
		{
			return null;
		}

		private static Material GetSpriteShadowMaterial(this Renderer2DData rendererData)
		{
			return null;
		}

		private static Material GetSpriteUnshadowMaterial(this Renderer2DData rendererData)
		{
			return null;
		}

		private static Material GetGeometryShadowMaterial(this Renderer2DData rendererData)
		{
			return null;
		}

		private static Material GetGeometryUnshadowMaterial(this Renderer2DData rendererData)
		{
			return null;
		}

		private static void CalculateFrustumCornersPerspective(Camera camera, float distance, NativeArray<Vector3> corners)
		{
		}

		private static void CalculateFrustumCornersOrthographic(Camera camera, float distance, NativeArray<Vector3> corners)
		{
		}

		private static Bounds CalculateWorldSpaceBounds(Camera camera, ILight2DCullResult cullResult)
		{
			return default(Bounds);
		}

		internal static void CallOnBeforeRender(Camera camera, ILight2DCullResult cullResult)
		{
		}

		internal static void PrerenderShadows(UnsafeCommandBuffer cmdBuffer, Renderer2DData rendererData, ref LayerBatch layer, Light2D light, int shadowIndex, float shadowIntensity)
		{
		}

		private static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int shadowIndex)
		{
		}

		internal static bool PrerenderShadows(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, ref LayerBatch layer, Light2D light, int shadowIndex, float shadowIntensity)
		{
			return false;
		}

		private static void CreateShadowRenderTexture(IRenderPass2D pass, int handleId, RenderingData renderingData, CommandBuffer cmdBuffer)
		{
		}

		internal static void ReleaseShadowRenderTexture(CommandBuffer cmdBuffer, int shadowIndex)
		{
		}

		private static void SetShadowProjectionGlobals(UnsafeCommandBuffer cmdBuffer, ShadowCaster2D shadowCaster, Light2D light)
		{
		}

		internal static void SetGlobalShadowTexture(CommandBuffer cmdBuffer, Light2D light, int shadowIndex)
		{
		}

		internal static void SetGlobalShadowProp(IRasterCommandBuffer cmdBuffer)
		{
		}

		private static bool ShadowCasterIsVisible(ShadowCaster2D shadowCaster)
		{
			return false;
		}

		private static Renderer GetRendererFromCaster(ShadowCaster2D shadowCaster, Light2D light, int layerToRender)
		{
			return null;
		}

		private static void RenderProjectedShadows(UnsafeCommandBuffer cmdBuffer, int layerToRender, Light2D light, List<ShadowCaster2D> shadowCasters, Material projectedShadowsMaterial, int pass, ShadowTestType shadowTestType)
		{
		}

		private static int GetRendererSubmeshes(Renderer renderer, ShadowCaster2D shadowCaster2D)
		{
			return 0;
		}

		private static void RenderSpriteShadow(UnsafeCommandBuffer cmdBuffer, int layerToRender, Light2D light, List<ShadowCaster2D> shadowCasters, Material spriteShadowMaterial, Material spriteUnshadowMaterial, Material geometryShadowMaterial, Material geometryUnshadowMaterial, int pass, ShadowTestType shadowTestType)
		{
		}

		internal static bool ShadowTest(ShadowTestType shadowTestType, ShadowCaster2D shadowCaster)
		{
			return false;
		}

		private static void RenderShadows(UnsafeCommandBuffer cmdBuffer, Renderer2DData rendererData, ref LayerBatch layer, Light2D light)
		{
		}
	}
}
