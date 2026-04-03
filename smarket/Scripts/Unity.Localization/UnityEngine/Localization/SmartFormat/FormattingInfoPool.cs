using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class FormattingInfoPool
	{
		internal static readonly ObjectPool<FormattingInfo> s_Pool;

		public static FormattingInfo Get(FormatDetails formatDetails, Format format, object currentValue)
		{
			return null;
		}

		public static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Format format, object currentValue)
		{
			return null;
		}

		public static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, object currentValue)
		{
			return null;
		}

		public static void Release(FormattingInfo toRelease)
		{
		}
	}
}
