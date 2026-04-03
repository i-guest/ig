using System;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
	{
		[SerializeField]
		private StyleKeyword m_Keyword;

		[SerializeField]
		private FontDefinition m_Value;

		public FontDefinition value
		{
			get
			{
				return default(FontDefinition);
			}
			set
			{
			}
		}

		public StyleKeyword keyword
		{
			get
			{
				return default(StyleKeyword);
			}
			set
			{
			}
		}

		public StyleFontDefinition(FontDefinition f)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		public StyleFontDefinition(FontAsset f)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		public StyleFontDefinition(Font f)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		public StyleFontDefinition(StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		internal StyleFontDefinition(object obj, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		internal StyleFontDefinition(FontAsset f, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		internal StyleFontDefinition(Font f, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(FontDefinition);
		}

		public static implicit operator StyleFontDefinition(StyleKeyword keyword)
		{
			return default(StyleFontDefinition);
		}

		public static implicit operator StyleFontDefinition(FontDefinition f)
		{
			return default(StyleFontDefinition);
		}

		public bool Equals(StyleFontDefinition other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
