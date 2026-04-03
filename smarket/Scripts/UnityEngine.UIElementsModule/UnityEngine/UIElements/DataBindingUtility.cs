using System.Text.RegularExpressions;
using UnityEngine.Bindings;
using UnityEngine.Pool;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class DataBindingUtility
	{
		private static readonly UnityEngine.Pool.ObjectPool<TypePathVisitor> k_TypeVisitors;

		private static readonly UnityEngine.Pool.ObjectPool<AutoCompletePathVisitor> k_AutoCompleteVisitors;

		private static readonly Regex s_ReplaceIndices;

		public static bool TryGetBinding(VisualElement element, in BindingId bindingId, out BindingInfo bindingInfo)
		{
			bindingInfo = default(BindingInfo);
			return false;
		}
	}
}
