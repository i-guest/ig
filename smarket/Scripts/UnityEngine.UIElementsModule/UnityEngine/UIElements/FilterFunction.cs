using System;
using UnityEngine.Bindings;
using UnityEngine.UIElements.Layout;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct FilterFunction : IEquatable<FilterFunction>
	{
		[SerializeField]
		private FilterFunctionType m_Type;

		[SerializeField]
		private FixedBuffer4<FilterParameter> m_Parameters;

		[SerializeField]
		private int m_ParameterCount;

		[SerializeField]
		private FilterFunctionDefinition m_CustomDefinition;

		public FilterFunctionType type
		{
			get
			{
				return default(FilterFunctionType);
			}
			set
			{
			}
		}

		internal FixedBuffer4<FilterParameter> parameters => default(FixedBuffer4<FilterParameter>);

		public int parameterCount => 0;

		public FilterFunctionDefinition customDefinition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void AddParameter(FilterParameter p)
		{
		}

		public void ClearParameters()
		{
		}

		internal FilterFunction(FilterFunctionType type, FixedBuffer4<FilterParameter> parameters, int paramCount)
		{
			m_Type = default(FilterFunctionType);
			m_Parameters = default(FixedBuffer4<FilterParameter>);
			m_ParameterCount = 0;
			m_CustomDefinition = null;
		}

		internal FilterFunction(FilterFunctionDefinition customDefinition, FixedBuffer4<FilterParameter> parameters, int paramCount)
		{
			m_Type = default(FilterFunctionType);
			m_Parameters = default(FixedBuffer4<FilterParameter>);
			m_ParameterCount = 0;
			m_CustomDefinition = null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal FilterFunctionDefinition GetDefinition()
		{
			return null;
		}

		public static bool operator ==(FilterFunction lhs, FilterFunction rhs)
		{
			return false;
		}

		public static bool operator !=(FilterFunction lhs, FilterFunction rhs)
		{
			return false;
		}

		public bool Equals(FilterFunction other)
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
