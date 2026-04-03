namespace Unity.Collections.LowLevel.Unsafe.NotBurstCompatible
{
	public static class Extensions
	{
		public static T[] ToArray<T>(this UnsafeParallelHashSet<T> set) where T : struct
		{
			return null;
		}

		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public static void AddNBC(this ref UnsafeAppendBuffer buffer, string value)
		{
		}

		[ExcludeFromBurstCompatTesting("Returns managed array")]
		public static byte[] ToBytesNBC(this ref UnsafeAppendBuffer buffer)
		{
			return null;
		}

		[ExcludeFromBurstCompatTesting("Managed string out argument")]
		public static void ReadNextNBC(this ref UnsafeAppendBuffer.Reader reader, out string value)
		{
			value = null;
		}
	}
}
