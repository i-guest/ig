using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct FilterParameter : IEquatable<FilterParameter>
	{
		[SerializeField]
		private FilterParameterType m_Type;

		[SerializeField]
		private float m_FloatValue;

		[SerializeField]
		private Color m_ColorValue;

		public FilterParameterType type
		{
			get
			{
				return default(FilterParameterType);
			}
			set
			{
			}
		}

		public float floatValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color colorValue
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static bool operator ==(FilterParameter a, FilterParameter b)
		{
			return false;
		}

		public static bool operator !=(FilterParameter a, FilterParameter b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(FilterParameter other)
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
