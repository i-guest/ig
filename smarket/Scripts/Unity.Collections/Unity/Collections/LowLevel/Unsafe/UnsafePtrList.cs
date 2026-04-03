using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafePtrListDebugView<>))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct UnsafePtrList<T> : INativeDisposable, IDisposable, IEnumerable<IntPtr>, IEnumerable where T : unmanaged
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ReadOnly
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe readonly T** Ptr;

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

			internal unsafe ReadOnly(T** ptr, int length)
			{
				Ptr = null;
				Length = 0;
			}

			public unsafe int IndexOf(void* ptr)
			{
				return 0;
			}

			public unsafe bool Contains(void* ptr)
			{
				return false;
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelReader
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe readonly T** Ptr;

			public readonly int Length;

			internal unsafe ParallelReader(T** ptr, int length)
			{
				Ptr = null;
				Length = 0;
			}

			public unsafe int IndexOf(void* ptr)
			{
				return 0;
			}

			public unsafe bool Contains(void* ptr)
			{
				return false;
			}
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct ParallelWriter
		{
			[NativeDisableUnsafePtrRestriction]
			public unsafe readonly T** Ptr;

			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<IntPtr>* ListData;

			internal unsafe ParallelWriter(T** ptr, UnsafeList<IntPtr>* listData)
			{
				Ptr = null;
				ListData = null;
			}

			public unsafe void AddNoResize(T* value)
			{
			}

			public unsafe void AddRangeNoResize(T** ptr, int count)
			{
			}

			public void AddRangeNoResize(UnsafePtrList<T> list)
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly T** Ptr;

		public readonly int m_length;

		public readonly int m_capacity;

		public readonly AllocatorManager.AllocatorHandle Allocator;

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

		public unsafe T* this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
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
		public unsafe ref T* ElementAt(int index)
		{
			throw null;
		}

		public unsafe UnsafePtrList(T** ptr, int length)
		{
			Ptr = null;
			m_length = 0;
			m_capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
			padding = 0;
		}

		public unsafe UnsafePtrList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
			Ptr = null;
			m_length = 0;
			m_capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
			padding = 0;
		}

		public unsafe static UnsafePtrList<T>* Create(T** ptr, int length)
		{
			return null;
		}

		public unsafe static UnsafePtrList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
		{
			return null;
		}

		public unsafe static void Destroy(UnsafePtrList<T>* listData)
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

		public void SetCapacity(int capacity)
		{
		}

		public void TrimExcess()
		{
		}

		public unsafe int IndexOf(void* ptr)
		{
			return 0;
		}

		public unsafe bool Contains(void* ptr)
		{
			return false;
		}

		public unsafe void AddNoResize(void* value)
		{
		}

		public unsafe void AddRangeNoResize(void** ptr, int count)
		{
		}

		public void AddRangeNoResize(UnsafePtrList<T> list)
		{
		}

		public void Add(in IntPtr value)
		{
		}

		public unsafe void Add(void* value)
		{
		}

		public unsafe void AddRange(void* ptr, int length)
		{
		}

		public void AddRange(UnsafePtrList<T> list)
		{
		}

		public void InsertRangeWithBeginEnd(int begin, int end)
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
		{
			return null;
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
	}
}
