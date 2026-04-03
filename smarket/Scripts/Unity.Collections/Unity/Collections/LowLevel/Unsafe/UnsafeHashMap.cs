using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerTypeProxy(typeof(UnsafeHashMapDebuggerTypeProxy<, >))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct UnsafeHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable where TKey : struct where TValue : struct
	{
		public struct Enumerator : IEnumerator<KVPair<TKey, TValue>>, IEnumerator, IDisposable
		{
			internal HashMapHelper<TKey>.Enumerator m_Enumerator;

			public KVPair<TKey, TValue> Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(KVPair<TKey, TValue>);
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
		public struct ReadOnly : IEnumerable<KVPair<TKey, TValue>>, IEnumerable
		{
			[NativeDisableUnsafePtrRestriction]
			internal HashMapHelper<TKey> m_Data;

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

			public readonly int Count
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0;
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

			public readonly TValue this[TKey key] => default(TValue);

			internal ReadOnly(ref HashMapHelper<TKey> data)
			{
				m_Data = default(HashMapHelper<TKey>);
			}

			public readonly bool TryGetValue(TKey key, out TValue item)
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

			public readonly Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			IEnumerator<KVPair<TKey, TValue>> IEnumerable<KVPair<TKey, TValue>>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal HashMapHelper<TKey> m_Data;

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

		public readonly int Count
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
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

		public TValue this[TKey key]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public UnsafeHashMap(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = default(HashMapHelper<TKey>);
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public void Clear()
		{
		}

		public bool TryAdd(TKey key, TValue item)
		{
			return false;
		}

		public void Add(TKey key, TValue item)
		{
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue item)
		{
			item = default(TValue);
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public void TrimExcess()
		{
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

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<KVPair<TKey, TValue>> IEnumerable<KVPair<TKey, TValue>>.GetEnumerator()
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

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void ThrowKeyNotPresent(TKey key)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void ThrowKeyAlreadyAdded(TKey key)
		{
		}
	}
}
