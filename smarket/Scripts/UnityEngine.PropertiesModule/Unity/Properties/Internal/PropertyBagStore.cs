using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Unity.Properties.Internal
{
	internal static class PropertyBagStore
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		internal struct TypedStore<TContainer>
		{
			public static IPropertyBag<TContainer> PropertyBag;
		}

		private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags;

		private static readonly List<Type> s_RegisteredTypes;

		private static ReflectedPropertyBagProvider s_PropertyBagProvider;

		private static ReflectedPropertyBagProvider ReflectedPropertyBagProvider => null;

		internal static void CreatePropertyBagProvider()
		{
		}

		internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag)
		{
		}

		internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
		{
			return null;
		}

		internal static IPropertyBag GetPropertyBag(Type type)
		{
			return null;
		}

		internal static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag)
		{
			propertyBag = null;
			return false;
		}
	}
}
