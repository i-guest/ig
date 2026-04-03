using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool where Type : class
	{
		private struct ResourceLogInfo
		{
			public string name;

			public long size;
		}

		protected Dictionary<int, SortedList<int, (Type resource, int frameIndex)>> m_ResourcePool;

		private List<(int, Type)> m_FrameAllocatedResources;

		private const int kStaleResourceLifetime = 10;

		private static List<int> s_ToRemoveList;

		protected abstract void ReleaseInternalResource(Type res);

		protected abstract string GetResourceName(in Type res);

		protected abstract long GetResourceSize(in Type res);

		protected abstract string GetResourceTypeName();

		protected abstract int GetSortIndex(Type res);

		public void ReleaseResource(int hash, Type resource, int currentFrameIndex)
		{
		}

		public bool TryGetResource(int hashCode, out Type resource)
		{
			resource = null;
			return false;
		}

		public override void Cleanup()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void RegisterFrameAllocation(int hash, Type value)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void UnregisterFrameAllocation(int hash, Type value)
		{
		}

		public override void CheckFrameAllocation(bool onException, int frameIndex)
		{
		}

		public override void LogResources(RenderGraphLogger logger)
		{
		}

		public float GetMemorySizeInMB()
		{
			return 0f;
		}

		public int GetNumResourcesAvailable()
		{
			return 0;
		}

		public override void PurgeUnusedResources(int currentFrameIndex)
		{
		}
	}
}
