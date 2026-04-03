using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	[NativeContainer]
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeRingQueueDebugView<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct NativeRingQueue<T> : INativeDisposable, IDisposable where T : struct
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeRingQueue<T>* m_RingQueue;

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

		public readonly int Length
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

		public unsafe NativeRingQueue(int capacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_RingQueue = null;
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public bool TryEnqueue(T value)
		{
			return false;
		}

		public void Enqueue(T value)
		{
		}

		public bool TryDequeue(out T item)
		{
			item = default(T);
			return false;
		}

		public T Dequeue()
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckRead()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckWrite()
		{
		}
	}
}
