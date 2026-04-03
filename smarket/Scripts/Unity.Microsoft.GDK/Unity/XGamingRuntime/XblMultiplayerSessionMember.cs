using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionMember
	{
		public uint MemberId { get; }

		public string TeamId { get; }

		public string InitialTeam { get; }

		public XblTournamentArbitrationStatus ArbitrationStatus { get; }

		public ulong Xuid { get; }

		public string CustomConstantsJson { get; }

		public string SecureDeviceBaseAddress64 { get; }

		public XblMultiplayerSessionMemberRole[] Roles { get; }

		public string CustomPropertiesJson { get; }

		public string Gamertag { get; }

		public XblMultiplayerSessionMemberStatus Status { get; }

		public bool IsTurnAvailable { get; }

		public bool IsCurrentUser { get; }

		public bool InitializeRequested { get; }

		public string MatchmakingResultServerMeasurementsJson { get; }

		public string ServerMeasurementsJson { get; }

		public uint[] MembersInGroupIds { get; }

		public string QosMeasurementsJson { get; }

		public XblDeviceToken DeviceToken { get; }

		public XblNetworkAddressTranslationSetting Nat { get; }

		public uint ActiveTitleId { get; }

		public uint InitializationEpisode { get; }

		public DateTime JoinTime { get; }

		public XblMultiplayerMeasurementFailure InitializationFailureCause { get; }

		public string[] Groups { get; }

		public string[] Encounters { get; }

		public XblMultiplayerSessionReference TournamentTeamSessionReference { get; }

		internal Unity.XGamingRuntime.Interop.XblMultiplayerSessionMember InteropHandle { get; }

		internal XblMultiplayerSessionMember(Unity.XGamingRuntime.Interop.XblMultiplayerSessionMember interopHandle)
		{
		}
	}
}
