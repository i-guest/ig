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
	public struct SortJobDefer<T, U> where T : struct
	{
		[BurstCompile]
		public struct SegmentSort : IJobParallelForDefer
		{
			[ReadOnly]
			internal NativeList<T> DataRO;

			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeList<T>* Data;

			internal U Comp;

			internal int SegmentWidth;

			public void Execute(int index)
			{
			}
		}

		[BurstCompile]
		public struct SegmentSortMerge : IJob
		{
			[NativeDisableUnsafePtrRestriction]
			internal NativeList<T> Data;

			internal U Comp;

			internal int SegmentWidth;

			public void Execute()
			{
			}
		}

		public NativeList<T> Data;

		public U Comp;

		public JobHandle Schedule(JobHandle inputDeps = default(JobHandle))
		{
			return default(JobHandle);
		}
	}
}
