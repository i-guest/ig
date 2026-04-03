using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal static class SteamInternal
	{
		internal static class Native
		{
			[PreserveSig]
			public static extern SteamAPIInitResult SteamInternal_GameServer_Init_V2(uint unIP, ushort usGamePort, ushort usQueryPort, int eServerMode, string pchVersionString, string pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg);
		}

		internal static SteamAPIInitResult GameServer_Init(uint unIP, ushort usGamePort, ushort usQueryPort, int eServerMode, string pchVersionString, string pszInternalCheckInterfaceVersions, out string pOutErrMsg)
		{
			pOutErrMsg = null;
			return default(SteamAPIInitResult);
		}
	}
}
