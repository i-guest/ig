using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamVideo : SteamInterface
	{
		public const string Version = "STEAMVIDEO_INTERFACE_V007";

		internal ISteamVideo(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamVideo_v007();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern void _GetVideoURL(IntPtr self, AppId unVideoAppID);

		internal void GetVideoURL(AppId unVideoAppID)
		{
		}

		[PreserveSig]
		private static extern bool _IsBroadcasting(IntPtr self, ref int pnNumViewers);

		internal bool IsBroadcasting(ref int pnNumViewers)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _GetOPFSettings(IntPtr self, AppId unVideoAppID);

		internal void GetOPFSettings(AppId unVideoAppID)
		{
		}

		[PreserveSig]
		private static extern bool _GetOPFStringForApp(IntPtr self, AppId unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);

		internal bool GetOPFStringForApp(AppId unVideoAppID, out string pchBuffer)
		{
			pchBuffer = null;
			return false;
		}
	}
}
