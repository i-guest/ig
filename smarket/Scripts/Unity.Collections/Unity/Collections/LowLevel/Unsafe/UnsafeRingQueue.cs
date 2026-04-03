using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeRingQueueDebugView<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct UnsafeRingQueue<T> : INativeDisposable, IDisposable where T : unmanaged
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe T* Ptr;

		public AllocatorManager.AllocatorHandle Allocator;

		internal readonly int m_Capacity;

		internal int m_Filled;

		internal int m_Write;

		internal int m_Read;

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

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public unsafe UnsafeRingQueue(T* ptr, int capacity)
		{
			Ptr = null;
			Allocator = default(AllocatorManager.AllocatorHandle);
			m_Capacity = 0;
			m_Filled = 0;
			m_Write = 0;
			m_Read = 0;
		}

		public unsafe UnsafeRingQueue(int capacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			Ptr = null;
			Allocator = default(AllocatorManager.AllocatorHandle);
			m_Capacity = 0;
			m_Filled = 0;
			m_Write = 0;
			m_Read = 0;
		}

		internal unsafe static UnsafeRingQueue<T>* Alloc(AllocatorManager.AllocatorHandle allocator)
		{
			return null;
		}

		internal unsafe static void Free(UnsafeRingQueue<T>* data)
		{
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryEnqueueInternal(T value)
		{
			return false;
		}

		public bool TryEnqueue(T value)
		{
			return false;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void ThrowQueueFull()
		{
		}

		public void Enqueue(T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryDequeueInternal(out T item)
		{
			item = default(T);
			return false;
		}

		public bool TryDequeue(out T item)
		{
			item = default(T);
			return false;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void ThrowQueueEmpty()
		{
		}

		public T Dequeue()
		{
			return default(T);
		}
	}
}
