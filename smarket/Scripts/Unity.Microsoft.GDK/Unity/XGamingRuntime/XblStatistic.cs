using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblStatistic
	{
		public string StatisticName { get; private set; }

		public string StatisticType { get; private set; }

		public string Value { get; private set; }

		internal XblStatistic(XblStatisticInternal interopStatistic)
		{
		}

		internal XblStatistic(Unity.XGamingRuntime.Interop.XblStatistic interopStatistic)
		{
		}
	}
}
