using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	[Obsolete("RenderGraphContext is deprecated, use RasterGraphContext/ComputeGraphContext/UnsafeGraphContext instead.")]
	public struct RenderGraphContext : IDerivedRendergraphContext
	{
		private InternalRenderGraphContext wrappedContext;

		public ScriptableRenderContext renderContext => default(ScriptableRenderContext);

		public CommandBuffer cmd => null;

		public RenderGraphObjectPool renderGraphPool => null;

		public RenderGraphDefaultResources defaultResources => null;

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
