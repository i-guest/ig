using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class StyleSheetUtility
	{
		private static readonly Dictionary<string, string> SpecialEnumToStringCases;

		private static readonly Dictionary<string, string> SpecialStringToEnumCases;

		public static StyleSheet CreateInstanceWithHideFlags()
		{
			return null;
		}

		public static Dimension ToDimension(this Length length)
		{
			return default(Dimension);
		}

		public static Dimension.Unit ToDimensionUnit(this LengthUnit unit)
		{
			return default(Dimension.Unit);
		}

		public static Dimension ToDimension(this Angle angle)
		{
			return default(Dimension);
		}

		public static Dimension.Unit ToDimensionUnit(this AngleUnit unit)
		{
			return default(Dimension.Unit);
		}

		public static Dimension ToDimension(this TimeValue timeValue)
		{
			return default(Dimension);
		}

		public static Dimension.Unit ToDimensionUnit(this TimeUnit unit)
		{
			return default(Dimension.Unit);
		}

		public static void TransferStylePropertyHandles(StyleSheet fromStyleSheet, StyleProperty fromStyleProperty, StyleSheet toStyleSheet, StyleProperty toStyleProperty)
		{
		}

		public static string GetEnumExportString(Enum value)
		{
			return null;
		}

		public static string ConvertCamelToDash(string camel)
		{
			return null;
		}

		public static string ConvertDashToHungarian(string dash)
		{
			return null;
		}

		public static string ConvertDashToUpperNoSpace(string dash, bool firstCase, bool addSpace)
		{
			return null;
		}

		public static string GetDimensionUnitExportString(Dimension.Unit unit)
		{
			return null;
		}
	}
}
