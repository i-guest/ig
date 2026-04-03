using System;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class FixedList4096BytesExtensions
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this ref FixedList4096Bytes<T> list, U value) where T : struct, IEquatable<U>
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this ref FixedList4096Bytes<T> list, U value) where T : struct, IEquatable<U>
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Remove<T, U>(this ref FixedList4096Bytes<T> list, U value) where T : struct, IEquatable<U>
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool RemoveSwapBack<T, U>(this ref FixedList4096Bytes<T> list, U value) where T : struct, IEquatable<U>
		{
			return false;
		}
	}
}
