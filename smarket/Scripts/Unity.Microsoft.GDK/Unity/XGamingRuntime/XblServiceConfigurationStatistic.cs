using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblServiceConfigurationStatistic
	{
		public string ServiceConfigurationId { get; private set; }

		public XblStatistic[] Statistics { get; private set; }

		internal XblServiceConfigurationStatistic(XblServiceConfigurationStatisticInternal interopStatistic)
		{
		}
	}
}
