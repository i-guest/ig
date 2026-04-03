using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeListTDebugView<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct UnsafeList<T> : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable where T : unmanaged
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ReadOnly : IEnumerable<T>, IEnumerable
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe readonly T* Ptr;

			public readonly int Length;

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

			internal unsafe ReadOnly(T* ptr, int length)
			{
				Ptr = null;
				Length = 0;
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelReader
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe readonly T* Ptr;

			public readonly int Length;

			internal unsafe ParallelReader(T* ptr, int length)
			{
				Ptr = null;
				Length = 0;
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelWriter
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<T>* ListData;

			public unsafe readonly void* Ptr
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return null;
				}
			}

			internal unsafe ParallelWriter(UnsafeList<T>* listData)
			{
				ListData = null;
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public void AddNoResize(T value)
			{
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public unsafe void AddRangeNoResize(void* ptr, int count)
			{
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public void AddRangeNoResize(UnsafeList<T> list)
			{
			}
		}

		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			internal unsafe T* m_Ptr;

			internal int m_Length;

			internal int m_Index;

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

		[NativeDisableUnsafePtrRestriction]
		public unsafe T* Ptr;

		public int m_length;

		public int m_capacity;

		public AllocatorManager.AllocatorHandle Allocator;

		private readonly int padding;

		public int Length
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

		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(T);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
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

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref T ElementAt(int index)
		{
			throw null;
		}

		public unsafe UnsafeList(T* ptr, int length)
		{
			Ptr = null;
			m_length = 0;
			m_capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
			padding = 0;
		}

		public unsafe UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
			Ptr = null;
			m_length = 0;
			m_capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
			padding = 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal unsafe static UnsafeList<T>* Create<U>(int initialCapacity, ref U allocator, NativeArrayOptions options) where U : struct
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal unsafe static void Destroy<U>(UnsafeList<T>* listData, ref U allocator) where U : struct
		{
		}

		public unsafe static UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
			return null;
		}

		public unsafe static void Destroy(UnsafeList<T>* listData)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal void Dispose<U>(ref U allocator) where U : struct
		{
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

		public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
		}

		private void ResizeExact<U>(ref U allocator, int newCapacity) where U : struct
		{
		}

		private void ResizeExact(int capacity)
		{
		}

		private void SetCapacity<U>(ref U allocator, int capacity) where U : struct
		{
		}

		public void SetCapacity(int capacity)
		{
		}

		public void TrimExcess()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddNoResize(T value)
		{
		}

		public unsafe void AddRangeNoResize(void* ptr, int count)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public void AddRangeNoResize(UnsafeList<T> list)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(in T value)
		{
		}

		public unsafe void AddRange(void* ptr, int count)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public void AddRange(UnsafeList<T> list)
		{
		}

		public void AddReplicate(in T value, int count)
		{
		}

		public void InsertRangeWithBeginEnd(int begin, int end)
		{
		}

		public void InsertRange(int index, int count)
		{
		}

		public void RemoveAtSwapBack(int index)
		{
		}

		public void RemoveRangeSwapBack(int index, int count)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}

		public ParallelReader AsParallelReader()
		{
			return default(ParallelReader);
		}

		public ParallelWriter AsParallelWriter()
		{
			return default(ParallelWriter);
		}

		public void CopyFrom(in NativeArray<T> other)
		{
		}

		public void CopyFrom(in UnsafeList<T> other)
		{
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal unsafe static void CheckNull(void* listData)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckIndexCount(int index, int count)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBeginEndNoLength(int begin, int end)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckBeginEnd(int begin, int end)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckNoResizeHasEnoughCapacity(int length)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckNoResizeHasEnoughCapacity(int length, int index)
		{
		}
	}
}
