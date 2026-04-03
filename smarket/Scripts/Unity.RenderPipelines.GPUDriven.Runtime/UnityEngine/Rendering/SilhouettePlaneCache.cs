using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal struct SilhouettePlaneCache : IDisposable
	{
		private struct Slot
		{
			public bool isActive;

			public int viewInstanceID;

			public int planeCount;

			public int lastUsedFrameIndex;

			public Slot(int viewInstanceID, int planeCount, int frameIndex)
			{
				isActive = false;
				this.viewInstanceID = 0;
				this.planeCount = 0;
				lastUsedFrameIndex = 0;
			}
		}

		private const int kMaxSilhouettePlanes = 6;

		private NativeParallelHashMap<int, int> m_SubviewIDToIndexMap;

		private NativeList<int> m_SlotFreeList;

		private NativeList<Slot> m_Slots;

		private NativeList<Plane> m_PlaneStorage;

		public void Init()
		{
		}

		public void Dispose()
		{
		}

		public void Update(int viewInstanceID, NativeArray<Plane> planes, int frameIndex)
		{
		}

		public void FreeUnusedSlots(int frameIndex, int maximumAge)
		{
		}

		public NativeArray<Plane> GetSubArray(int viewInstanceID)
		{
			return default(NativeArray<Plane>);
		}
	}
}
