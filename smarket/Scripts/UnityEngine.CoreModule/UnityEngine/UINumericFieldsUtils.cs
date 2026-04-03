using UnityEngine.Bindings;

namespace UnityEngine
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule" })]
	internal static class UINumericFieldsUtils
	{
		public static readonly string k_AllowedCharactersForFloat;

		public static readonly string k_AllowedCharactersForFloat_NoExpressions;

		public static readonly string k_AllowedCharactersForInt;

		public static readonly string k_AllowedCharactersForInt_NoExpressions;

		public static readonly string k_AllowedCharactersForUInt_NoExpressions;

		public static readonly string k_DoubleFieldFormatString;

		public static readonly string k_FloatFieldFormatString;

		public static readonly string k_IntFieldFormatString;

		public static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr)
		{
			value = default(double);
			expr = null;
			return false;
		}

		public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out ExpressionEvaluator.Expression expression)
		{
			value = default(double);
			expression = null;
			return false;
		}

		public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out ExpressionEvaluator.Expression expression)
		{
			value = default(float);
			expression = null;
			return false;
		}

		public static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr)
		{
			value = default(long);
			expr = null;
			return false;
		}

		public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out ExpressionEvaluator.Expression expression)
		{
			value = default(long);
			expression = null;
			return false;
		}

		public static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr)
		{
			value = default(ulong);
			expr = null;
			return false;
		}

		public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out ExpressionEvaluator.Expression expression)
		{
			value = default(ulong);
			expression = null;
			return false;
		}

		public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out ExpressionEvaluator.Expression expression)
		{
			value = default(int);
			expression = null;
			return false;
		}

		public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out ExpressionEvaluator.Expression expression)
		{
			value = default(uint);
			expression = null;
			return false;
		}
	}
}
