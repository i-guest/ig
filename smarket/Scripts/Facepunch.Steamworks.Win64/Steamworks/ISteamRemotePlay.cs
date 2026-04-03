using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamRemotePlay : SteamInterface
	{
		public const string Version = "STEAMREMOTEPLAY_INTERFACE_VERSION002";

		internal ISteamRemotePlay(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamRemotePlay_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern uint _GetSessionCount(IntPtr self);

		internal uint GetSessionCount()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern RemotePlaySessionID_t _GetSessionID(IntPtr self, int iSessionIndex);

		internal RemotePlaySessionID_t GetSessionID(int iSessionIndex)
		{
			return default(RemotePlaySessionID_t);
		}

		[PreserveSig]
		private static extern SteamId _GetSessionSteamID(IntPtr self, RemotePlaySessionID_t unSessionID);

		internal SteamId GetSessionSteamID(RemotePlaySessionID_t unSessionID)
		{
			return default(SteamId);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetSessionClientName(IntPtr self, RemotePlaySessionID_t unSessionID);

		internal string GetSessionClientName(RemotePlaySessionID_t unSessionID)
		{
			return null;
		}

		[PreserveSig]
		private static extern SteamDeviceFormFactor _GetSessionClientFormFactor(IntPtr self, RemotePlaySessionID_t unSessionID);

		internal SteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID)
		{
			return default(SteamDeviceFormFactor);
		}

		[PreserveSig]
		private static extern bool _BGetSessionClientResolution(IntPtr self, RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY);

		internal bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BStartRemotePlayTogether(IntPtr self, bool bShowOverlay);

		internal bool BStartRemotePlayTogether(bool bShowOverlay)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _BSendRemotePlayTogetherInvite(IntPtr self, SteamId steamIDFriend);

		internal bool BSendRemotePlayTogetherInvite(SteamId steamIDFriend)
		{
			return false;
		}
	}
}
