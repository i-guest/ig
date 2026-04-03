using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
	public static class IJobParallelForDeferExtensions
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		internal struct JobParallelForDeferProducer<T> where T : struct, IJobParallelForDefer
		{
			public delegate void ExecuteJobFunction(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

			internal static readonly SharedStatic<IntPtr> jobReflectionData;

			[BurstDiscard]
			internal static void Initialize()
			{
			}

			public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
			}
		}

		public static void EarlyJobInit<T>() where T : struct, IJobParallelForDefer
		{
		}

		public static JobHandle Schedule<T, U>(this T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer where U : struct
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleByRef<T, U>(this ref T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer where U : struct
		{
			return default(JobHandle);
		}

		public unsafe static JobHandle Schedule<T>(this T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer
		{
			return default(JobHandle);
		}

		public unsafe static JobHandle ScheduleByRef<T>(this ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForDefer
		{
			return default(JobHandle);
		}

		private unsafe static JobHandle ScheduleInternal<T>(ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn) where T : struct, IJobParallelForDefer
		{
			return default(JobHandle);
		}
	}
}
