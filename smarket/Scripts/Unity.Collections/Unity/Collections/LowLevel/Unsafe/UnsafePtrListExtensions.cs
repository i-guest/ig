using System;
using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	internal static class UnsafePtrListExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static ref UnsafeList<IntPtr> ListData<T>(this ref UnsafePtrList<T> from) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static UnsafeList<IntPtr> ListDataRO<T>(this UnsafePtrList<T> from) where T : struct
		{
			return default(UnsafeList<IntPtr>);
		}
	}
}
