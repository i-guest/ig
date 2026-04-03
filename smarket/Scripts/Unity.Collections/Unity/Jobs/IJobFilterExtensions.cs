using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
	public static class IJobFilterExtensions
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		internal struct JobFilterProducer<T> where T : struct, IJobFilter
		{
			public struct JobWrapper
			{
				[NativeDisableParallelForRestriction]
				public NativeList<int> outputIndices;

				public int appendCount;

				public T JobData;
			}

			public delegate void ExecuteJobFunction(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

			internal static readonly SharedStatic<IntPtr> jobReflectionData;

			[BurstDiscard]
			internal static void Initialize()
			{
			}

			public static void Execute(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
			}

			public static void ExecuteAppend(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData)
			{
			}

			public static void ExecuteFilter(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData)
			{
			}
		}

		public static void EarlyJobInit<T>() where T : struct, IJobFilter
		{
		}

		private static IntPtr GetReflectionData<T>() where T : struct, IJobFilter
		{
			return (IntPtr)0;
		}

		public static JobHandle ScheduleAppend<T>(this T jobData, NativeList<int> indices, int arrayLength, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobFilter
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleFilter<T>(this T jobData, NativeList<int> indices, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobFilter
		{
			return default(JobHandle);
		}

		public static void RunAppend<T>(this T jobData, NativeList<int> indices, int arrayLength) where T : struct, IJobFilter
		{
		}

		public static void RunFilter<T>(this T jobData, NativeList<int> indices) where T : struct, IJobFilter
		{
		}

		public static JobHandle ScheduleAppendByRef<T>(this ref T jobData, NativeList<int> indices, int arrayLength, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobFilter
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleFilterByRef<T>(this ref T jobData, NativeList<int> indices, JobHandle dependsOn = default(JobHandle)) where T : struct, IJobFilter
		{
			return default(JobHandle);
		}

		public static void RunAppendByRef<T>(this ref T jobData, NativeList<int> indices, int arrayLength) where T : struct, IJobFilter
		{
		}

		public static void RunFilterByRef<T>(this ref T jobData, NativeList<int> indices) where T : struct, IJobFilter
		{
		}
	}
}
