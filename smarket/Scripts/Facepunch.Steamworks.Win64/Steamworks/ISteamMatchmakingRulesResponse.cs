using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamMatchmakingRulesResponse : SteamInterface
	{
		internal ISteamMatchmakingRulesResponse(bool IsGameServer)
		{
		}

		[PreserveSig]
		private static extern void _RulesResponded(IntPtr self, string pchRule, string pchValue);

		internal void RulesResponded(string pchRule, string pchValue)
		{
		}

		[PreserveSig]
		private static extern void _RulesFailedToRespond(IntPtr self);

		internal void RulesFailedToRespond()
		{
		}

		[PreserveSig]
		private static extern void _RulesRefreshComplete(IntPtr self);

		internal void RulesRefreshComplete()
		{
		}
	}
}
