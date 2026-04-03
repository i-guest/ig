using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering.Universal
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct Sorting
	{
		public static ProfilingSampler s_QuickSortSampler;

		public static ProfilingSampler s_InsertionSortSampler;

		public static void QuickSort<T>(T[] data, Func<T, T, int> compare)
		{
		}

		public static void QuickSort<T>(T[] data, int start, int end, Func<T, T, int> compare)
		{
		}

		private static T Median3Pivot<T>(T[] data, int start, int pivot, int end, Func<T, T, int> compare)
		{
			return default(T);
		}

		private static int Partition<T>(T[] data, int start, int end, Func<T, T, int> compare)
		{
			return 0;
		}

		public static void InsertionSort<T>(T[] data, Func<T, T, int> compare)
		{
		}

		public static void InsertionSort<T>(T[] data, int start, int end, Func<T, T, int> compare)
		{
		}
	}
}
