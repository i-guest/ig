using System;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(NativeSortExtension.DefaultComparer<int>)
	})]
	public struct SortJob<T, U> where T : struct
	{
		[BurstCompile]
		public struct SegmentSort : IJobParallelFor
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe T* Data;

			internal U Comp;

			internal int Length;

			internal int SegmentWidth;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile]
		public struct SegmentSortMerge : IJob
		{
			[NativeDisableUnsafePtrRestriction]
			internal unsafe T* Data;

			internal U Comp;

			internal int Length;

			internal int SegmentWidth;

			public void Execute()
			{
			}
		}

		public unsafe T* Data;

		public U Comp;

		public int Length;

		public JobHandle Schedule(JobHandle inputDeps = default(JobHandle))
		{
			return default(JobHandle);
		}
	}
}
