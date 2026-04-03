using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal static class SteamGameServer
	{
		internal static class Native
		{
			[PreserveSig]
			public static extern void SteamGameServer_RunCallbacks();

			[PreserveSig]
			public static extern void SteamGameServer_Shutdown();

			[PreserveSig]
			public static extern HSteamPipe SteamGameServer_GetHSteamPipe();
		}

		internal static void RunCallbacks()
		{
		}

		internal static void Shutdown()
		{
		}

		internal static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}
	}
}
