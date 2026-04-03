using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct UnsafeQueue<T> : INativeDisposable, IDisposable where T : struct
	{
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeQueueBlockHeader* m_FirstBlock;

			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeQueueBlockHeader* m_Block;

			internal int m_Index;

			private T value;

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

		public struct ReadOnly : IEnumerable<T>, IEnumerable
		{
			[NativeDisableUnsafePtrRestriction]
			private unsafe UnsafeQueueData* m_Buffer;

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

			internal unsafe ReadOnly(ref UnsafeQueue<T> data)
			{
				m_Buffer = null;
			}

			public readonly bool IsEmpty()
			{
				return false;
			}

			private readonly bool TryGetValue(int index, out T item)
			{
				item = default(T);
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
			[Conditional("UNITY_DOTS_DEBUG")]
			private readonly void ThrowIndexOutOfRangeException(int index)
			{
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelWriter
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeQueueData* m_Buffer;

			internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

			[NativeSetThreadIndex]
			internal int m_ThreadIndex;

			public void Enqueue(T value)
			{
			}

			public void Enqueue(T value, int threadIndexOverride)
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeQueueData* m_Buffer;

		[NativeDisableUnsafePtrRestriction]
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

		public readonly int Count => 0;

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe UnsafeQueue(AllocatorManager.AllocatorHandle allocator)
		{
			m_Buffer = null;
			m_AllocatorLabel = default(AllocatorManager.AllocatorHandle);
		}

		internal unsafe static UnsafeQueue<T>* Alloc(AllocatorManager.AllocatorHandle allocator)
		{
			return null;
		}

		internal unsafe static void Free(UnsafeQueue<T>* data)
		{
		}

		public readonly bool IsEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckNotEmpty()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void ThrowEmpty()
		{
		}
	}
}
