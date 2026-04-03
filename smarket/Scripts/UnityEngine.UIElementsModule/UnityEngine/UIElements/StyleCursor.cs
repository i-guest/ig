using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
	{
		[SerializeField]
		private Cursor m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public Cursor value
		{
			get
			{
				return default(Cursor);
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

		public StyleCursor(StyleKeyword keyword)
		{
			m_Value = default(Cursor);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleCursor(Cursor v, StyleKeyword keyword)
		{
			m_Value = default(Cursor);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleCursor lhs, StyleCursor rhs)
		{
			return false;
		}

		public static implicit operator StyleCursor(StyleKeyword keyword)
		{
			return default(StyleCursor);
		}

		public bool Equals(StyleCursor other)
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
