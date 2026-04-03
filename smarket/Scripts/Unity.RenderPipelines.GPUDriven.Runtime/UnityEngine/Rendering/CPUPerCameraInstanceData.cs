using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	internal struct CPUPerCameraInstanceData : IDisposable
	{
		internal struct PerCameraInstanceDataArrays : IDisposable
		{
			internal UnsafeList<byte> meshLods;

			internal UnsafeList<byte> crossFades;

			public bool IsCreated => false;

			public PerCameraInstanceDataArrays(int initCapacity)
			{
				meshLods = default(UnsafeList<byte>);
				crossFades = default(UnsafeList<byte>);
			}

			public void Dispose()
			{
			}

			internal void Remove(int index, int lastIndex)
			{
			}

			internal void Grow(int previousCapacity, int newCapacity)
			{
			}

			internal void SetDefault(int index)
			{
			}
		}

		public const byte k_InvalidByteData = 255;

		public NativeParallelHashMap<int, PerCameraInstanceDataArrays> perCameraData;

		private NativeArray<int> m_StructData;

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

		public int cameraCount => 0;

		public void Initialize(int initCapacity)
		{
		}

		public void DeallocateCameras(NativeArray<EntityId> cameraIDs)
		{
		}

		public void AllocateCameras(NativeArray<EntityId> cameraIDs)
		{
		}

		public void Remove(int index)
		{
		}

		public void IncreaseInstanceCount()
		{
		}

		public void Dispose()
		{
		}

		internal void Grow(int newCapacity)
		{
		}

		public void SetDefault(int index)
		{
		}
	}
}
