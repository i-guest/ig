using System;
using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements.Internal
{
	internal class AutoCompletePathVisitor : ITypeVisitor, IPropertyVisitor, IPropertyBagVisitor, IListPropertyVisitor
	{
		private class VisitContext
		{
			public List<PropertyPathInfo> propertyPathInfos { get; set; }

			public HashSet<Type> types { get; }

			public PropertyPath current { get; set; }

			public int currentDepth { get; set; }
		}

		private struct InspectedTypeScope<TContainer> : IDisposable
		{
			private VisitContext m_VisitContext;

			public InspectedTypeScope(VisitContext context)
			{
				m_VisitContext = null;
			}

			public void Dispose()
			{
			}
		}

		private struct VisitedPropertyScope : IDisposable
		{
			private VisitContext m_VisitContext;

			public VisitedPropertyScope(VisitContext context, IProperty property)
			{
				m_VisitContext = null;
			}

			public VisitedPropertyScope(VisitContext context, int index, Type type)
			{
				m_VisitContext = null;
			}

			public void Dispose()
			{
			}
		}

		private VisitContext m_VisitContext;

		public int maxDepth { get; }

		private bool HasReachedEnd(Type containerType)
		{
			return false;
		}

		public void Reset()
		{
		}

		void ITypeVisitor.Visit<TContainer>()
		{
		}

		void IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
		}

		void IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
		{
		}

		void IListPropertyVisitor.Visit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list)
		{
		}

		private void VisitPropertyType(Type type)
		{
		}
	}
}
