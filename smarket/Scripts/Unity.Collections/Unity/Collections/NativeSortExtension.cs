using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeSortExtension
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public struct DefaultComparer<T> : IComparer<T>
		{
			public int Compare(T x, T y)
			{
				return 0;
			}
		}

		private const int k_IntrosortSizeThreshold = 16;

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static void Sort<T>(T* array, int length) where T : unmanaged
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public unsafe static void Sort<T, U>(T* array, int length, U comp) where T : unmanaged
		{
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static SortJob<T, DefaultComparer<T>> SortJob<T>(T* array, int length) where T : unmanaged
		{
			return default(SortJob<T, DefaultComparer<T>>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public unsafe static SortJob<T, U> SortJob<T, U>(T* array, int length, U comp) where T : unmanaged
		{
			return default(SortJob<T, U>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static int BinarySearch<T>(T* ptr, int length, T value) where T : unmanaged
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public unsafe static int BinarySearch<T, U>(T* ptr, int length, T value, U comp) where T : unmanaged
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void Sort<T>(this NativeArray<T> array) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static void Sort<T, U>(this NativeArray<T> array, U comp) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeArray<T> array) where T : struct
		{
			return default(SortJob<T, DefaultComparer<T>>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static SortJob<T, U> SortJob<T, U>(this NativeArray<T> array, U comp) where T : struct
		{
			return default(SortJob<T, U>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static int BinarySearch<T>(this NativeArray<T> array, T value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static int BinarySearch<T, U>(this NativeArray<T> array, T value, U comp) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static int BinarySearch<T>(this NativeArray<T>.ReadOnly array, T value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static int BinarySearch<T, U>(this NativeArray<T>.ReadOnly array, T value, U comp) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void Sort<T>(this NativeList<T> list) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static void Sort<T, U>(this NativeList<T> list, U comp) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeList<T> list) where T : struct
		{
			return default(SortJob<T, DefaultComparer<T>>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static SortJob<T, U> SortJob<T, U>(this NativeList<T> list, U comp) where T : struct
		{
			return default(SortJob<T, U>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
		public static SortJobDefer<T, DefaultComparer<T>> SortJobDefer<T>(this NativeList<T> list) where T : struct
		{
			return default(SortJobDefer<T, DefaultComparer<T>>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static SortJobDefer<T, U> SortJobDefer<T, U>(this NativeList<T> list, U comp) where T : struct
		{
			return default(SortJobDefer<T, U>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static int BinarySearch<T>(this NativeList<T> list, T value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static int BinarySearch<T, U>(this NativeList<T> list, T value, U comp) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void Sort<T>(this UnsafeList<T> list) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static void Sort<T, U>(this UnsafeList<T> list, U comp) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(this UnsafeList<T> list) where T : struct
		{
			return default(SortJob<T, DefaultComparer<T>>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static SortJob<T, U> SortJob<T, U>(this UnsafeList<T> list, U comp) where T : struct
		{
			return default(SortJob<T, U>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static int BinarySearch<T>(this UnsafeList<T> list, T value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static int BinarySearch<T, U>(this UnsafeList<T> list, T value, U comp) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void Sort<T>(this NativeSlice<T> slice) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static void Sort<T, U>(this NativeSlice<T> slice, U comp) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[] { typeof(int) })]
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeSlice<T> slice) where T : struct
		{
			return default(SortJob<T, DefaultComparer<T>>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static SortJob<T, U> SortJob<T, U>(this NativeSlice<T> slice, U comp) where T : struct
		{
			return default(SortJob<T, U>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static int BinarySearch<T>(this NativeSlice<T> slice, T value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		public static int BinarySearch<T, U>(this NativeSlice<T> slice, T value, U comp) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		internal unsafe static void IntroSort<T, U>(void* array, int length, U comp) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(DefaultComparer<int>)
		})]
		internal unsafe static void IntroSort_R<T, U>(void* array, int lo, int hi, int depth, U comp) where T : struct
		{
		}

		private unsafe static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) where T : struct
		{
		}

		private unsafe static int Partition<T, U>(void* array, int lo, int hi, U comp) where T : struct
		{
			return 0;
		}

		private unsafe static void HeapSort<T, U>(void* array, int lo, int hi, U comp) where T : struct
		{
		}

		private unsafe static void Heapify<T, U>(void* array, int i, int n, int lo, U comp) where T : struct
		{
		}

		private unsafe static void Swap<T>(void* array, int lhs, int rhs) where T : struct
		{
		}

		private unsafe static void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp) where T : struct
		{
		}

		private unsafe static void IntroSortStruct<T, U>(void* array, int length, U comp) where T : struct
		{
		}

		private unsafe static void IntroSortStruct_R<T, U>(void* array, in int lo, in int _hi, int depth, U comp) where T : struct
		{
		}

		private unsafe static void InsertionSortStruct<T, U>(void* array, in int lo, in int hi, U comp) where T : struct
		{
		}

		private unsafe static int PartitionStruct<T, U>(void* array, in int lo, in int hi, U comp) where T : struct
		{
			return 0;
		}

		private unsafe static void HeapSortStruct<T, U>(void* array, in int lo, in int hi, U comp) where T : struct
		{
		}

		private unsafe static void HeapifyStruct<T, U>(void* array, int i, int n, in int lo, U comp) where T : struct
		{
		}

		private unsafe static void SwapStruct<T>(void* array, int lhs, int rhs) where T : struct
		{
		}

		private unsafe static void SwapIfGreaterWithItemsStruct<T, U>(void* array, int lhs, int rhs, U comp) where T : struct
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckStrideMatchesSize<T>(int stride) where T : struct
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private unsafe static void CheckComparer<T, U>(T* array, int length, U comp) where T : unmanaged
		{
		}
	}
}
