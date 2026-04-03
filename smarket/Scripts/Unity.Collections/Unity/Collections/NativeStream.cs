using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	[NativeContainer]
	[GenerateTestsForBurstCompatibility]
	public struct NativeStream : INativeDisposable, IDisposable
	{
		[BurstCompile]
		private struct ConstructJobList : IJob
		{
			public NativeStream Container;

			[ReadOnly]
			[NativeDisableUnsafePtrRestriction]
			public unsafe UntypedUnsafeList* List;

			public void Execute()
			{
			}
		}

		[BurstCompile]
		private struct ConstructJob : IJob
		{
			public NativeStream Container;

			[ReadOnly]
			public NativeArray<int> Length;

			public void Execute()
			{
			}
		}

		[NativeContainer]
		[NativeContainerSupportsMinMaxWriteRestriction]
		[GenerateTestsForBurstCompatibility]
		public struct Writer
		{
			private UnsafeStream.Writer m_Writer;

			public int ForEachCount => 0;

			internal Writer(ref NativeStream stream)
			{
				m_Writer = default(UnsafeStream.Writer);
			}

			public void PatchMinMaxRange(int foreEachIndex)
			{
			}

			public void BeginForEachIndex(int foreachIndex)
			{
			}

			public void EndForEachIndex()
			{
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public void Write<T>(T value) where T : struct
			{
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public ref T Allocate<T>() where T : struct
			{
				throw null;
			}

			public unsafe byte* Allocate(int size)
			{
				return null;
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckBeginForEachIndex(int foreachIndex)
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckEndForEachIndex()
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckAllocateSize(int size)
			{
			}
		}

		[NativeContainer]
		[NativeContainerIsReadOnly]
		[GenerateTestsForBurstCompatibility]
		public struct Reader
		{
			private UnsafeStream.Reader m_Reader;

			public int ForEachCount => 0;

			public int RemainingItemCount => 0;

			internal Reader(ref NativeStream stream)
			{
				m_Reader = default(UnsafeStream.Reader);
			}

			public int BeginForEachIndex(int foreachIndex)
			{
				return 0;
			}

			public void EndForEachIndex()
			{
			}

			public unsafe byte* ReadUnsafePtr(int size)
			{
				return null;
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public ref T Read<T>() where T : struct
			{
				throw null;
			}

			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
			public ref T Peek<T>() where T : struct
			{
				throw null;
			}

			public int Count()
			{
				return 0;
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckNotReadingOutOfBounds(int size)
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			private void CheckRead()
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckReadSize(int size)
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckBeginForEachIndex(int forEachIndex)
			{
			}

			[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
			[Conditional("UNITY_DOTS_DEBUG")]
			private void CheckEndForEachIndex()
			{
			}
		}

		private UnsafeStream m_Stream;

		public readonly bool IsCreated
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public readonly int ForEachCount => 0;

		public NativeStream(int bufferCount, AllocatorManager.AllocatorHandle allocator)
		{
			m_Stream = default(UnsafeStream);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static JobHandle ScheduleConstruct<T>(out NativeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
			stream = default(NativeStream);
			return default(JobHandle);
		}

		public static JobHandle ScheduleConstruct(out NativeStream stream, NativeArray<int> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator)
		{
			stream = default(NativeStream);
			return default(JobHandle);
		}

		public readonly bool IsEmpty()
		{
			return false;
		}

		public Reader AsReader()
		{
			return default(Reader);
		}

		public Writer AsWriter()
		{
			return default(Writer);
		}

		public int Count()
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public NativeArray<T> ToNativeArray<T>(AllocatorManager.AllocatorHandle allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		private static void AllocateBlock(out NativeStream stream, AllocatorManager.AllocatorHandle allocator)
		{
			stream = default(NativeStream);
		}

		private void AllocateForEach(int forEachCount)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckForEachCountGreaterThanZero(int forEachCount)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private readonly void CheckRead()
		{
		}
	}
}
