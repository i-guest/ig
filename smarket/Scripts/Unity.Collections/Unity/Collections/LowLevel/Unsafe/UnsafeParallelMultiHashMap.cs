using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy<, >))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct where TValue : struct
	{
		public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			internal UnsafeParallelMultiHashMap<TKey, TValue> hashmap;

			internal TKey key;

			internal bool isFirst;

			private TValue value;

			private NativeParallelMultiHashMapIterator<TKey> iterator;

			public TValue Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(TValue);
				}
			}

			object IEnumerator.Current => null;

			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public struct ParallelWriter
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeParallelHashMapData* m_Buffer;

			[NativeSetThreadIndex]
			internal int m_ThreadIndex;

			public readonly int Capacity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0;
				}
			}

			public void Add(TKey key, TValue item)
			{
			}

			public void Add(TKey key, TValue item, int threadIndexOverride)
			{
			}
		}

		public struct KeyValueEnumerator : IEnumerator<KeyValue<TKey, TValue>>, IEnumerator, IDisposable
		{
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;

			public KeyValue<TKey, TValue> Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(KeyValue<TKey, TValue>);
				}
			}

			object IEnumerator.Current => null;

			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public struct ReadOnly : IEnumerable<KeyValue<TKey, TValue>>, IEnumerable
		{
			internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;

			public readonly bool IsCreated
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return false;
				}
			}

			public readonly bool IsEmpty
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return false;
				}
			}

			public readonly int Capacity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0;
				}
			}

			internal ReadOnly(UnsafeParallelMultiHashMap<TKey, TValue> container)
			{
				m_MultiHashMapData = default(UnsafeParallelMultiHashMap<TKey, TValue>);
			}

			public readonly int Count()
			{
				return 0;
			}

			public readonly bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
			{
				item = default(TValue);
				it = default(NativeParallelMultiHashMapIterator<TKey>);
				return false;
			}

			public readonly bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
			{
				item = default(TValue);
				return false;
			}

			public readonly bool ContainsKey(TKey key)
			{
				return false;
			}

			public readonly NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator)
			{
				return default(NativeArray<TKey>);
			}

			public readonly NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator)
			{
				return default(NativeArray<TValue>);
			}

			public readonly NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator)
			{
				return default(NativeKeyValueArrays<TKey, TValue>);
			}

			public KeyValueEnumerator GetEnumerator()
			{
				return default(KeyValueEnumerator);
			}

			IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;

		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

		public readonly bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public int Capacity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0;
			}
			set
			{
			}
		}

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe UnsafeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_Buffer = null;
			m_AllocatorLabel = default(AllocatorManager.AllocatorHandle);
		}

		public readonly int Count()
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void Add(TKey key, TValue item)
		{
		}

		public int Remove(TKey key)
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public void Remove<TValueEQ>(TKey key, TValueEQ value) where TValueEQ : struct
		{
		}

		public void Remove(NativeParallelMultiHashMapIterator<TKey> it)
		{
		}

		public readonly bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
		{
			item = default(TValue);
			it = default(NativeParallelMultiHashMapIterator<TKey>);
			return false;
		}

		public readonly bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
		{
			item = default(TValue);
			return false;
		}

		public readonly bool ContainsKey(TKey key)
		{
			return false;
		}

		public readonly int CountValuesForKey(TKey key)
		{
			return 0;
		}

		public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it)
		{
			return false;
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public readonly NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<TKey>);
		}

		public readonly NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<TValue>);
		}

		public readonly NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}

		public Enumerator GetValuesForKey(TKey key)
		{
			return default(Enumerator);
		}

		public ParallelWriter AsParallelWriter()
		{
			return default(ParallelWriter);
		}

		public KeyValueEnumerator GetEnumerator()
		{
			return default(KeyValueEnumerator);
		}

		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}
	}
}
