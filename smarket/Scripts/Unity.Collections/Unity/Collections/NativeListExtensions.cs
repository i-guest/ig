using System;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeListExtensions
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this NativeList<T> list, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this NativeList<T> list, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static bool ArraysEqual<T>(this NativeArray<T> container, in NativeList<T> other) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static bool ArraysEqual<T>(this NativeList<T> container, in NativeArray<T> other) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static bool ArraysEqual<T>(this NativeList<T> container, in NativeList<T> other) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static bool ArraysEqual<T>(this NativeList<T> container, in UnsafeList<T> other) where T : struct
		{
			return false;
		}
	}
}
