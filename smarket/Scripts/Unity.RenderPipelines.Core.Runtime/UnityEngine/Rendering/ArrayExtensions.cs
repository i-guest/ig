using Unity.Collections;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering
{
	public static class ArrayExtensions
	{
		public static void ResizeArray<T>(this ref NativeArray<T> array, int capacity) where T : struct
		{
		}

		public static void ResizeArray(this ref TransformAccessArray array, int capacity)
		{
		}

		public static void ResizeArray<T>(ref T[] array, int capacity)
		{
		}

		public static void FillArray<T>(this ref NativeArray<T> array, in T value, int startIndex = 0, int length = -1) where T : struct
		{
		}
	}
}
