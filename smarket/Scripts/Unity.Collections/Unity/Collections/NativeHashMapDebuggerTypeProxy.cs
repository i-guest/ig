using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	internal sealed class NativeHashMapDebuggerTypeProxy<TKey, TValue> where TKey : struct where TValue : struct
	{
		private unsafe HashMapHelper<TKey>* Data;

		public List<Pair<TKey, TValue>> Items => null;

		public NativeHashMapDebuggerTypeProxy(NativeHashMap<TKey, TValue> target)
		{
		}

		public NativeHashMapDebuggerTypeProxy(NativeHashMap<TKey, TValue>.ReadOnly target)
		{
		}
	}
}
