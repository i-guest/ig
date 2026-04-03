using System;
using Unity.Properties.Internal;

namespace Unity.Properties
{
	public static class PropertyBag
	{
		public static void AcceptWithSpecializedVisitor<TContainer>(IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, ref TContainer container)
		{
		}

		public static void Register<TContainer>(PropertyBag<TContainer> propertyBag)
		{
		}

		public static void RegisterList<TElement>()
		{
		}

		public static void RegisterList<TContainer, TElement>()
		{
		}

		public static IPropertyBag GetPropertyBag(Type type)
		{
			return null;
		}

		public static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
		{
			return null;
		}

		public static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag)
		{
			propertyBag = null;
			return false;
		}
	}
	public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
	{
		InstantiationKind IConstructor.InstantiationKind => default(InstantiationKind);

		protected virtual InstantiationKind InstantiationKind { get; }

		static PropertyBag()
		{
		}

		void IPropertyBagRegister.Register()
		{
		}

		public void Accept(ITypeVisitor visitor)
		{
		}

		void IPropertyBag.Accept(IPropertyBagVisitor visitor, ref object container)
		{
		}

		void IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, ref TContainer container)
		{
		}

		PropertyCollection<TContainer> IPropertyBag<TContainer>.GetProperties()
		{
			return default(PropertyCollection<TContainer>);
		}

		PropertyCollection<TContainer> IPropertyBag<TContainer>.GetProperties(ref TContainer container)
		{
			return default(PropertyCollection<TContainer>);
		}

		TContainer IConstructor<TContainer>.Instantiate()
		{
			return default(TContainer);
		}

		public abstract PropertyCollection<TContainer> GetProperties();

		public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container);

		protected virtual TContainer Instantiate()
		{
			return default(TContainer);
		}
	}
}
