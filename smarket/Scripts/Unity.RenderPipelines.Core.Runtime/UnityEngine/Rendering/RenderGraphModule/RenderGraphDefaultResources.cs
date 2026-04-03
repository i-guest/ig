using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public class RenderGraphDefaultResources
	{
		private RTHandle m_BlackTexture2D;

		private RTHandle m_WhiteTexture2D;

		private RTHandle m_ShadowTexture2D;

		public TextureHandle blackTexture { get; private set; }

		public TextureHandle whiteTexture { get; private set; }

		public TextureHandle clearTextureXR { get; private set; }

		public TextureHandle magentaTextureXR { get; private set; }

		public TextureHandle blackTextureXR { get; private set; }

		public TextureHandle blackTextureArrayXR { get; private set; }

		public TextureHandle blackUIntTextureXR { get; private set; }

		public TextureHandle blackTexture3DXR { get; private set; }

		public TextureHandle whiteTextureXR { get; private set; }

		public TextureHandle defaultShadowTexture { get; private set; }

		internal RenderGraphDefaultResources()
		{
		}

		private void InitDefaultResourcesIfNeeded()
		{
		}

		internal void Cleanup()
		{
		}

		internal void InitializeForRendering(RenderGraph renderGraph)
		{
		}
	}
}
