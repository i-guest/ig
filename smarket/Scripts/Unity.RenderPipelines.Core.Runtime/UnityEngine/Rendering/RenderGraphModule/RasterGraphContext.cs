using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public struct RasterGraphContext : IDerivedRendergraphContext
	{
		private InternalRenderGraphContext wrappedContext;

		public RasterCommandBuffer cmd;

		internal static RasterCommandBuffer rastercmd;

		public RenderGraphDefaultResources defaultResources => null;

		public RenderGraphObjectPool renderGraphPool => null;

		public void FromInternalContext(InternalRenderGraphContext context)
		{
		}

		public readonly TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle)
		{
			return default(TextureUVOrigin);
		}

		TextureUVOrigin IDerivedRendergraphContext.GetTextureUVOrigin(in TextureHandle textureHandle)
		{
			return default(TextureUVOrigin);
		}
	}
}
