using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal readonly struct TypeConverterRegistry : IEqualityComparer<TypeConverterRegistry>
	{
		private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
		{
			public bool Equals(ConverterKey x, ConverterKey y)
			{
				return false;
			}

			public int GetHashCode(ConverterKey obj)
			{
				return 0;
			}
		}

		private readonly struct ConverterKey
		{
			public readonly Type SourceType;

			public readonly Type DestinationType;

			public ConverterKey(Type source, Type destination)
			{
				SourceType = null;
				DestinationType = null;
			}
		}

		private static readonly ConverterKeyComparer k_Comparer;

		private readonly Dictionary<ConverterKey, Delegate> m_Converters;

		private TypeConverterRegistry(Dictionary<ConverterKey, Delegate> storage)
		{
			m_Converters = null;
		}

		public static TypeConverterRegistry Create()
		{
			return default(TypeConverterRegistry);
		}

		public void Register(Type source, Type destination, Delegate converter)
		{
		}

		internal void Apply(TypeConverterRegistry registry)
		{
		}

		public Delegate GetConverter(Type source, Type destination)
		{
			return null;
		}

		public bool TryGetConverter(Type source, Type destination, out Delegate converter)
		{
			converter = null;
			return false;
		}

		public bool Equals(TypeConverterRegistry x, TypeConverterRegistry y)
		{
			return false;
		}

		public int GetHashCode(TypeConverterRegistry obj)
		{
			return 0;
		}
	}
}
