using System.Runtime.CompilerServices;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal static class RenderGraphUtils
	{
		private class PassData
		{
			internal TextureHandle texture;

			internal int nameID;
		}

		private static ProfilingSampler s_SetGlobalTextureProfilingSampler;

		internal const int GBufferSize = 7;

		internal const int DBufferSize = 3;

		internal const int LightTextureSize = 4;

		internal static void UseDBufferIfValid(IRasterRenderGraphBuilder builder, UniversalResourceData resourceData)
		{
		}

		public static void SetGlobalTexture(RenderGraph graph, int nameId, TextureHandle handle, string passName = "Set Global Texture", [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}
	}
}
