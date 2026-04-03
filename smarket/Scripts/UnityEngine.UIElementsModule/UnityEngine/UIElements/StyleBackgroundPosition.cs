using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleBackgroundPosition : IStyleValue<BackgroundPosition>, IEquatable<StyleBackgroundPosition>
	{
		[SerializeField]
		private BackgroundPosition m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public BackgroundPosition value
		{
			get
			{
				return default(BackgroundPosition);
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

		public StyleBackgroundPosition(BackgroundPosition v)
		{
			m_Value = default(BackgroundPosition);
			m_Keyword = default(StyleKeyword);
		}

		public StyleBackgroundPosition(StyleKeyword keyword)
		{
			m_Value = default(BackgroundPosition);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleBackgroundPosition(BackgroundPosition v, StyleKeyword keyword)
		{
			m_Value = default(BackgroundPosition);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs)
		{
			return false;
		}

		public static implicit operator StyleBackgroundPosition(StyleKeyword keyword)
		{
			return default(StyleBackgroundPosition);
		}

		public bool Equals(StyleBackgroundPosition other)
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
