using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections
{
	[GenerateTestsForBurstCompatibility]
	public static class CollectionHelper
	{
		[StructLayout((LayoutKind)2)]
		internal struct LongDoubleUnion
		{
			[FieldOffset(0)]
			internal long longValue;

			[FieldOffset(0)]
			internal double doubleValue;
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[BurstCompile]
		public struct DummyJob : IJob
		{
			public void Execute()
			{
			}
		}

		public const int CacheLineSize = 64;

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckAllocator(AllocatorManager.AllocatorHandle allocator)
		{
		}

		public static int Log2Floor(int value)
		{
			return 0;
		}

		public static int Log2Ceil(int value)
		{
			return 0;
		}

		public static int Align(int size, int alignmentPowerOfTwo)
		{
			return 0;
		}

		public static ulong Align(ulong size, ulong alignmentPowerOfTwo)
		{
			return 0uL;
		}

		internal unsafe static void* AlignPointer(void* ptr, int alignmentPowerOfTwo)
		{
			return null;
		}

		public unsafe static bool IsAligned(void* p, int alignmentPowerOfTwo)
		{
			return false;
		}

		public static bool IsAligned(ulong offset, int alignmentPowerOfTwo)
		{
			return false;
		}

		public static bool IsPowerOfTwo(int value)
		{
			return false;
		}

		public unsafe static uint Hash(void* ptr, int bytes)
		{
			return 0u;
		}

		[ExcludeFromBurstCompatTesting("Used only for debugging, and uses managed strings")]
		internal static void WriteLayout(Type type)
		{
		}

		internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int AssumePositive(int value)
		{
			return 0;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new Type[] { typeof(NativeArray<int>) })]
		internal static void CheckIsUnmanaged<T>()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckIntPositivePowerOfTwo(int value)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckUlongPositivePowerOfTwo(ulong value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckIndexInRange(int index, int length)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckCapacityInRange(int capacity, int length)
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(AllocatorManager.AllocatorHandle)
		})]
		public static NativeArray<T> CreateNativeArray<T, U>(int length, ref U allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct where U : struct, AllocatorManager.IAllocator
		{
			return default(NativeArray<T>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
			return default(NativeArray<T>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static NativeArray<T> CreateNativeArray<T>(NativeArray<T> array, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[ExcludeFromBurstCompatTesting("Managed array")]
		public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[ExcludeFromBurstCompatTesting("Managed array")]
		public static NativeArray<T> CreateNativeArray<T, U>(T[] array, ref U allocator) where T : struct where U : struct, AllocatorManager.IAllocator
		{
			return default(NativeArray<T>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void DisposeNativeArray<T>(NativeArray<T> nativeArray, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static void Dispose<T>(NativeArray<T> nativeArray) where T : struct
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckConvertArguments<T>(int length) where T : struct
		{
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, AllocatorManager.AllocatorHandle allocator, bool setTempMemoryHandle = false) where T : struct
		{
			return default(NativeArray<T>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
		public static NativeArray<T> ConvertExistingNativeListToNativeArray<T>(ref NativeList<T> nativeList, int length, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
		{
			typeof(int),
			typeof(int),
			typeof(AllocatorManager.AllocatorHandle)
		})]
		public static NativeParallelMultiHashMap<TKey, TValue> CreateNativeParallelMultiHashMap<TKey, TValue, U>(int length, ref U allocator) where TKey : struct, IEquatable<TKey> where TValue : struct where U : struct, AllocatorManager.IAllocator
		{
			return default(NativeParallelMultiHashMap<TKey, TValue>);
		}

		[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new Type[] { typeof(DummyJob) })]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		public static void CheckReflectionDataCorrect<T>(IntPtr reflectionData)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[BurstDiscard]
		private static void CheckReflectionDataCorrectInternal<T>(IntPtr reflectionData, ref bool burstCompiled)
		{
		}
	}
}
