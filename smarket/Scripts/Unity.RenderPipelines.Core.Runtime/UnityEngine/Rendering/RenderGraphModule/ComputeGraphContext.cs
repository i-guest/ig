using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public class ComputeGraphContext : IDerivedRendergraphContext
	{
		private InternalRenderGraphContext wrappedContext;

		public ComputeCommandBuffer cmd;

		internal static ComputeCommandBuffer computecmd;

		public RenderGraphDefaultResources defaultResources => null;

		public RenderGraphObjectPool renderGraphPool => null;

		public void FromInternalContext(InternalRenderGraphContext context)
		{
		}

		public TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle)
		{
			return default(TextureUVOrigin);
		}

		TextureUVOrigin IDerivedRendergraphContext.GetTextureUVOrigin(in TextureHandle textureHandle)
		{
			return default(TextureUVOrigin);
		}
	}
}
