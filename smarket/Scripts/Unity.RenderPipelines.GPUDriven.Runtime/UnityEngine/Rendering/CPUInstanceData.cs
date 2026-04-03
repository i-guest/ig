using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal struct CPUInstanceData : IDisposable
	{
		internal readonly struct ReadOnly
		{
			public readonly NativeArray<int>.ReadOnly instanceIndices;

			public readonly NativeArray<InstanceHandle>.ReadOnly instances;

			public readonly NativeArray<SharedInstanceHandle>.ReadOnly sharedInstances;

			public readonly ParallelBitArray localToWorldIsFlippedBits;

			public readonly NativeArray<AABB>.ReadOnly worldAABBs;

			public readonly NativeArray<int>.ReadOnly tetrahedronCacheIndices;

			public readonly ParallelBitArray movedInCurrentFrameBits;

			public readonly ParallelBitArray movedInPreviousFrameBits;

			public readonly ParallelBitArray visibleInPreviousFrameBits;

			public readonly EditorInstanceDataArrays.ReadOnly editorData;

			public readonly NativeArray<GPUDrivenRendererMeshLodData>.ReadOnly meshLodData;

			public int handlesLength => 0;

			public int instancesLength => 0;

			public ReadOnly(in CPUInstanceData instanceData)
			{
				instanceIndices = default(NativeArray<int>.ReadOnly);
				instances = default(NativeArray<InstanceHandle>.ReadOnly);
				sharedInstances = default(NativeArray<SharedInstanceHandle>.ReadOnly);
				localToWorldIsFlippedBits = default(ParallelBitArray);
				worldAABBs = default(NativeArray<AABB>.ReadOnly);
				tetrahedronCacheIndices = default(NativeArray<int>.ReadOnly);
				movedInCurrentFrameBits = default(ParallelBitArray);
				movedInPreviousFrameBits = default(ParallelBitArray);
				visibleInPreviousFrameBits = default(ParallelBitArray);
				editorData = default(EditorInstanceDataArrays.ReadOnly);
				meshLodData = default(NativeArray<GPUDrivenRendererMeshLodData>.ReadOnly);
			}

			public int InstanceToIndex(InstanceHandle instance)
			{
				return 0;
			}

			public InstanceHandle IndexToInstance(int index)
			{
				return default(InstanceHandle);
			}

			public bool IsValidInstance(InstanceHandle instance)
			{
				return false;
			}

			public bool IsValidIndex(int index)
			{
				return false;
			}
		}

		private const int k_InvalidIndex = -1;

		private NativeArray<int> m_StructData;

		private NativeList<int> m_InstanceIndices;

		public NativeArray<InstanceHandle> instances;

		public NativeArray<SharedInstanceHandle> sharedInstances;

		public ParallelBitArray localToWorldIsFlippedBits;

		public NativeArray<AABB> worldAABBs;

		public NativeArray<int> tetrahedronCacheIndices;

		public ParallelBitArray movedInCurrentFrameBits;

		public ParallelBitArray movedInPreviousFrameBits;

		public ParallelBitArray visibleInPreviousFrameBits;

		public EditorInstanceDataArrays editorData;

		public NativeArray<GPUDrivenRendererMeshLodData> meshLodData;

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

		private void AddUnsafe(InstanceHandle instance)
		{
		}

		public int InstanceToIndex(InstanceHandle instance)
		{
			return 0;
		}

		public InstanceHandle IndexToInstance(int index)
		{
			return default(InstanceHandle);
		}

		public bool IsValidInstance(InstanceHandle instance)
		{
			return false;
		}

		public bool IsFreeInstanceHandle(InstanceHandle instance)
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

		public void AddNoGrow(InstanceHandle instance)
		{
		}

		public void Add(InstanceHandle instance)
		{
		}

		public void Remove(InstanceHandle instance)
		{
		}

		public void Set(InstanceHandle instance, SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, in AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame, in GPUDrivenRendererMeshLodData meshLod)
		{
		}

		public void SetDefault(InstanceHandle instance)
		{
		}

		public SharedInstanceHandle Get_SharedInstance(InstanceHandle instance)
		{
			return default(SharedInstanceHandle);
		}

		public bool Get_LocalToWorldIsFlipped(InstanceHandle instance)
		{
			return false;
		}

		public AABB Get_WorldAABB(InstanceHandle instance)
		{
			return default(AABB);
		}

		public int Get_TetrahedronCacheIndex(InstanceHandle instance)
		{
			return 0;
		}

		public ref AABB Get_WorldBounds(InstanceHandle instance)
		{
			throw null;
		}

		public bool Get_MovedInCurrentFrame(InstanceHandle instance)
		{
			return false;
		}

		public bool Get_MovedInPreviousFrame(InstanceHandle instance)
		{
			return false;
		}

		public bool Get_VisibleInPreviousFrame(InstanceHandle instance)
		{
			return false;
		}

		public GPUDrivenRendererMeshLodData Get_MeshLodData(InstanceHandle instance)
		{
			return default(GPUDrivenRendererMeshLodData);
		}

		public void Set_SharedInstance(InstanceHandle instance, SharedInstanceHandle sharedInstance)
		{
		}

		public void Set_LocalToWorldIsFlipped(InstanceHandle instance, bool isFlipped)
		{
		}

		public void Set_WorldAABB(InstanceHandle instance, in AABB worldBounds)
		{
		}

		public void Set_TetrahedronCacheIndex(InstanceHandle instance, int tetrahedronCacheIndex)
		{
		}

		public void Set_MovedInCurrentFrame(InstanceHandle instance, bool movedInCurrentFrame)
		{
		}

		public void Set_MovedInPreviousFrame(InstanceHandle instance, bool movedInPreviousFrame)
		{
		}

		public void Set_VisibleInPreviousFrame(InstanceHandle instance, bool visibleInPreviousFrame)
		{
		}

		public void Set_MeshLodData(InstanceHandle instance, GPUDrivenRendererMeshLodData meshLod)
		{
		}

		public ReadOnly AsReadOnly()
		{
			return default(ReadOnly);
		}
	}
}
