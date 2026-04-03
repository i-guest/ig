using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class StylePropertyUtil
	{
		internal static readonly Dictionary<string, StylePropertyId> s_NameToId;

		internal static readonly Dictionary<StylePropertyId, string> s_IdToName;

		internal static readonly Dictionary<string, string> s_UssNameToCSharpName;

		internal static readonly Dictionary<string, string> s_CSharpNameToUssName;

		internal static readonly HashSet<StylePropertyId> s_AnimatableProperties;

		internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties;

		internal static Dictionary<string, StylePropertyId> propertyNameToStylePropertyId
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		internal static Dictionary<StylePropertyId, string> stylePropertyIdToPropertyName
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue)
		{
			intValue = default(int);
			return false;
		}

		public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id)
		{
			return false;
		}

		public static bool IsAnimatable(StylePropertyId id)
		{
			return false;
		}
	}
}
