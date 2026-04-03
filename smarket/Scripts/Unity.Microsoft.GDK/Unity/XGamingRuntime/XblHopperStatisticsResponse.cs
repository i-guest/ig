using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblHopperStatisticsResponse
	{
		public string HopperName { get; set; }

		public long EstimatedWaitTime { get; set; }

		public uint PlayersWaitingToMatch { get; set; }

		internal XblHopperStatisticsResponse()
		{
		}

		internal XblHopperStatisticsResponse(Unity.XGamingRuntime.Interop.XblHopperStatisticsResponse interopHandle)
		{
		}
	}
}
