using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public static class UnsafeUtilityExtensions
	{
		internal unsafe static void MemSwap(void* ptr, void* otherPtr, long size)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static T ReadArrayElementBoundsChecked<T>(void* source, int index, int capacity) where T : struct
		{
			return default(T);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static void WriteArrayElementBoundsChecked<T>(void* destination, int index, T value, int capacity) where T : struct
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static void* AddressOf<T>(in T value) where T : struct
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static ref T AsRef<T>(in T value) where T : struct
		{
			throw null;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private unsafe static void CheckMemSwapOverlap(byte* dst, byte* src, long size)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckIndexRange(int index, int capacity)
		{
		}
	}
}
