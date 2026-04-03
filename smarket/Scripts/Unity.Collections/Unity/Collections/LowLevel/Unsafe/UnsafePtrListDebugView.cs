namespace Unity.Collections.LowLevel.Unsafe
{
	internal sealed class UnsafePtrListDebugView<T> where T : struct
	{
		private UnsafePtrList<T> Data;

		public unsafe T*[] Items => null;

		public UnsafePtrListDebugView(UnsafePtrList<T> data)
		{
		}
	}
}
