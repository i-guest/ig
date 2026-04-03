using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleList<T> : IStyleValue<List<T>>, IEquatable<StyleList<T>>
	{
		[SerializeField]
		private StyleKeyword m_Keyword;

		[SerializeField]
		private List<T> m_Value;

		public List<T> value
		{
			get
			{
				return null;
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

		public StyleList(StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = null;
		}

		internal StyleList(List<T> v, StyleKeyword keyword)
		{
			m_Keyword = default(StyleKeyword);
			m_Value = null;
		}

		public static bool operator ==(StyleList<T> lhs, StyleList<T> rhs)
		{
			return false;
		}

		public static implicit operator StyleList<T>(StyleKeyword keyword)
		{
			return default(StyleList<T>);
		}

		public bool Equals(StyleList<T> other)
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
