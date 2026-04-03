using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public static class ConverterGroups
	{
		private static readonly ConverterGroup s_GlobalConverters;

		private static readonly ConverterGroup s_PrimitivesConverters;

		private static readonly Dictionary<string, ConverterGroup> s_BindingConverterGroups;

		static ConverterGroups()
		{
		}

		private static void RegisterPrimitivesConverter()
		{
		}

		internal static void RegisterGlobal<TSource, TDestination>(TypeConverter<TSource, TDestination> converter)
		{
		}

		public static bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
		{
			destination = default(TDestination);
			return false;
		}

		public static bool TrySetValueGlobal<TContainer, TValue>(ref TContainer container, in PropertyPath path, TValue value, out VisitReturnCode returnCode)
		{
			returnCode = default(VisitReturnCode);
			return false;
		}

		private static void RegisterInt8Converters()
		{
		}

		private static void RegisterInt16Converters()
		{
		}

		private static void RegisterInt32Converters()
		{
		}

		private static void RegisterInt64Converters()
		{
		}

		private static void RegisterUInt8Converters()
		{
		}

		private static void RegisterUInt16Converters()
		{
		}

		private static void RegisterUInt32Converters()
		{
		}

		private static void RegisterUInt64Converters()
		{
		}

		private static void RegisterFloatConverters()
		{
		}

		private static void RegisterDoubleConverters()
		{
		}

		private static void RegisterBooleanConverters()
		{
		}

		private static void RegisterCharConverters()
		{
		}

		private static void RegisterColorConverters()
		{
		}
	}
}
