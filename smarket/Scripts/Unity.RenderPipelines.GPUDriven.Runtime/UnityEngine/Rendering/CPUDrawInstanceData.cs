using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal class CPUDrawInstanceData
	{
		private NativeParallelHashMap<RangeKey, int> m_RangeHash;

		private NativeList<DrawRange> m_DrawRanges;

		private NativeParallelHashMap<DrawKey, int> m_BatchHash;

		private NativeList<DrawBatch> m_DrawBatches;

		private NativeList<DrawInstance> m_DrawInstances;

		private NativeList<int> m_DrawInstanceIndices;

		private NativeList<int> m_DrawBatchIndices;

		private bool m_NeedsRebuild;

		public NativeList<DrawInstance> drawInstances => default(NativeList<DrawInstance>);

		public NativeParallelHashMap<DrawKey, int> batchHash => default(NativeParallelHashMap<DrawKey, int>);

		public NativeList<DrawBatch> drawBatches => default(NativeList<DrawBatch>);

		public NativeParallelHashMap<RangeKey, int> rangeHash => default(NativeParallelHashMap<RangeKey, int>);

		public NativeList<DrawRange> drawRanges => default(NativeList<DrawRange>);

		public NativeArray<int> drawBatchIndices => default(NativeArray<int>);

		public NativeArray<int> drawInstanceIndices => default(NativeArray<int>);

		public bool valid => false;

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void RebuildDrawListsIfNeeded()
		{
		}

		public void DestroyDrawInstanceIndices(NativeArray<int> drawInstanceIndicesToDestroy)
		{
		}

		public void DestroyDrawInstances(NativeArray<InstanceHandle> destroyedInstances)
		{
		}

		public void DestroyMaterialDrawInstances(NativeArray<uint> destroyedBatchMaterials)
		{
		}

		public void NeedsRebuild()
		{
		}
	}
}
