using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[DebuggerDisplay("Key = {Key}, Value = {Value}")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct KVPair<TKey, TValue> where TKey : struct where TValue : struct
	{
		internal unsafe HashMapHelper<TKey>* m_Data;

		internal int m_Index;

		internal int m_Next;

		public static KVPair<TKey, TValue> Null => default(KVPair<TKey, TValue>);

		public TKey Key => default(TKey);

		public ref TValue Value
		{
			get
			{
				throw null;
			}
		}

		public bool GetKeyValue(out TKey key, out TValue value)
		{
			key = default(TKey);
			value = default(TValue);
			return false;
		}
	}
}
