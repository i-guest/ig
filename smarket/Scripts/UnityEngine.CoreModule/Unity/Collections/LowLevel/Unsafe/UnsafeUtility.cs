using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
	[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
	[StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
	public static class UnsafeUtility
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		internal struct TypeFlagsCache<T>
		{
			internal static readonly int flags;

			static TypeFlagsCache()
			{
			}

			[BurstDiscard]
			private static void Init(ref int flags)
			{
			}
		}

		private struct AlignOfHelper<T> where T : struct
		{
			public byte dummy;

			public T data;
		}

		public static bool IsBlittable<T>() where T : struct
		{
			return false;
		}

		[ThreadSafe(ThrowsException = false)]
		[VisibleToOtherModules(new string[] { "UnityEngine.AIModule" })]
		[BurstAuthorizedExternalMethod]
		internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.AIModule" })]
		[BurstAuthorizedExternalMethod]
		[ThreadSafe(ThrowsException = false)]
		internal static int LeakErase(IntPtr handle, LeakCategory category)
		{
			return 0;
		}

		public unsafe static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = true)]
		internal unsafe static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip, IntPtr label)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void FreeTracked(void* memory, Allocator allocator)
		{
		}

		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			return null;
		}

		public unsafe static void* Malloc(long size, int alignment, MemoryLabel label)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = true)]
		private unsafe static void* Malloc(long size, int alignment, Allocator allocator, IntPtr label)
		{
			return null;
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
		}

		public unsafe static void Free(void* memory, MemoryLabel label)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpyReplicate(void* destination, void* source, int size, int count)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemMove(void* destination, void* source, long size)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
		}

		public unsafe static void MemClear(void* destination, long size)
		{
		}

		[ThreadSafe(ThrowsException = true)]
		public unsafe static int MemCmp(void* ptr1, void* ptr2, long size)
		{
			return 0;
		}

		[ThreadSafe]
		public static int SizeOf(Type type)
		{
			return 0;
		}

		[ThreadSafe]
		public static bool IsBlittable(Type type)
		{
			return false;
		}

		[ThreadSafe]
		internal static int GetScriptingTypeFlags(Type type)
		{
			return 0;
		}

		private static bool IsBlittableValueType(Type t)
		{
			return false;
		}

		private static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			return null;
		}

		internal static bool IsArrayBlittable(Array arr)
		{
			return false;
		}

		internal static bool IsGenericListBlittable<T>() where T : struct
		{
			return false;
		}

		internal static string GetReasonForArrayNonBlittable(Array arr)
		{
			return null;
		}

		internal static string GetReasonForGenericListNonBlittable<T>() where T : struct
		{
			return null;
		}

		public static bool IsUnmanaged<T>()
		{
			return false;
		}

		public static int AlignOf<T>() where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			output = default(T);
		}

		private unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			output = default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
		}

		private unsafe static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			return default(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void* AddressOf<T>(ref T output) where T : struct
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SizeOf<T>() where T : struct
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T As<U, T>(ref U from)
		{
			throw null;
		}

		internal static T As<T>(object from) where T : class
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ref T AsRef<T>(void* ptr) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int EnumToInt<T>(T enumValue) where T : struct, IConvertible
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EnumEquals<T>(T lhs, T rhs) where T : struct, IConvertible
		{
			return false;
		}
	}
}
