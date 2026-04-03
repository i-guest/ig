using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerSessionProperties
	{
		internal readonly IntPtr Keywords;

		internal readonly SizeT KeywordCount;

		internal XblMultiplayerSessionRestriction JoinRestriction;

		internal XblMultiplayerSessionRestriction ReadRestriction;

		private readonly IntPtr TurnCollection;

		private readonly SizeT TurnCollectionCount;

		internal readonly UTF8StringPtr MatchmakingTargetSessionConstantsJson;

		internal readonly UTF8StringPtr SessionCustomPropertiesJson;

		internal readonly UTF8StringPtr MatchmakingServerConnectionString;

		private readonly IntPtr ServerConnectionStringCandidates;

		private readonly SizeT ServerConnectionStringCandidatesCount;

		private readonly IntPtr SessionOwnerMemberIds;

		private readonly SizeT SessionOwnerMemberIdsCount;

		internal readonly XblDeviceToken HostDeviceToken;

		internal bool Closed;

		internal bool Locked;

		internal bool AllocateCloudCompute;

		internal bool MatchmakingResubmit;

		internal string[] GetKeywords()
		{
			return null;
		}

		internal T[] GetTurnCollection<T>(Func<uint, T> ctor)
		{
			return null;
		}

		internal string[] GetServerConnectionStringCandidates()
		{
			return null;
		}

		internal T[] GetSessionOwnerMemberIds<T>(Func<uint, T> ctor)
		{
			return null;
		}
	}
}
