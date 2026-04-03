using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal static class SteamAPI
	{
		internal static class Native
		{
			[PreserveSig]
			public static extern SteamAPIInitResult SteamInternal_SteamAPI_Init(string pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg);

			[PreserveSig]
			public static extern void SteamAPI_Shutdown();

			[PreserveSig]
			public static extern HSteamPipe SteamAPI_GetHSteamPipe();

			[PreserveSig]
			public static extern bool SteamAPI_RestartAppIfNecessary(uint unOwnAppID);
		}

		internal static SteamAPIInitResult Init(string pszInternalCheckInterfaceVersions, out string pOutErrMsg)
		{
			pOutErrMsg = null;
			return default(SteamAPIInitResult);
		}

		internal static void Shutdown()
		{
		}

		internal static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		internal static bool RestartAppIfNecessary(uint unOwnAppID)
		{
			return false;
		}
	}
}
