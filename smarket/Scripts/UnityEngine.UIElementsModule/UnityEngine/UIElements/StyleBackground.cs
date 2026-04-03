using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleBackground : IStyleValue<Background>, IEquatable<StyleBackground>
	{
		[SerializeField]
		private Background m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public Background value
		{
			get
			{
				return default(Background);
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

		public StyleBackground(Background v)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		public StyleBackground(Texture2D v)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		public StyleBackground(Sprite v)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		public StyleBackground(VectorImage v)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		public StyleBackground(StyleKeyword keyword)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleBackground(Texture2D v, StyleKeyword keyword)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleBackground(Sprite v, StyleKeyword keyword)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleBackground(VectorImage v, StyleKeyword keyword)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleBackground(Background v, StyleKeyword keyword)
		{
			m_Value = default(Background);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleBackground lhs, StyleBackground rhs)
		{
			return false;
		}

		public static implicit operator StyleBackground(StyleKeyword keyword)
		{
			return default(StyleBackground);
		}

		public bool Equals(StyleBackground other)
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
