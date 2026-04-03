using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	[NativeContainer]
	[DebuggerTypeProxy(typeof(NativeParallelMultiHashMapDebuggerTypeProxy<, >))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct NativeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct where TValue : struct
	{
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public struct ParallelWriter
		{
			internal UnsafeParallelMultiHashMap<TKey, TValue>.ParallelWriter m_Writer;

			public int m_ThreadIndex => 0;

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

		public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			internal NativeParallelMultiHashMap<TKey, TValue> hashmap;

			internal TKey key;

			internal byte isFirst;

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

		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct KeyValueEnumerator : IEnumerator<KeyValue<TKey, TValue>>, IEnumerator, IDisposable
		{
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;

			public readonly KeyValue<TKey, TValue> Current
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

		[NativeContainer]
		[NativeContainerIsReadOnly]
		[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy<, >))]
		[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
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

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			private readonly void CheckRead()
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private readonly void ThrowKeyNotPresent(TKey key)
			{
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

		internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;

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

		public readonly bool IsCreated => false;

		public NativeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_MultiHashMapData = default(UnsafeParallelMultiHashMap<TKey, TValue>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal void Initialize<U>(int capacity, ref U allocator) where U : struct
		{
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

		public void Remove(NativeParallelMultiHashMapIterator<TKey> it)
		{
		}

		public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
		{
			item = default(TValue);
			it = default(NativeParallelMultiHashMapIterator<TKey>);
			return false;
		}

		public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
		{
			item = default(TValue);
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public int CountValuesForKey(TKey key)
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

		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<TKey>);
		}

		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<TValue>);
		}

		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeKeyValueArrays<TKey, TValue>);
		}

		public ParallelWriter AsParallelWriter()
		{
			return default(ParallelWriter);
		}

		public Enumerator GetValuesForKey(TKey key)
		{
			return default(Enumerator);
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckRead()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckWrite()
		{
		}
	}
}
