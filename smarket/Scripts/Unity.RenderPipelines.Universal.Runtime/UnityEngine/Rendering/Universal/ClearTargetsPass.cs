using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class ClearTargetsPass
	{
		private class PassData
		{
			internal TextureHandle color;

			internal TextureHandle depth;

			internal RTClearFlags clearFlags;

			internal Color clearColor;
		}

		private static ProfilingSampler s_ClearProfilingSampler;

		internal static void Render(RenderGraph graph, TextureHandle colorHandle, TextureHandle depthHandle, UniversalCameraData cameraData)
		{
		}

		internal static void Render(RenderGraph graph, TextureHandle colorHandle, TextureHandle depthHandle, RTClearFlags clearFlags, Color clearColor)
		{
		}
	}
}
