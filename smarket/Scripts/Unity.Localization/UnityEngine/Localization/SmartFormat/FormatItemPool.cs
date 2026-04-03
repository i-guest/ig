using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.Core.Settings;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class FormatItemPool
	{
		internal static readonly ObjectPool<LiteralText> s_LiteralTextPool;

		internal static readonly ObjectPool<Format> s_FormatPool;

		internal static readonly ObjectPool<Placeholder> s_PlaceholderPool;

		internal static readonly ObjectPool<Selector> s_SelectorPool;

		public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex)
		{
			return null;
		}

		public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex)
		{
			return null;
		}

		public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex)
		{
			return null;
		}

		public static Format GetFormat(SmartSettings smartSettings, string baseString)
		{
			return null;
		}

		public static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex)
		{
			return null;
		}

		public static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex, bool nested)
		{
			return null;
		}

		public static Format GetFormat(SmartSettings smartSettings, Placeholder parent, int startIndex)
		{
			return null;
		}

		public static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth)
		{
			return null;
		}

		public static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth, Format itemFormat, int endIndex)
		{
			return null;
		}

		public static Selector GetSelector(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex, int operatorStart, int selectorIndex)
		{
			return null;
		}

		public static void ReleaseLiteralText(LiteralText literal)
		{
		}

		public static void ReleaseFormat(Format format)
		{
		}

		public static void ReleasePlaceholder(Placeholder placeholder)
		{
		}

		public static void ReleaseSelector(Selector selector)
		{
		}

		public static void Release(FormatItem format)
		{
		}
	}
}
