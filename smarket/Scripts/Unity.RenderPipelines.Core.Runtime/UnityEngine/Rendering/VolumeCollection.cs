using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	internal class VolumeCollection
	{
		internal const int k_MaxLayerCount = 32;

		private readonly Dictionary<int, List<Volume>> m_SortedVolumes;

		private readonly List<Volume> m_Volumes;

		private readonly Dictionary<int, bool> m_SortNeeded;

		public int count => 0;

		public bool Register(Volume volume, int layer)
		{
			return false;
		}

		public bool Unregister(Volume volume, int layer)
		{
			return false;
		}

		public bool ChangeLayer(Volume volume, int previousLayerIndex, int currentLayerIndex)
		{
			return false;
		}

		internal static void SortByPriority(List<Volume> volumes)
		{
		}

		public List<Volume> GrabVolumes(LayerMask mask)
		{
			return null;
		}

		public void SetLayerIndexDirty(int layerIndex)
		{
		}

		public bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent
		{
			return false;
		}
	}
}
