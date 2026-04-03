using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworkingFakeUDPPort : SteamInterface
	{
		internal ISteamNetworkingFakeUDPPort(bool IsGameServer)
		{
		}

		[PreserveSig]
		private static extern void _DestroyFakeUDPPort(IntPtr self);

		internal void DestroyFakeUDPPort()
		{
		}

		[PreserveSig]
		private static extern Result _SendMessageToFakeIP(IntPtr self, ref NetAddress remoteAddress, IntPtr pData, uint cbData, int nSendFlags);

		internal Result SendMessageToFakeIP(ref NetAddress remoteAddress, IntPtr pData, uint cbData, int nSendFlags)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern int _ReceiveMessages(IntPtr self, IntPtr ppOutMessages, int nMaxMessages);

		internal int ReceiveMessages(IntPtr ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _ScheduleCleanup(IntPtr self, ref NetAddress remoteAddress);

		internal void ScheduleCleanup(ref NetAddress remoteAddress)
		{
		}
	}
}
