using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine.Bindings;

namespace Unity.Collections
{
	[VisibleToOtherModules]
	internal static class CollectionExtensions
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void AddToArray<T>(ref T[] array, T item)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void InsertIntoArray<T>(ref T[] array, int index, T item)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule" })]
		internal static void RemoveFromArray<T>(ref T[] array, int index)
		{
		}

		internal static string SerializedView<T>([DisallowNull] this IEnumerable<T> collection, [DisallowNull] Func<T, string> serializeElement)
		{
			return null;
		}
	}
}
