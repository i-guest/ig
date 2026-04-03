using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace Unity.Properties
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal readonly struct ConversionRegistry : IEqualityComparer<ConversionRegistry>
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

		private static readonly ConverterKeyComparer Comparer;

		private readonly Dictionary<ConverterKey, Delegate> m_Converters;

		private ConversionRegistry(Dictionary<ConverterKey, Delegate> storage)
		{
			m_Converters = null;
		}

		public static ConversionRegistry Create()
		{
			return default(ConversionRegistry);
		}

		public void Register(Type source, Type destination, Delegate converter)
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

		public bool Equals(ConversionRegistry x, ConversionRegistry y)
		{
			return false;
		}

		public int GetHashCode(ConversionRegistry obj)
		{
			return 0;
		}
	}
}
