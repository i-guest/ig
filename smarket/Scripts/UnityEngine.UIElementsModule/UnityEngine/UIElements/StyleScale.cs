using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale>
	{
		[SerializeField]
		private Scale m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public Scale value
		{
			get
			{
				return default(Scale);
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

		public StyleScale(Scale v)
		{
			m_Value = default(Scale);
			m_Keyword = default(StyleKeyword);
		}

		public StyleScale(StyleKeyword keyword)
		{
			m_Value = default(Scale);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleScale(Scale v, StyleKeyword keyword)
		{
			m_Value = default(Scale);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleScale lhs, StyleScale rhs)
		{
			return false;
		}

		public static implicit operator StyleScale(StyleKeyword keyword)
		{
			return default(StyleScale);
		}

		public static implicit operator StyleScale(Scale v)
		{
			return default(StyleScale);
		}

		public bool Equals(StyleScale other)
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
