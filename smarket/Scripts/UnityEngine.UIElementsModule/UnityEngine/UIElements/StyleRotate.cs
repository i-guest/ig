using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
	{
		[SerializeField]
		private Rotate m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public Rotate value
		{
			get
			{
				return default(Rotate);
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

		public StyleRotate(Rotate v)
		{
			m_Value = default(Rotate);
			m_Keyword = default(StyleKeyword);
		}

		public StyleRotate(StyleKeyword keyword)
		{
			m_Value = default(Rotate);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleRotate(Rotate v, StyleKeyword keyword)
		{
			m_Value = default(Rotate);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleRotate lhs, StyleRotate rhs)
		{
			return false;
		}

		public static implicit operator StyleRotate(StyleKeyword keyword)
		{
			return default(StyleRotate);
		}

		public static implicit operator StyleRotate(Rotate v)
		{
			return default(StyleRotate);
		}

		public bool Equals(StyleRotate other)
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
