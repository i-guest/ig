using System;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeListUnsafeUtility
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static T* GetUnsafePtr<T>(this NativeList<T> list) where T : unmanaged
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static T* GetUnsafeReadOnlyPtr<T>(this NativeList<T> list) where T : unmanaged
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static void* GetInternalListDataPtrUnchecked<T>(ref NativeList<T> list) where T : struct
		{
			return null;
		}
	}
}
