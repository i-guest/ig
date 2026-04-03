using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
	{
		private static int m_TextureCreationIndex;

		internal TextureUVOriginSelection textureUVOrigin;

		public override string GetName()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetDescHashCode()
		{
			return 0;
		}

		public override void CreateGraphicsResource()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void UpdateGraphicsResource()
		{
		}

		public override void ReleaseGraphicsResource()
		{
		}

		public override void LogCreation(RenderGraphLogger logger)
		{
		}

		public override void LogRelease(RenderGraphLogger logger)
		{
		}
	}
}
