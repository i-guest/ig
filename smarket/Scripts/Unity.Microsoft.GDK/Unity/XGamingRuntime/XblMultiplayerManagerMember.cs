using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerManagerMember
	{
		public uint MemberId { get; }

		public string TeamId { get; }

		public string InitialTeam { get; }

		public ulong Xuid { get; }

		public string DebugGamertag { get; }

		public bool IsLocal { get; }

		public bool IsInLobby { get; }

		public bool IsInGame { get; }

		public XblMultiplayerSessionMemberStatus Status { get; }

		public string ConnectionAddress { get; }

		public string PropertiesJson { get; }

		public string DeviceToken { get; }

		internal XblMultiplayerManagerMember(Unity.XGamingRuntime.Interop.XblMultiplayerManagerMember interopStruct)
		{
		}
	}
}
