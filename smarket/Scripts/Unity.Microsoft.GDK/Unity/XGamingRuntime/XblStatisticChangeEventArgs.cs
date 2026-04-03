using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public struct XblStatisticChangeEventArgs
	{
		public ulong xboxUserId;

		public string serviceConfigurationId;

		public XblStatistic latestStatistic;

		internal XblStatisticChangeEventArgs(Unity.XGamingRuntime.Interop.XblStatisticChangeEventArgs interopStruct)
		{
			xboxUserId = 0uL;
			serviceConfigurationId = null;
			latestStatistic = null;
		}
	}
}
