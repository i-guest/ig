using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	internal struct InstanceOcclusionEventDebugArray : IDisposable
	{
		internal struct Info
		{
			public int viewInstanceID;

			public InstanceOcclusionEventType eventType;

			public int occluderVersion;

			public int subviewMask;

			public OcclusionTest occlusionTest;

			public bool HasVersion()
			{
				return false;
			}
		}

		internal struct Request
		{
			public UnsafeList<Info> info;

			public AsyncGPUReadbackRequest readback;
		}

		private const int InitialPassCount = 4;

		private const int MaxPassCount = 64;

		private GraphicsBuffer m_CounterBuffer;

		private UnsafeList<Info> m_PendingInfo;

		private NativeQueue<Request> m_Requests;

		private UnsafeList<Info> m_LatestInfo;

		private NativeArray<int> m_LatestCounters;

		private bool m_HasLatest;

		public GraphicsBuffer CounterBuffer => null;

		public void Init()
		{
		}

		public void Dispose()
		{
		}

		public int TryAdd(int viewInstanceID, InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, OcclusionTest occlusionTest)
		{
			return 0;
		}

		public void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats)
		{
		}
	}
}
