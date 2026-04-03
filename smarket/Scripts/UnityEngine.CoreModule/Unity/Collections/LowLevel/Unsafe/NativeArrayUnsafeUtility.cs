using System;

namespace Unity.Collections.LowLevel.Unsafe
{
	public static class NativeArrayUnsafeUtility
	{
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		public static NativeArray<T> ConvertExistingDataToNativeArray<T>(Span<T> data, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		public unsafe static void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : struct
		{
			return null;
		}

		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : struct
		{
			return null;
		}

		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T>.ReadOnly nativeArray) where T : struct
		{
			return null;
		}

		public unsafe static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : struct
		{
			return null;
		}
	}
}
