using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerMatchmakingServer
	{
		public XblMatchmakingStatus Status { get; }

		public string StatusDetails { get; }

		public uint TypicalWaitInSeconds { get; }

		public XblMultiplayerSessionReference TargetSessionRef { get; }

		internal Unity.XGamingRuntime.Interop.XblMultiplayerMatchmakingServer InteropHandle { get; }

		internal XblMultiplayerMatchmakingServer(Unity.XGamingRuntime.Interop.XblMultiplayerMatchmakingServer interopHandle)
		{
		}
	}
}
