using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	[DebuggerDisplay("PassRandomWriteData: Res({resource.index}):{index}:{preserveCounterValue}")]
	internal readonly struct PassRandomWriteData
	{
		public readonly ResourceHandle resource;

		public readonly int index;

		public readonly bool preserveCounterValue;

		public PassRandomWriteData(in ResourceHandle resource, int index, bool preserveCounterValue)
		{
			this.resource = default(ResourceHandle);
			this.index = 0;
			this.preserveCounterValue = false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
