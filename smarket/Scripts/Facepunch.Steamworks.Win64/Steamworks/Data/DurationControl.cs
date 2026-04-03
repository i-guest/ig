using System;

namespace Steamworks.Data
{
	public struct DurationControl
	{
		internal DurationControl_t _inner;

		public AppId Appid => default(AppId);

		public bool Applicable => false;

		internal TimeSpan PlaytimeInLastFiveHours => default(TimeSpan);

		internal TimeSpan PlaytimeToday => default(TimeSpan);

		internal DurationControlProgress Progress => default(DurationControlProgress);
	}
}
