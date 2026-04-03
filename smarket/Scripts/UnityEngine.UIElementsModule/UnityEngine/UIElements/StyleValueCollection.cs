using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	internal class StyleValueCollection
	{
		internal List<StyleValue> m_Values;

		public StyleLength GetStyleLength(StylePropertyId id)
		{
			return default(StyleLength);
		}

		public StyleFloat GetStyleFloat(StylePropertyId id)
		{
			return default(StyleFloat);
		}

		public StyleInt GetStyleInt(StylePropertyId id)
		{
			return default(StyleInt);
		}

		public StyleColor GetStyleColor(StylePropertyId id)
		{
			return default(StyleColor);
		}

		public StyleBackground GetStyleBackground(StylePropertyId id)
		{
			return default(StyleBackground);
		}

		public StyleBackgroundPosition GetStyleBackgroundPosition(StylePropertyId id)
		{
			return default(StyleBackgroundPosition);
		}

		public StyleBackgroundRepeat GetStyleBackgroundRepeat(StylePropertyId id)
		{
			return default(StyleBackgroundRepeat);
		}

		public StyleFont GetStyleFont(StylePropertyId id)
		{
			return default(StyleFont);
		}

		public StyleFontDefinition GetStyleFontDefinition(StylePropertyId id)
		{
			return default(StyleFontDefinition);
		}

		public StyleMaterialDefinition GetStyleMaterialDefinition(StylePropertyId id)
		{
			return default(StyleMaterialDefinition);
		}

		public StyleRatio GetStyleRatio(StylePropertyId id)
		{
			return default(StyleRatio);
		}

		public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value)
		{
			return false;
		}

		public void SetStyleValue(StyleValue value)
		{
		}
	}
}
