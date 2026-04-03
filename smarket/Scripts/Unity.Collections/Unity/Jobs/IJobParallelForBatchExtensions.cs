using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
	public static class IJobParallelForBatchExtensions
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		internal struct JobParallelForBatchProducer<T> where T : struct, IJobParallelForBatch
		{
			internal delegate void ExecuteJobFunction(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

			internal static readonly SharedStatic<IntPtr> jobReflectionData;

			[BurstDiscard]
			internal static void Initialize()
			{
			}

			public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
			}
		}

		public static void EarlyJobInit<T>() where T : struct, IJobParallelForBatch
		{
		}

		private static IntPtr GetReflectionData<T>() where T : struct, IJobParallelForBatch
		{
			return (IntPtr)0;
		}

		public static JobHandle Schedule<T>(this T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBatch
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleByRef<T>(this ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBatch
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleParallel<T>(this T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBatch
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleParallelByRef<T>(this ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBatch
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleBatch<T>(this T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBatch
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleBatchByRef<T>(this ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobParallelForBatch
		{
			return default(JobHandle);
		}

		public static void Run<T>(this T jobData, int arrayLength, int indicesPerJobCount) where T : struct, IJobParallelForBatch
		{
		}

		public static void RunByRef<T>(this ref T jobData, int arrayLength, int indicesPerJobCount) where T : struct, IJobParallelForBatch
		{
		}

		public static void RunBatch<T>(this T jobData, int arrayLength) where T : struct, IJobParallelForBatch
		{
		}

		public static void RunBatchByRef<T>(this ref T jobData, int arrayLength) where T : struct, IJobParallelForBatch
		{
		}
	}
}
