using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct StyleMaterialDefinition : IStyleValue<MaterialDefinition>, IEquatable<StyleMaterialDefinition>
	{
		[SerializeField]
		private MaterialDefinition m_Value;

		[SerializeField]
		private StyleKeyword m_Keyword;

		public MaterialDefinition value
		{
			get
			{
				return default(MaterialDefinition);
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

		public StyleMaterialDefinition(MaterialDefinition m)
		{
			m_Value = default(MaterialDefinition);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleMaterialDefinition(object obj, StyleKeyword keyword)
		{
			m_Value = default(MaterialDefinition);
			m_Keyword = default(StyleKeyword);
		}

		public StyleMaterialDefinition(StyleKeyword keyword)
		{
			m_Value = default(MaterialDefinition);
			m_Keyword = default(StyleKeyword);
		}

		internal StyleMaterialDefinition(MaterialDefinition m, StyleKeyword keyword)
		{
			m_Value = default(MaterialDefinition);
			m_Keyword = default(StyleKeyword);
		}

		public static bool operator ==(StyleMaterialDefinition lhs, StyleMaterialDefinition rhs)
		{
			return false;
		}

		public static implicit operator StyleMaterialDefinition(StyleKeyword keyword)
		{
			return default(StyleMaterialDefinition);
		}

		public bool Equals(StyleMaterialDefinition other)
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
