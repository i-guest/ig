using System;
using System.Collections.Generic;
using Unity.Properties.Internal;

namespace Unity.Properties
{
	public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IPropertyAccept<TContainer>, IAttributes
	{
		private List<Attribute> m_Attributes;

		List<Attribute> IAttributes.Attributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string Name { get; }

		public abstract bool IsReadOnly { get; }

		public Type DeclaredValueType()
		{
			return null;
		}

		public void Accept(IPropertyVisitor visitor, ref TContainer container)
		{
		}

		public abstract TValue GetValue(ref TContainer container);

		public abstract void SetValue(ref TContainer container, TValue value);

		protected void AddAttribute(Attribute attribute)
		{
		}

		protected void AddAttributes(IEnumerable<Attribute> attributes)
		{
		}

		void IAttributes.AddAttribute(Attribute attribute)
		{
		}

		void IAttributes.AddAttributes(IEnumerable<Attribute> attributes)
		{
		}

		public bool HasAttribute<TAttribute>()
		{
			return false;
		}

		public TAttribute GetAttribute<TAttribute>()
		{
			return default(TAttribute);
		}

		AttributesScope IAttributes.CreateAttributesScope(IAttributes attributes)
		{
			return default(AttributesScope);
		}
	}
}
