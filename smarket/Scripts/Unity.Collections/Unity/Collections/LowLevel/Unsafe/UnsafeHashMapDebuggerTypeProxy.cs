using System.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe
{
	internal sealed class UnsafeHashMapDebuggerTypeProxy<TKey, TValue> where TKey : struct where TValue : struct
	{
		private HashMapHelper<TKey> Data;

		public List<Pair<TKey, TValue>> Items => null;

		public UnsafeHashMapDebuggerTypeProxy(UnsafeHashMap<TKey, TValue> target)
		{
		}

		public UnsafeHashMapDebuggerTypeProxy(UnsafeHashMap<TKey, TValue>.ReadOnly target)
		{
		}
	}
}
