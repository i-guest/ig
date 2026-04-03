namespace UnityEngine.Rendering
{
	internal struct InstanceAllocators
	{
		private InstanceAllocator m_InstanceAlloc_MeshRenderer;

		private InstanceAllocator m_InstanceAlloc_SpeedTree;

		private InstanceAllocator m_SharedInstanceAlloc;

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private InstanceAllocator GetInstanceAllocator(InstanceType type)
		{
			return default(InstanceAllocator);
		}

		public int GetInstanceHandlesLength(InstanceType type)
		{
			return 0;
		}

		public int GetInstancesLength(InstanceType type)
		{
			return 0;
		}

		public InstanceHandle AllocateInstance(InstanceType type)
		{
			return default(InstanceHandle);
		}

		public void FreeInstance(InstanceHandle instance)
		{
		}

		public SharedInstanceHandle AllocateSharedInstance()
		{
			return default(SharedInstanceHandle);
		}

		public void FreeSharedInstance(SharedInstanceHandle instance)
		{
		}
	}
}
