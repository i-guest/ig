using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal class LODGroupDataPool : IDisposable
	{
		private static class LodGroupShaderIDs
		{
			public static readonly int _SupportDitheringCrossFade;

			public static readonly int _LodGroupCullingDataGPUByteSize;

			public static readonly int _LodGroupCullingDataStartOffset;

			public static readonly int _LodCullingDataQueueCount;

			public static readonly int _InputLodCullingDataIndices;

			public static readonly int _InputLodCullingDataBuffer;

			public static readonly int _LodGroupCullingData;
		}

		private NativeList<LODGroupData> m_LODGroupData;

		private NativeParallelHashMap<int, GPUInstanceIndex> m_LODGroupDataHash;

		private NativeList<LODGroupCullingData> m_LODGroupCullingData;

		private NativeList<GPUInstanceIndex> m_FreeLODGroupDataHandles;

		private int m_CrossfadedRendererCount;

		private bool m_SupportDitheringCrossFade;

		public NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash => default(NativeParallelHashMap<int, GPUInstanceIndex>);

		public NativeList<LODGroupCullingData> lodGroupCullingData => default(NativeList<LODGroupCullingData>);

		public int crossfadedRendererCount => 0;

		public int activeLodGroupCount => 0;

		public LODGroupDataPool(GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade)
		{
		}

		public void Dispose()
		{
		}

		public void UpdateLODGroupTransformData(in GPUDrivenLODGroupData inputData)
		{
		}

		public void UpdateLODGroupData(in GPUDrivenLODGroupData inputData)
		{
		}

		public void FreeLODGroupData(NativeArray<EntityId> destroyedLODGroupsID)
		{
		}
	}
}
