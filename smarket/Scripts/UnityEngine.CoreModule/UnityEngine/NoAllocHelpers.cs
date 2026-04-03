using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[VisibleToOtherModules]
	internal static class NoAllocHelpers
	{
		private class ListPrivateFieldAccess<T>
		{
			internal T[] _items;

			internal int _size;

			internal int _version;
		}

		public static void EnsureListElemCount<T>(List<T> list, int count)
		{
		}

		public static int SafeLength(Array values)
		{
			return 0;
		}

		public static int SafeLength<T>(List<T> values)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T[] ExtractArrayFromList<T>(List<T> list)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<T> CreateReadOnlySpan<T>(List<T> list)
		{
			return default(ReadOnlySpan<T>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetListContents<T>(List<T> list, ReadOnlySpan<T> span)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetListSize<T>(List<T> list, int size)
		{
		}

		[RequiredByNativeCode]
		private static Array PrepareListForNativeFill(object list, Type elementType, int newSize)
		{
			return null;
		}
	}
}
