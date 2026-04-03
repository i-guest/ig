using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("BufferResource ({desc.name})")]
	internal class BufferResource : RenderGraphResource<BufferDesc, GraphicsBuffer>
	{
		public override string GetName()
		{
			return null;
		}

		public override int GetDescHashCode()
		{
			return 0;
		}

		public override void CreateGraphicsResource()
		{
		}

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
