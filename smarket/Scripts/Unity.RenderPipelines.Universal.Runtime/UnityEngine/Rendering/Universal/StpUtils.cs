using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal static class StpUtils
	{
		internal static TemporalAA.JitterFunc s_JitterFunc;

		private static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling)
		{
			jitter = default(Vector2);
			allowScaling = default(bool);
		}

		private static void PopulateStpConfig(UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, int debugViewIndex, TextureHandle debugView, TextureHandle destination, Texture2D noiseTexture, out STP.Config config)
		{
			config = default(STP.Config);
		}

		internal static void Execute(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, TextureHandle destination, Texture2D noiseTexture)
		{
		}
	}
}
