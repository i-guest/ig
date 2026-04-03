using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class NativeArrayExtensions
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public struct NativeArrayStaticId<T> where T : struct
		{
			internal static readonly SharedStatic<int> s_staticSafetyId;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this NativeArray<T> array, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this NativeArray<T> array, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static bool Contains<T, U>(this NativeArray<T>.ReadOnly array, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static int IndexOf<T, U>(this NativeArray<T>.ReadOnly array, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public unsafe static bool Contains<T, U>(void* ptr, int length, U value) where T : struct
		{
			return false;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public unsafe static int IndexOf<T, U>(void* ptr, int length, U value) where T : struct
		{
			return 0;
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void CopyFrom<T>(this ref NativeArray<T> container, NativeList<T> other) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void CopyFrom<T>(this ref NativeArray<T> container, in NativeHashSet<T> other) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void CopyFrom<T>(this ref NativeArray<T> container, in UnsafeHashSet<T> other) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int)
		})]
		public static NativeArray<U> Reinterpret<T, U>(this NativeArray<T> array) where T : struct where U : struct
		{
			return default(NativeArray<U>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static bool ArraysEqual<T>(this NativeArray<T> container, NativeArray<T> other) where T : struct
		{
			return false;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckReinterpretSize<T, U>(ref NativeArray<T> array) where T : struct where U : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal static void Initialize<T>(this ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(AllocatorManager.AllocatorHandle)
		})]
		internal static void Initialize<T, U>(this ref NativeArray<T> array, int length, ref U allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct where U : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		internal static void DisposeCheckAllocator<T>(this ref NativeArray<T> array) where T : struct
		{
		}
	}
}
