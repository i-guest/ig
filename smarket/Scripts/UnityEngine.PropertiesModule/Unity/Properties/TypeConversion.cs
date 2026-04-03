using System;

namespace Unity.Properties
{
	public static class TypeConversion
	{
		private static class PrimitiveConverters
		{
			public static void Register()
			{
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

			private static void RegisterFloat32Converters()
			{
			}

			private static void RegisterFloat64Converters()
			{
			}

			private static void RegisterBooleanConverters()
			{
			}

			private static void RegisterCharConverters()
			{
			}

			private static void RegisterStringConverters()
			{
			}

			private static void RegisterObjectConverters()
			{
			}
		}

		private static readonly ConversionRegistry s_GlobalConverters;

		static TypeConversion()
		{
		}

		public static void Register<TSource, TDestination>(TypeConverter<TSource, TDestination> converter)
		{
		}

		public static TDestination Convert<TSource, TDestination>(ref TSource value)
		{
			return default(TDestination);
		}

		public static bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
		{
			destination = default(TDestination);
			return false;
		}

		private static bool TryConvertToUnityEngineObject<TSource, TDestination>(TSource source, out TDestination destination)
		{
			destination = default(TDestination);
			return false;
		}

		private static bool IsNumericType(Type t)
		{
			return false;
		}
	}
}
