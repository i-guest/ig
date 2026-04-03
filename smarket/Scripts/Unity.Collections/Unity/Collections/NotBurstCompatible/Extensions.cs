namespace Unity.Collections.NotBurstCompatible
{
	public static class Extensions
	{
		[ExcludeFromBurstCompatTesting("Returns managed array")]
		public static T[] ToArray<T>(this NativeHashSet<T> set) where T : struct
		{
			return null;
		}

		[ExcludeFromBurstCompatTesting("Returns managed array")]
		public static T[] ToArray<T>(this NativeParallelHashSet<T> set) where T : struct
		{
			return null;
		}

		[ExcludeFromBurstCompatTesting("Returns managed array")]
		public static T[] ToArrayNBC<T>(this NativeList<T> list) where T : struct
		{
			return null;
		}

		[ExcludeFromBurstCompatTesting("Takes managed array")]
		public static void CopyFromNBC<T>(this NativeList<T> list, T[] array) where T : struct
		{
		}
	}
}
