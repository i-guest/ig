using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class ObjectListPool<T>
	{
		private static ObjectPool<List<T>> pool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> elements)
		{
		}
	}
}
