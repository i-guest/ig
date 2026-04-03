using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionConstants
	{
		public uint MaxMembersInSession { get; }

		public XblMultiplayerSessionVisibility Visibility { get; }

		public ulong[] InitiatorXuids { get; }

		public string CustomJson { get; }

		public string SessionCloudComputePackageConstantsJson { get; }

		public ulong MemberReservedTimeout { get; }

		public ulong MemberInactiveTimeout { get; }

		public ulong MemberReadyTimeout { get; }

		public ulong SessionEmptyTimeout { get; }

		public ulong ArbitrationTimeout { get; }

		public ulong ForfeitTimeout { get; }

		public bool EnableMetricsLatency { get; }

		public bool EnableMetricsBandwidthDown { get; }

		public bool EnableMetricsBandwidthUp { get; }

		public bool EnableMetricsCustom { get; }

		public XblMultiplayerMemberInitialization MemberInitialization { get; }

		public XblMultiplayerPeerToPeerRequirements PeerToPeerRequirements { get; }

		public XblMultiplayerPeerToHostRequirements PeerToHostRequirements { get; }

		public string MeasurementServerAddressesJson { get; }

		public bool ClientMatchmakingCapable { get; }

		public XblMultiplayerSessionCapabilities SessionCapabilities { get; }

		internal XblMultiplayerSessionConstants(Unity.XGamingRuntime.Interop.XblMultiplayerSessionConstants interopStruct)
		{
		}
	}
}
