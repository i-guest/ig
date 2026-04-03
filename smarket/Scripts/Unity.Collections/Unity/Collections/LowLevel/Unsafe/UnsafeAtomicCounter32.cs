namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public struct UnsafeAtomicCounter32
	{
		public unsafe int* Counter;

		public unsafe UnsafeAtomicCounter32(void* ptr)
		{
			Counter = null;
		}

		public void Reset(int value = 0)
		{
		}

		public int Add(int value)
		{
			return 0;
		}

		public int Sub(int value)
		{
			return 0;
		}

		public int AddSat(int value, int max = 2147483647)
		{
			return 0;
		}

		public int SubSat(int value, int min = -2147483648)
		{
			return 0;
		}
	}
}
