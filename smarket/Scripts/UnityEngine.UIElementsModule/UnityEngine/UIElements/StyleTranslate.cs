using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
	{
		[SerializeField]
		private Translate m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public Translate value
		{
			get
			{
				return default(Translate);
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

		public StyleTranslate(Translate v)
		{
			m_Value = default(Translate);
			m_Keyword = default(StyleKeyword);
		}

		public StyleTranslate(StyleKeyword keyword)
		{
			m_Value = default(Translate);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleTranslate(Translate v, StyleKeyword keyword)
		{
			m_Value = default(Translate);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs)
		{
			return false;
		}

		public static implicit operator StyleTranslate(StyleKeyword keyword)
		{
			return default(StyleTranslate);
		}

		public static implicit operator StyleTranslate(Translate v)
		{
			return default(StyleTranslate);
		}

		public static implicit operator StyleTranslate(Vector3 v)
		{
			return default(StyleTranslate);
		}

		public bool Equals(StyleTranslate other)
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
