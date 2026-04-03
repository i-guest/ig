using System;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public static class UnsafeListExtensions
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this UnsafeList<T> list, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this UnsafeList<T> list, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this UnsafeList<T>.ReadOnly list, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this UnsafeList<T>.ReadOnly list, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this UnsafeList<T>.ParallelReader list, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this UnsafeList<T>.ParallelReader list, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static bool ArraysEqual<T>(this UnsafeList<T> container, in UnsafeList<T> other) where T : struct
		{
			return false;
		}
	}
}
