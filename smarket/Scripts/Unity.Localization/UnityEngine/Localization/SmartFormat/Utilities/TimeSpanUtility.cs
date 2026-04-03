using System;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	public static class TimeSpanUtility
	{
		internal const TimeSpanFormatOptions AbbreviateAll = TimeSpanFormatOptions.Abbreviate | TimeSpanFormatOptions.AbbreviateOff;

		internal const TimeSpanFormatOptions LessThanAll = TimeSpanFormatOptions.LessThan | TimeSpanFormatOptions.LessThanOff;

		internal const TimeSpanFormatOptions RangeAll = TimeSpanFormatOptions.RangeMilliSeconds | TimeSpanFormatOptions.RangeSeconds | TimeSpanFormatOptions.RangeMinutes | TimeSpanFormatOptions.RangeHours | TimeSpanFormatOptions.RangeDays | TimeSpanFormatOptions.RangeWeeks;

		internal const TimeSpanFormatOptions TruncateAll = TimeSpanFormatOptions.TruncateShortest | TimeSpanFormatOptions.TruncateAuto | TimeSpanFormatOptions.TruncateFill | TimeSpanFormatOptions.TruncateFull;

		public static TimeSpanFormatOptions DefaultFormatOptions { get; set; }

		public static TimeSpanFormatOptions AbsoluteDefaults { get; }

		public static string ToTimeString(this TimeSpan FromTime, TimeSpanFormatOptions options, TimeTextInfo timeTextInfo)
		{
			return null;
		}

		static TimeSpanUtility()
		{
		}

		public static TimeSpan Round(this TimeSpan fromTime, long intervalTicks)
		{
			return default(TimeSpan);
		}
	}
}
