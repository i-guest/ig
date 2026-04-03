using System;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	internal struct InstanceCullerSplitDebugArray : IDisposable
	{
		internal struct Info
		{
			public BatchCullingViewType viewType;

			public int viewInstanceID;

			public int splitIndex;
		}

		private const int MaxSplitCount = 64;

		private NativeList<Info> m_Info;

		private NativeArray<int> m_Counters;

		private NativeQueue<JobHandle> m_CounterSync;

		public NativeArray<int> Counters => default(NativeArray<int>);

		public void Init()
		{
		}

		public void Dispose()
		{
		}

		public int TryAddSplits(BatchCullingViewType viewType, int viewInstanceID, int splitCount)
		{
			return 0;
		}

		public void AddSync(int baseIndex, JobHandle jobHandle)
		{
		}

		public void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats)
		{
		}
	}
}
