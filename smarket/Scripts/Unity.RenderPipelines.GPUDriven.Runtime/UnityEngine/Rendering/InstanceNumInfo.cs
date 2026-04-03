namespace UnityEngine.Rendering
{
	internal struct InstanceNumInfo
	{
		public unsafe fixed int InstanceNums[2];

		public void InitDefault()
		{
		}

		public InstanceNumInfo(InstanceType type, int instanceNum)
		{
		}

		public InstanceNumInfo(int meshRendererNum = 0, int speedTreeNum = 0)
		{
		}

		public int GetInstanceNum(InstanceType type)
		{
			return 0;
		}

		public int GetInstanceNumIncludingChildren(InstanceType type)
		{
			return 0;
		}

		public int GetTotalInstanceNum()
		{
			return 0;
		}
	}
}
