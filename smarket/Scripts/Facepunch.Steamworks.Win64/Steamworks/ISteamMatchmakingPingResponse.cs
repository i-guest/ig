using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamMatchmakingPingResponse : SteamInterface
	{
		internal ISteamMatchmakingPingResponse(bool IsGameServer)
		{
		}

		[PreserveSig]
		private static extern void _ServerResponded(IntPtr self, ref gameserveritem_t server);

		internal void ServerResponded(ref gameserveritem_t server)
		{
		}

		[PreserveSig]
		private static extern void _ServerFailedToRespond(IntPtr self);

		internal void ServerFailedToRespond()
		{
		}
	}
}
