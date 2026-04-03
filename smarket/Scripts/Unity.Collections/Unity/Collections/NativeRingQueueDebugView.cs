using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	internal sealed class NativeRingQueueDebugView<T> where T : struct
	{
		private unsafe UnsafeRingQueue<T>* Data;

		public T[] Items => null;

		public NativeRingQueueDebugView(NativeRingQueue<T> data)
		{
		}
	}
}
