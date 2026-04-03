using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerActivityInfo
	{
		public ulong Xuid { get; set; }

		public string ConnectionString { get; set; }

		public XblMultiplayerActivityJoinRestriction JoinRestriction { get; set; }

		public uint MaxPlayers { get; set; }

		public uint CurrentPlayers { get; set; }

		public string GroupId { get; set; }

		public XblMultiplayerActivityPlatform Platform { get; set; }

		public XblMultiplayerActivityInfo()
		{
		}

		internal XblMultiplayerActivityInfo(Unity.XGamingRuntime.Interop.XblMultiplayerActivityInfo interopStruct)
		{
		}
	}
}
