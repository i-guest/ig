using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public struct UnsafeAppendBuffer : INativeDisposable, IDisposable
	{
		[GenerateTestsForBurstCompatibility]
		public struct Reader
		{
			public unsafe readonly byte* Ptr;

			public readonly int Size;

			public int Offset;

			public bool EndOfBuffer => false;

			public unsafe Reader(ref UnsafeAppendBuffer buffer)
			{
				Ptr = null;
				Size = 0;
				Offset = 0;
			}

			public unsafe Reader(void* ptr, int length)
			{
				Ptr = null;
				Size = 0;
				Offset = 0;
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public void ReadNext<T>(out T value) where T : struct
			{
				value = default(T);
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public T ReadNext<T>() where T : struct
			{
				return default(T);
			}

			public unsafe void* ReadNext(int structSize)
			{
				return null;
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public void ReadNext<T>(out NativeArray<T> value, AllocatorManager.AllocatorHandle allocator) where T : struct
			{
				value = default(NativeArray<T>);
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public unsafe void* ReadNextArray<T>(out int length) where T : struct
			{
				length = default(int);
				return null;
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckBounds(int structSize)
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		public unsafe byte* Ptr;

		public int Length;

		public int Capacity;

		public AllocatorManager.AllocatorHandle Allocator;

		public readonly int Alignment;

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

		public unsafe UnsafeAppendBuffer(int initialCapacity, int alignment, AllocatorManager.AllocatorHandle allocator)
		{
			Ptr = null;
			Length = 0;
			Capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
			Alignment = 0;
		}

		public unsafe UnsafeAppendBuffer(void* ptr, int length)
		{
			Ptr = null;
			Length = 0;
			Capacity = 0;
			Allocator = default(AllocatorManager.AllocatorHandle);
			Alignment = 0;
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		public void Reset()
		{
		}

		public void SetCapacity(int capacity)
		{
		}

		public void ResizeUninitialized(int length)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public void Add<T>(T value) where T : struct
		{
		}

		public unsafe void Add(void* ptr, int structSize)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe void AddArray<T>(void* ptr, int length) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public void Add<T>(NativeArray<T> value) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public T Pop<T>() where T : struct
		{
			return default(T);
		}

		public unsafe void Pop(void* ptr, int structSize)
		{
		}

		public Reader AsReader()
		{
			return default(Reader);
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckAlignment(int alignment)
		{
		}
	}
}
