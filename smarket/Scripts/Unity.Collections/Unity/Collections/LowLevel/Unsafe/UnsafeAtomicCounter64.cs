namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public struct UnsafeAtomicCounter64
	{
		public unsafe long* Counter;

		public unsafe UnsafeAtomicCounter64(void* ptr)
		{
			Counter = null;
		}

		public void Reset(long value = 0L)
		{
		}

		public long Add(long value)
		{
			return 0L;
		}

		public long Sub(long value)
		{
			return 0L;
		}

		public long AddSat(long value, long max = 9223372036854775807L)
		{
			return 0L;
		}

		public long SubSat(long value, long min = -9223372036854775808L)
		{
			return 0L;
		}
	}
}
