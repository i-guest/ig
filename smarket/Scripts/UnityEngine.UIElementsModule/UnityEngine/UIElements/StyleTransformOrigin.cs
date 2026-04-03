using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
	{
		[SerializeField]
		private TransformOrigin m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public TransformOrigin value
		{
			get
			{
				return default(TransformOrigin);
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

		public StyleTransformOrigin(TransformOrigin v)
		{
			m_Value = default(TransformOrigin);
			m_Keyword = default(StyleKeyword);
		}

		public StyleTransformOrigin(StyleKeyword keyword)
		{
			m_Value = default(TransformOrigin);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword)
		{
			m_Value = default(TransformOrigin);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
		{
			return false;
		}

		public static implicit operator StyleTransformOrigin(StyleKeyword keyword)
		{
			return default(StyleTransformOrigin);
		}

		public static implicit operator StyleTransformOrigin(TransformOrigin v)
		{
			return default(StyleTransformOrigin);
		}

		public bool Equals(StyleTransformOrigin other)
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
