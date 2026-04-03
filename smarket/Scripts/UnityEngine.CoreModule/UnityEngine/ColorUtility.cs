using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Math/ColorUtility.h")]
	public class ColorUtility
	{
		private static ReadOnlySpan<Color32> HtmlColorValues => default(ReadOnlySpan<Color32>);

		private static ReadOnlySpan<string> HtmlColorNames => default(ReadOnlySpan<string>);

		[FreeFunction("TryParseHtmlColor", true)]
		internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
		{
			color = default(Color32);
			return false;
		}

		public static bool TryParseHtmlString(string htmlString, out Color color)
		{
			color = default(Color);
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToHtmlStringRGB(Color color)
		{
			return null;
		}

		public static string ToHtmlStringRGB(in Color color)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string ToHtmlStringRGBA(Color color)
		{
			return null;
		}

		public static string ToHtmlStringRGBA(in Color color)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static bool TryParseHtmlString(ReadOnlySpan<char> input, out Color color)
		{
			color = default(Color);
			return false;
		}

		private static bool IsHexString(ReadOnlySpan<char> span)
		{
			return false;
		}

		private static bool TryParseHexColor(ReadOnlySpan<char> hex, out Color color)
		{
			color = default(Color);
			return false;
		}

		private static bool TryHexToByte(ReadOnlySpan<char> span, out byte result)
		{
			result = default(byte);
			return false;
		}

		private static int HexDigitValue(char c)
		{
			return 0;
		}

		private static bool DoTryParseHtmlColor_Injected(ref ManagedSpanWrapper htmlString, out Color32 color)
		{
			color = default(Color32);
			return false;
		}
	}
}
