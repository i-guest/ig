using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamMatchmakingServerListResponse : SteamInterface
	{
		internal ISteamMatchmakingServerListResponse(bool IsGameServer)
		{
		}

		[PreserveSig]
		private static extern void _ServerResponded(IntPtr self, HServerListRequest hRequest, int iServer);

		internal void ServerResponded(HServerListRequest hRequest, int iServer)
		{
		}

		[PreserveSig]
		private static extern void _ServerFailedToRespond(IntPtr self, HServerListRequest hRequest, int iServer);

		internal void ServerFailedToRespond(HServerListRequest hRequest, int iServer)
		{
		}

		[PreserveSig]
		private static extern void _RefreshComplete(IntPtr self, HServerListRequest hRequest, MatchMakingServerResponse response);

		internal void RefreshComplete(HServerListRequest hRequest, MatchMakingServerResponse response)
		{
		}
	}
}
