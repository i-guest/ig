using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	internal sealed class NativeListDebugView<T> where T : struct
	{
		private unsafe UnsafeList<T>* Data;

		public T[] Items => null;

		public NativeListDebugView(NativeList<T> array)
		{
		}
	}
}
