using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal struct ResourceVersionedData
	{
		public bool written;

		public int writePassId;

		public int numReaders;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetWritingPass(CompilerContextData ctx, in ResourceHandle h, int passId)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void RegisterReadingPass(CompilerContextData ctx, in ResourceHandle h, int passId, int index)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void RemoveReadingPass(CompilerContextData ctx, in ResourceHandle h, int passId)
		{
		}
	}
}
