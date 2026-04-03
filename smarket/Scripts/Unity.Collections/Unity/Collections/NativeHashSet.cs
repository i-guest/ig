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
	[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct NativeHashSet<T> : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable where T : struct
	{
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[NativeDisableUnsafePtrRestriction]
			internal HashMapHelper<T>.Enumerator m_Enumerator;

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

		[NativeContainer]
		[NativeContainerIsReadOnly]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ReadOnly : IEnumerable<T>, IEnumerable
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe HashMapHelper<T>* m_Data;

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

			internal unsafe ReadOnly(ref NativeHashSet<T> data)
			{
				m_Data = null;
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

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			private readonly void CheckRead()
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe HashMapHelper<T>* m_Data;

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

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe NativeHashSet(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_Data = null;
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

		public void TrimExcess()
		{
		}

		public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<T>);
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
