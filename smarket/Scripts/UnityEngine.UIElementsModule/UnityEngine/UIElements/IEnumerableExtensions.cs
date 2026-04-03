using System.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class IEnumerableExtensions
	{
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static int GetCount(this IEnumerable collection)
		{
			return 0;
		}
	}
}
