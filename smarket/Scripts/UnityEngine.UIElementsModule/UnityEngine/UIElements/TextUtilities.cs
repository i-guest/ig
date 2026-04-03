using UnityEngine.TextCore;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal static class TextUtilities
	{
		private static Vector2 PostProcessMeasuredSize(TextElement te, Vector2 measuredSize, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, float pixelsPerPoint)
		{
			return default(Vector2);
		}

		internal static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, float? fontsize = null)
		{
			return default(Vector2);
		}

		internal static Vector2 MeasureVisualElementTextSize(TextElement te, in RenderedText textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, float? fontsize = null)
		{
			return default(Vector2);
		}

		internal static FontAsset GetFontAsset(VisualElement ve)
		{
			return null;
		}

		internal static bool IsFontAssigned(VisualElement ve)
		{
			return false;
		}

		internal static TextSettings GetTextSettingsFrom(VisualElement ve)
		{
			return null;
		}

		internal static bool IsAdvancedTextEnabledForPanel(IPanel panel)
		{
			return false;
		}

		internal static bool IsAdvancedTextEnabledForElement(VisualElement ve)
		{
			return false;
		}

		internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve, bool ignoreColors)
		{
			return default(TextCoreSettings);
		}

		public static TextWrappingMode toTextWrappingMode(this WhiteSpace whiteSpace, bool isSingleLineInputField)
		{
			return default(TextWrappingMode);
		}

		public static UnityEngine.TextCore.TextOverflow toTextCore(this TextOverflow textOverflow, OverflowInternal overflow, TextOverflowPosition position)
		{
			return default(UnityEngine.TextCore.TextOverflow);
		}
	}
}
