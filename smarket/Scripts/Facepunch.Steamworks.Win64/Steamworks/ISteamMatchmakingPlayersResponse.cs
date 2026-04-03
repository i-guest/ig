using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamMatchmakingPlayersResponse : SteamInterface
	{
		internal ISteamMatchmakingPlayersResponse(bool IsGameServer)
		{
		}

		[PreserveSig]
		private static extern void _AddPlayerToList(IntPtr self, string pchName, int nScore, float flTimePlayed);

		internal void AddPlayerToList(string pchName, int nScore, float flTimePlayed)
		{
		}

		[PreserveSig]
		private static extern void _PlayersFailedToRespond(IntPtr self);

		internal void PlayersFailedToRespond()
		{
		}

		[PreserveSig]
		private static extern void _PlayersRefreshComplete(IntPtr self);

		internal void PlayersRefreshComplete()
		{
		}
	}
}
