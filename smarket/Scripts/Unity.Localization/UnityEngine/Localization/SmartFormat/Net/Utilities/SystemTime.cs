using System;

namespace UnityEngine.Localization.SmartFormat.Net.Utilities
{
	internal static class SystemTime
	{
		public static Func<DateTime> Now;

		public static Func<DateTimeOffset> OffsetNow;

		public static void SetDateTime(DateTime dateTimeNow)
		{
		}

		public static void SetDateTimeOffset(DateTimeOffset dateTimeOffset)
		{
		}

		public static void ResetDateTime()
		{
		}
	}
}
