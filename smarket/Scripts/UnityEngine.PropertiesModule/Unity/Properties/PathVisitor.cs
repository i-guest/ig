using System;

namespace Unity.Properties
{
	public abstract class PathVisitor : IPropertyBagVisitor, IPropertyVisitor
	{
		private readonly struct PropertyScope : IDisposable
		{
			private readonly PathVisitor m_Visitor;

			private readonly IProperty m_Property;

			public PropertyScope(PathVisitor visitor, IProperty property)
			{
				m_Visitor = null;
				m_Property = null;
			}

			public void Dispose()
			{
			}
		}

		private int m_PathIndex;

		public PropertyPath Path { get; set; }

		private IProperty Property { get; set; }

		public bool ReadonlyVisit { get; set; }

		public VisitReturnCode ReturnCode { get; protected set; }

		public virtual void Reset()
		{
		}

		void IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
		}

		void IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
		{
		}

		protected virtual void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
		}
	}
}
