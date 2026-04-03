using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
	{
		[SerializeField]
		private StyleKeyword m_Keyword;

		[SerializeField]
		private TextShadow m_Value;

		public TextShadow value
		{
			get
			{
				return default(TextShadow);
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

		public StyleTextShadow(StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(TextShadow);
		}

		internal StyleTextShadow(TextShadow v, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = default(TextShadow);
		}

		public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			return false;
		}

		public static implicit operator StyleTextShadow(StyleKeyword keyword)
		{
			return default(StyleTextShadow);
		}

		public bool Equals(StyleTextShadow other)
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
