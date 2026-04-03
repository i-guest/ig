using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleBackgroundRepeat : IStyleValue<BackgroundRepeat>, IEquatable<StyleBackgroundRepeat>
	{
		[SerializeField]
		private BackgroundRepeat m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public BackgroundRepeat value
		{
			get
			{
				return default(BackgroundRepeat);
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

		public StyleBackgroundRepeat(BackgroundRepeat v)
		{
			m_Value = default(BackgroundRepeat);
			m_Keyword = default(StyleKeyword);
		}

		public StyleBackgroundRepeat(StyleKeyword keyword)
		{
			m_Value = default(BackgroundRepeat);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleBackgroundRepeat(BackgroundRepeat v, StyleKeyword keyword)
		{
			m_Value = default(BackgroundRepeat);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs)
		{
			return false;
		}

		public static implicit operator StyleBackgroundRepeat(StyleKeyword keyword)
		{
			return default(StyleBackgroundRepeat);
		}

		public bool Equals(StyleBackgroundRepeat other)
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
