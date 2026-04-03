using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	[DebuggerDisplay("PassFragmentData: Res({resource.index}):{accessFlags}")]
	internal readonly struct PassFragmentData
	{
		public readonly ResourceHandle resource;

		public readonly AccessFlags accessFlags;

		public readonly int mipLevel;

		public readonly int depthSlice;

		public PassFragmentData(in ResourceHandle handle, AccessFlags flags, int mipLevel, int depthSlice)
		{
			resource = default(ResourceHandle);
			accessFlags = default(AccessFlags);
			this.mipLevel = 0;
			this.depthSlice = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool SameSubResource(in PassFragmentData x, in PassFragmentData y)
		{
			return false;
		}
	}
}
