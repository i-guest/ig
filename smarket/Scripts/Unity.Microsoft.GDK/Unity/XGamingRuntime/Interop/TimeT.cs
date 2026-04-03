using System;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime.Interop
{
	[MovedFrom("Unity.GameCore.Interop")]
	public struct TimeT
	{
		private static DateTime UnixEpoch;

		internal readonly long SecondsSinceUnixEpoch;

		public DateTime DateTime => default(DateTime);

		internal TimeT(long secondsSinceUnixEpoch)
		{
			SecondsSinceUnixEpoch = 0L;
		}

		public TimeT(DateTime dateTime)
		{
			SecondsSinceUnixEpoch = 0L;
		}
	}
}
