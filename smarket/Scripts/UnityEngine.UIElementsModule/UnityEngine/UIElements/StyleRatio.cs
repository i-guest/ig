using System;

namespace UnityEngine.UIElements
{
	public struct StyleRatio : IStyleValue<Ratio>, IEquatable<StyleRatio>
	{
		private Ratio m_Value;

		private StyleKeyword m_Keyword;

		public Ratio value
		{
			get
			{
				return default(Ratio);
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

		public StyleRatio(Ratio value)
		{
			m_Value = default(Ratio);
			m_Keyword = default(StyleKeyword);
		}

		public StyleRatio(StyleKeyword keyword)
		{
			m_Value = default(Ratio);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleRatio(Ratio value, StyleKeyword keyword)
		{
			m_Value = default(Ratio);
			m_Keyword = default(StyleKeyword);
		}

		public static StyleRatio Auto()
		{
			return default(StyleRatio);
		}

		internal bool IsAuto()
		{
			return false;
		}

		public static implicit operator StyleRatio(float value)
		{
			return default(StyleRatio);
		}

		public static implicit operator Ratio(StyleRatio value)
		{
			return default(Ratio);
		}

		public static implicit operator StyleRatio(StyleKeyword value)
		{
			return default(StyleRatio);
		}

		public static bool operator ==(StyleRatio lhs, StyleRatio rhs)
		{
			return false;
		}

		public bool Equals(StyleRatio other)
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
