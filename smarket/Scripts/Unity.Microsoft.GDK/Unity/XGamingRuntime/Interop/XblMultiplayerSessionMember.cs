using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerSessionMember
	{
		internal uint MemberId;

		internal UTF8StringPtr TeamId;

		internal UTF8StringPtr InitialTeam;

		internal XblTournamentArbitrationStatus ArbitrationStatus;

		internal ulong Xuid;

		internal UTF8StringPtr CustomConstantsJson;

		internal UTF8StringPtr SecureDeviceBaseAddress64;

		private readonly IntPtr Roles;

		private readonly SizeT RolesCount;

		internal UTF8StringPtr CustomPropertiesJson;

		private unsafe fixed byte Gamertag[48];

		internal XblMultiplayerSessionMemberStatus Status;

		internal bool IsTurnAvailable;

		internal bool IsCurrentUser;

		internal bool InitializeRequested;

		internal UTF8StringPtr MatchmakingResultServerMeasurementsJson;

		internal UTF8StringPtr ServerMeasurementsJson;

		private readonly IntPtr MembersInGroupIds;

		private readonly SizeT MembersInGroupCount;

		internal UTF8StringPtr QosMeasurementsJson;

		internal XblDeviceToken DeviceToken;

		internal XblNetworkAddressTranslationSetting Nat;

		internal uint ActiveTitleId;

		internal uint InitializationEpisode;

		internal TimeT JoinTime;

		internal XblMultiplayerMeasurementFailure InitializationFailureCause;

		private readonly IntPtr Groups;

		private readonly SizeT GroupsCount;

		private readonly IntPtr Encounters;

		private readonly SizeT EncountersCount;

		internal XblMultiplayerSessionReference TournamentTeamSessionReference;

		internal readonly IntPtr Internal;

		internal string GetGamertag()
		{
			return null;
		}

		internal T[] GetRoles<T>(Func<XblMultiplayerSessionMemberRole, T> ctor)
		{
			return null;
		}

		internal T[] GetMembersInGroupIds<T>(Func<uint, T> ctor)
		{
			return null;
		}

		internal string[] GetGroups()
		{
			return null;
		}

		internal string[] GetEncounters()
		{
			return null;
		}
	}
}
