using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe
{
	internal struct UnsafeParallelHashMapDataEnumerator
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;

		internal int m_Index;

		internal int m_BucketIndex;

		internal int m_NextIndex;

		internal unsafe UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data)
		{
			m_Buffer = null;
			m_Index = 0;
			m_BucketIndex = 0;
			m_NextIndex = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool MoveNext()
		{
			return false;
		}

		internal void Reset()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>() where TKey : struct where TValue : struct
		{
			return default(KeyValue<TKey, TValue>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal TKey GetCurrentKey<TKey>() where TKey : struct
		{
			return default(TKey);
		}
	}
}
