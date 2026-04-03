using System;

namespace UnityEngine.UIElements
{
	public struct StyleTextAutoSize : IStyleValue<TextAutoSize>, IEquatable<StyleTextAutoSize>
	{
		private StyleKeyword m_Keyword;

		private TextAutoSize m_Value;

		public TextAutoSize value
		{
			get
			{
				return default(TextAutoSize);
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

		public StyleTextAutoSize(StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(TextAutoSize);
		}

		internal StyleTextAutoSize(TextAutoSize v, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(TextAutoSize);
		}

		public static bool operator ==(StyleTextAutoSize lhs, StyleTextAutoSize rhs)
		{
			return false;
		}

		public static implicit operator StyleTextAutoSize(StyleKeyword keyword)
		{
			return default(StyleTextAutoSize);
		}

		public bool Equals(StyleTextAutoSize other)
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

		public override string ToString()
		{
			return null;
		}
	}
}
