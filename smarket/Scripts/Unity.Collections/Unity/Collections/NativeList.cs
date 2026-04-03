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
	[DebuggerDisplay("Length = {m_ListData == null ? default : m_ListData->Length}, Capacity = {m_ListData == null ? default : m_ListData->Capacity}")]
	[DebuggerTypeProxy(typeof(NativeListDebugView<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct NativeList<T> : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable where T : struct
	{
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
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

			public void AddNoResize(T value)
			{
			}

			public unsafe void AddRangeNoResize(void* ptr, int count)
			{
			}

			public void AddRangeNoResize(UnsafeList<T> list)
			{
			}

			public void AddRangeNoResize(NativeList<T> list)
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<T>* m_ListData;

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

		public unsafe NativeList(AllocatorManager.AllocatorHandle allocator)
		{
			m_ListData = null;
		}

		public unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
		{
			m_ListData = null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal void Initialize<U>(int initialCapacity, ref U allocator) where U : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal static NativeList<T> New<U>(int initialCapacity, ref U allocator) where U : struct
		{
			return default(NativeList<T>);
		}

		public ref T ElementAt(int index)
		{
			throw null;
		}

		public unsafe UnsafeList<T>* GetUnsafeList()
		{
			return null;
		}

		public void AddNoResize(T value)
		{
		}

		public unsafe void AddRangeNoResize(void* ptr, int count)
		{
		}

		public void AddRangeNoResize(NativeList<T> list)
		{
		}

		public void Add(in T value)
		{
		}

		public void AddRange(NativeArray<T> array)
		{
		}

		public unsafe void AddRange(void* ptr, int count)
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

		public void Dispose()
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
		internal void Dispose<U>(ref U allocator) where U : struct
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public void Clear()
		{
		}

		[Obsolete("Implicit cast from `NativeList<T>` to `NativeArray<T>` has been deprecated; Use '.AsArray()' method to do explicit cast instead.", false)]
		public static implicit operator NativeArray<T>(NativeList<T> nativeList)
		{
			return default(NativeArray<T>);
		}

		public NativeArray<T> AsArray()
		{
			return default(NativeArray<T>);
		}

		public NativeArray<T> AsDeferredJobArray()
		{
			return default(NativeArray<T>);
		}

		public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator)
		{
			return default(NativeArray<T>);
		}

		public void CopyFrom(in NativeArray<T> other)
		{
		}

		public void CopyFrom(in UnsafeList<T> other)
		{
		}

		public void CopyFrom(in NativeList<T> other)
		{
		}

		public NativeArray<T>.Enumerator GetEnumerator()
		{
			return default(NativeArray<T>.Enumerator);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		public void Resize(int length, NativeArrayOptions options)
		{
		}

		public void ResizeUninitialized(int length)
		{
		}

		public void SetCapacity(int capacity)
		{
		}

		public void TrimExcess()
		{
		}

		public NativeArray<T>.ReadOnly AsReadOnly()
		{
			return default(NativeArray<T>.ReadOnly);
		}

		public NativeArray<T>.ReadOnly AsParallelReader()
		{
			return default(NativeArray<T>.ReadOnly);
		}

		public ParallelWriter AsParallelWriter()
		{
			return default(ParallelWriter);
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckInitialCapacity(int initialCapacity)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckTotalSize(int initialCapacity, long totalSize)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckSufficientCapacity(int capacity, int length)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckIndexInRange(int value, int length)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckArgPositive(int value)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckHandleMatches(AllocatorManager.AllocatorHandle handle)
		{
		}
	}
}
