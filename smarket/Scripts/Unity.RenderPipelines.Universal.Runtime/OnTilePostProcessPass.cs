using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

public class OnTilePostProcessPass : ScriptableRenderPass
{
	private enum UberShaderPasses
	{
		Normal = 0,
		MSAASoftwareResolve = 1,
		TextureRead = 2,
		NormalVisMesh = 3,
		MSAASoftwareResolveVisMesh = 4,
		TextureReadVisMesh = 5
	}

	private class PassData
	{
		internal TextureHandle source;

		internal TextureHandle destination;

		internal TextureHandle lutTexture;

		internal TextureHandle userLutTexture;

		internal Material material;

		internal UberShaderPasses shaderPass;

		internal Vector4 scaleBias;

		internal bool useXRVisibilityMesh;

		internal XRPass xr;

		internal int msaaSamples;
	}

	private static class ShaderConstants
	{
		public static readonly int _Vignette_Params1;

		public static readonly int _Vignette_Params2;

		public static readonly int _Vignette_ParamsXR;

		public static readonly int _Lut_Params;

		public static readonly int _UserLut_Params;

		public static readonly int _InternalLut;

		public static readonly int _UserLut;
	}

	internal bool m_UseMultisampleShaderResolve;

	internal bool m_UseTextureReadFallback;

	private RTHandle m_UserLut;

	private Material m_OnTileUberMaterial;

	private static readonly int s_BlitScaleBias;

	private static readonly int s_BlitTexture;

	private int m_DitheringTextureIndex;

	private PostProcessData m_PostProcessData;

	private const string m_PassName = "On Tile Post Processing";

	private const string m_FallbackPassName = "On Tile Post Processing (sampling fallback) ";

	internal OnTilePostProcessPass(PostProcessData postProcessData)
	{
	}

	internal void Setup(ref Material onTileUberMaterial)
	{
	}

	public void Dispose()
	{
	}

	public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
	}

	private static void ExecuteFBFetchPass(PassData data, RasterGraphContext context)
	{
	}

	private TextureHandle TryGetCachedUserLutTextureHandle(ColorLookup colorLookup, RenderGraph renderGraph)
	{
		return default(TextureHandle);
	}

	private void SetupLut(Material material, ColorLookup colorLookup, ColorAdjustments colorAdjustments, int lutSize)
	{
	}

	private void SetupVignette(Material material, XRPass xrPass, int width, int height, Vignette vignette)
	{
	}

	private void SetupTonemapping(Material onTileUberMaterial, Tonemapping tonemapping, bool isHdrGrading)
	{
	}

	private void SetupGrain(Material onTileUberMaterial, UniversalCameraData cameraData, FilmGrain filmgrain, PostProcessData data)
	{
	}

	private void SetupDithering(Material onTileUberMaterial, UniversalCameraData cameraData, PostProcessData data)
	{
	}
}
