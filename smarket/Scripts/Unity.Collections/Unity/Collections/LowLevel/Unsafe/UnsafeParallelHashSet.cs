using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerTypeProxy(typeof(UnsafeParallelHashSetDebuggerTypeProxy<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct UnsafeParallelHashSet<T> : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable where T : struct
	{
		[NativeContainerIsAtomicWriteOnly]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelWriter
		{
			internal UnsafeParallelHashMap<T, bool>.ParallelWriter m_Data;

			public readonly int Capacity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return 0;
				}
			}

			public bool Add(T item)
			{
				return false;
			}

			public bool Add(T item, int threadIndexOverride)
			{
				return false;
			}
		}

		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;

			public T Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return default(T);
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

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ReadOnly : IEnumerable<T>, IEnumerable
		{
			internal UnsafeParallelHashMap<T, bool> m_Data;

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

			internal ReadOnly(ref UnsafeParallelHashSet<T> data)
			{
				m_Data = default(UnsafeParallelHashMap<T, bool>);
			}

			public readonly int Count()
			{
				return 0;
			}

			public readonly bool Contains(T item)
			{
				return false;
			}

			public readonly NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator)
			{
				return default(NativeArray<T>);
			}

			public readonly Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal UnsafeParallelHashMap<T, bool> m_Data;

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

		public UnsafeParallelHashSet(int capacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = default(UnsafeParallelHashMap<T, bool>);
		}

		public int Count()
		{
			return 0;
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

		public bool Add(T item)
		{
			return false;
		}

		public bool Remove(T item)
		{
			return false;
		}

		public bool Contains(T item)
		{
			return false;
		}

		public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<T>);
		}

		public ParallelWriter AsParallelWriter()
		{
			return default(ParallelWriter);
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
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
