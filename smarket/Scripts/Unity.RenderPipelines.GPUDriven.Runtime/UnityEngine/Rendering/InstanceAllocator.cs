using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal struct InstanceAllocator
	{
		private NativeArray<int> m_StructData;

		private NativeList<int> m_FreeInstances;

		private int m_BaseInstanceOffset;

		private int m_InstanceStride;

		public int length
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool valid => false;

		public void Initialize(int baseInstanceOffset = 0, int instanceStride = 1)
		{
		}

		public void Dispose()
		{
		}

		public int AllocateInstance()
		{
			return 0;
		}

		public void FreeInstance(int instance)
		{
		}

		public int GetNumAllocated()
		{
			return 0;
		}
	}
}
