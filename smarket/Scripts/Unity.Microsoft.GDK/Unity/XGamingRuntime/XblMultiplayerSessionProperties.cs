using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionProperties
	{
		public string[] Keywords { get; }

		public XblMultiplayerSessionRestriction JoinRestriction { get; }

		public XblMultiplayerSessionRestriction ReadRestriction { get; }

		public uint[] TurnCollection { get; }

		public string MatchmakingTargetSessionConstantsJson { get; }

		public string SessionCustomPropertiesJson { get; }

		public string MatchmakingServerConnectionString { get; }

		public string[] ServerConnectionStringCandidates { get; }

		public uint[] SessionOwnerMemberIds { get; }

		public XblDeviceToken HostDeviceToken { get; }

		public bool Closed { get; }

		public bool Locked { get; }

		public bool AllocateCloudCompute { get; }

		public bool MatchmakingResubmit { get; }

		internal Unity.XGamingRuntime.Interop.XblMultiplayerSessionProperties InteropHandle { get; }

		internal XblMultiplayerSessionProperties(Unity.XGamingRuntime.Interop.XblMultiplayerSessionProperties interopHandle)
		{
		}
	}
}
