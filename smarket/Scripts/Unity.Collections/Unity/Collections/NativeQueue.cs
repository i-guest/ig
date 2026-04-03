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
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct NativeQueue<T> : INativeDisposable, IDisposable where T : struct
	{
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			internal UnsafeQueue<T>.Enumerator m_Enumerator;

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
		public struct ReadOnly : IEnumerable<T>, IEnumerable
		{
			private UnsafeQueue<T>.ReadOnly m_ReadOnly;

			public readonly bool IsCreated
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return false;
				}
			}

			public readonly int Count => 0;

			public readonly T this[int index] => default(T);

			internal ReadOnly(ref NativeQueue<T> data)
			{
				m_ReadOnly = default(UnsafeQueue<T>.ReadOnly);
			}

			public readonly bool IsEmpty()
			{
				return false;
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

		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelWriter
		{
			internal UnsafeQueue<T>.ParallelWriter unsafeWriter;

			public void Enqueue(T value)
			{
			}

			public void Enqueue(T value, int threadIndexOverride)
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		private unsafe UnsafeQueue<T>* m_Queue;

		public readonly int Count => 0;

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe NativeQueue(AllocatorManager.AllocatorHandle allocator)
		{
			m_Queue = null;
		}

		public readonly bool IsEmpty()
		{
			return false;
		}

		public T Peek()
		{
			return default(T);
		}

		public void Enqueue(T value)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}

		public bool TryDequeue(out T item)
		{
			item = default(T);
			return false;
		}

		public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<T>);
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}

		public ParallelWriter AsParallelWriter()
		{
			return default(ParallelWriter);
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
