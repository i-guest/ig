using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal class ISteamAppList : SteamInterface
	{
		internal ISteamAppList(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamAppList_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern uint _GetNumInstalledApps(IntPtr self);

		internal uint GetNumInstalledApps()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern uint _GetInstalledApps(IntPtr self, [In][Out] AppId[] pvecAppID, uint unMaxAppIDs);

		internal uint GetInstalledApps([In][Out] AppId[] pvecAppID, uint unMaxAppIDs)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern int _GetAppName(IntPtr self, AppId nAppID, IntPtr pchName, int cchNameMax);

		internal int GetAppName(AppId nAppID, out string pchName)
		{
			pchName = null;
			return 0;
		}

		[PreserveSig]
		private static extern int _GetAppInstallDir(IntPtr self, AppId nAppID, IntPtr pchDirectory, int cchNameMax);

		internal int GetAppInstallDir(AppId nAppID, out string pchDirectory)
		{
			pchDirectory = null;
			return 0;
		}

		[PreserveSig]
		private static extern int _GetAppBuildId(IntPtr self, AppId nAppID);

		internal int GetAppBuildId(AppId nAppID)
		{
			return 0;
		}
	}
}
