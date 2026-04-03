using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal struct CPUSharedInstanceData : IDisposable
	{
		internal readonly struct ReadOnly
		{
			public readonly NativeArray<int>.ReadOnly instanceIndices;

			public readonly NativeArray<SharedInstanceHandle>.ReadOnly instances;

			public readonly NativeArray<EntityId>.ReadOnly rendererGroupIDs;

			public readonly NativeArray<SmallEntityIdArray>.ReadOnly materialIDArrays;

			public readonly NativeArray<EntityId>.ReadOnly meshIDs;

			public readonly NativeArray<AABB>.ReadOnly localAABBs;

			public readonly NativeArray<CPUSharedInstanceFlags>.ReadOnly flags;

			public readonly NativeArray<uint>.ReadOnly lodGroupAndMasks;

			public readonly NativeArray<GPUDrivenMeshLodInfo>.ReadOnly meshLodInfos;

			public readonly NativeArray<int>.ReadOnly gameObjectLayers;

			public readonly NativeArray<int>.ReadOnly refCounts;

			public int handlesLength => 0;

			public int instancesLength => 0;

			public ReadOnly(in CPUSharedInstanceData instanceData)
			{
				instanceIndices = default(NativeArray<int>.ReadOnly);
				instances = default(NativeArray<SharedInstanceHandle>.ReadOnly);
				rendererGroupIDs = default(NativeArray<EntityId>.ReadOnly);
				materialIDArrays = default(NativeArray<SmallEntityIdArray>.ReadOnly);
				meshIDs = default(NativeArray<EntityId>.ReadOnly);
				localAABBs = default(NativeArray<AABB>.ReadOnly);
				flags = default(NativeArray<CPUSharedInstanceFlags>.ReadOnly);
				lodGroupAndMasks = default(NativeArray<uint>.ReadOnly);
				meshLodInfos = default(NativeArray<GPUDrivenMeshLodInfo>.ReadOnly);
				gameObjectLayers = default(NativeArray<int>.ReadOnly);
				refCounts = default(NativeArray<int>.ReadOnly);
			}

			public int SharedInstanceToIndex(SharedInstanceHandle instance)
			{
				return 0;
			}

			public SharedInstanceHandle IndexToSharedInstance(int index)
			{
				return default(SharedInstanceHandle);
			}

			public bool IsValidSharedInstance(SharedInstanceHandle instance)
			{
				return false;
			}

			public bool IsValidIndex(int index)
			{
				return false;
			}

			public int InstanceToIndex(in CPUInstanceData.ReadOnly instanceData, InstanceHandle instance)
			{
				return 0;
			}
		}

		private const int k_InvalidIndex = -1;

		private const uint k_InvalidLODGroupAndMask = 4294967295u;

		private NativeArray<int> m_StructData;

		private NativeList<int> m_InstanceIndices;

		public NativeArray<SharedInstanceHandle> instances;

		public NativeArray<EntityId> rendererGroupIDs;

		public NativeArray<SmallEntityIdArray> materialIDArrays;

		public NativeArray<EntityId> meshIDs;

		public NativeArray<AABB> localAABBs;

		public NativeArray<CPUSharedInstanceFlags> flags;

		public NativeArray<uint> lodGroupAndMasks;

		public NativeArray<GPUDrivenMeshLodInfo> meshLodInfos;

		public NativeArray<int> gameObjectLayers;

		public NativeArray<int> refCounts;

		public int instancesLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int instancesCapacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int handlesLength => 0;

		public void Initialize(int initCapacity)
		{
		}

		public void Dispose()
		{
		}

		private void Grow(int newCapacity)
		{
		}

		private void AddUnsafe(SharedInstanceHandle instance)
		{
		}

		public int SharedInstanceToIndex(SharedInstanceHandle instance)
		{
			return 0;
		}

		public SharedInstanceHandle IndexToSharedInstance(int index)
		{
			return default(SharedInstanceHandle);
		}

		public int InstanceToIndex(in CPUInstanceData instanceData, InstanceHandle instance)
		{
			return 0;
		}

		public bool IsValidInstance(SharedInstanceHandle instance)
		{
			return false;
		}

		public bool IsFreeInstanceHandle(SharedInstanceHandle instance)
		{
			return false;
		}

		public bool IsValidIndex(int index)
		{
			return false;
		}

		public int GetFreeInstancesCount()
		{
			return 0;
		}

		public void EnsureFreeInstances(int instancesCount)
		{
		}

		public void AddNoGrow(SharedInstanceHandle instance)
		{
		}

		public void Add(SharedInstanceHandle instance)
		{
		}

		public void Remove(SharedInstanceHandle instance)
		{
		}

		public int Get_RendererGroupID(SharedInstanceHandle instance)
		{
			return 0;
		}

		public int Get_MeshID(SharedInstanceHandle instance)
		{
			return 0;
		}

		public ref AABB Get_LocalAABB(SharedInstanceHandle instance)
		{
			throw null;
		}

		public CPUSharedInstanceFlags Get_Flags(SharedInstanceHandle instance)
		{
			return default(CPUSharedInstanceFlags);
		}

		public uint Get_LODGroupAndMask(SharedInstanceHandle instance)
		{
			return 0u;
		}

		public int Get_GameObjectLayer(SharedInstanceHandle instance)
		{
			return 0;
		}

		public int Get_RefCount(SharedInstanceHandle instance)
		{
			return 0;
		}

		public ref SmallEntityIdArray Get_MaterialIDs(SharedInstanceHandle instance)
		{
			throw null;
		}

		public void Set_RendererGroupID(SharedInstanceHandle instance, int rendererGroupID)
		{
		}

		public void Set_MeshID(SharedInstanceHandle instance, int meshID)
		{
		}

		public void Set_LocalAABB(SharedInstanceHandle instance, in AABB localAABB)
		{
		}

		public void Set_Flags(SharedInstanceHandle instance, CPUSharedInstanceFlags instanceFlags)
		{
		}

		public void Set_LODGroupAndMask(SharedInstanceHandle instance, uint lodGroupAndMask)
		{
		}

		public void Set_GameObjectLayer(SharedInstanceHandle instance, int gameObjectLayer)
		{
		}

		public void Set_RefCount(SharedInstanceHandle instance, int refCount)
		{
		}

		public void Set_MaterialIDs(SharedInstanceHandle instance, in SmallEntityIdArray materialIDs)
		{
		}

		public void Set(SharedInstanceHandle instance, EntityId rendererGroupID, in SmallEntityIdArray materialIDs, int meshID, in AABB localAABB, TransformUpdateFlags transformUpdateFlags, InstanceFlags instanceFlags, uint lodGroupAndMask, GPUDrivenMeshLodInfo meshLodInfo, int gameObjectLayer, int refCount)
		{
		}

		public void SetDefault(SharedInstanceHandle instance)
		{
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}
	}
}
