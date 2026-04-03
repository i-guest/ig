using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class GlobalPropertiesPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal Vector2Int screenParams;
		}

		private static readonly string k_SetGlobalProperties;

		private static readonly ProfilingSampler m_SetGlobalPropertiesProfilingSampler;

		internal static void Setup(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, UniversalCameraData cameraData, bool useLights)
		{
		}
	}
}
