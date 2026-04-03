using System.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe
{
	internal sealed class UnsafeHashSetDebuggerTypeProxy<T> where T : struct
	{
		private HashMapHelper<T> Data;

		public List<T> Items => null;

		public UnsafeHashSetDebuggerTypeProxy(UnsafeHashSet<T> data)
		{
		}
	}
}
