namespace UnityEngine.Rendering
{
	internal struct IndirectBufferAllocInfo
	{
		public int drawAllocIndex;

		public int drawCount;

		public int instanceAllocIndex;

		public int instanceCount;

		public bool IsEmpty()
		{
			return false;
		}

		public bool IsWithinLimits(in IndirectBufferLimits limits)
		{
			return false;
		}

		public int GetExtraDrawInfoSlotIndex()
		{
			return 0;
		}
	}
}
