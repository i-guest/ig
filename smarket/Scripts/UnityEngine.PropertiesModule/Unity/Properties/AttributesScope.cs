using System;
using System.Collections.Generic;
using Unity.Properties.Internal;

namespace Unity.Properties
{
	public readonly struct AttributesScope : IDisposable
	{
		private readonly IAttributes m_Target;

		private readonly List<Attribute> m_Previous;

		public AttributesScope(IProperty target, IProperty source)
		{
			m_Target = null;
			m_Previous = null;
		}

		internal AttributesScope(IAttributes target, List<Attribute> attributes)
		{
			m_Target = null;
			m_Previous = null;
		}

		public void Dispose()
		{
		}
	}
}
