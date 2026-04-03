using System;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeReferenceUnsafeUtility
	{
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static T* GetUnsafePtr<T>(this NativeReference<T> reference) where T : unmanaged
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static T* GetUnsafeReadOnlyPtr<T>(this NativeReference<T> reference) where T : unmanaged
		{
			return null;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static T* GetUnsafePtrWithoutChecks<T>(this NativeReference<T> reference) where T : unmanaged
		{
			return null;
		}
	}
}
