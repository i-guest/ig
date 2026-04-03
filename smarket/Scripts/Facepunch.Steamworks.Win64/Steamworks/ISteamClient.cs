using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamClient : SteamInterface
	{
		internal ISteamClient(bool IsGameServer)
		{
		}

		[PreserveSig]
		private static extern HSteamPipe _CreateSteamPipe(IntPtr self);

		internal HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		[PreserveSig]
		private static extern bool _BReleaseSteamPipe(IntPtr self, HSteamPipe hSteamPipe);

		internal bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return false;
		}

		[PreserveSig]
		private static extern HSteamUser _ConnectToGlobalUser(IntPtr self, HSteamPipe hSteamPipe);

		internal HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		[PreserveSig]
		private static extern HSteamUser _CreateLocalUser(IntPtr self, ref HSteamPipe phSteamPipe, AccountType eAccountType);

		internal HSteamUser CreateLocalUser(ref HSteamPipe phSteamPipe, AccountType eAccountType)
		{
			return default(HSteamUser);
		}

		[PreserveSig]
		private static extern void _ReleaseUser(IntPtr self, HSteamPipe hSteamPipe, HSteamUser hUser);

		internal void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamUser(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamGameServer(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern void _SetLocalIPBinding(IntPtr self, ref SteamIPAddress unIP, ushort usPort);

		internal void SetLocalIPBinding(ref SteamIPAddress unIP, ushort usPort)
		{
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamFriends(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamUtils(IntPtr self, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamMatchmaking(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamMatchmakingServers(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamGenericInterface(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamUserStats(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamGameServerStats(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamApps(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamNetworking(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamRemoteStorage(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamScreenshots(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamGameSearch(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern uint _GetIPCCallCount(IntPtr self);

		internal uint GetIPCCallCount()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern void _SetWarningMessageHook(IntPtr self, IntPtr pFunction);

		internal void SetWarningMessageHook(IntPtr pFunction)
		{
		}

		[PreserveSig]
		private static extern bool _BShutdownIfAllPipesClosed(IntPtr self);

		internal bool BShutdownIfAllPipesClosed()
		{
			return false;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamHTTP(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamController(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamUGC(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamMusic(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamMusicRemote(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamHTMLSurface(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamInventory(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamVideo(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamParentalSettings(IntPtr self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamInput(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamParties(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern IntPtr _GetISteamRemotePlay(IntPtr self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion);

		internal IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return (IntPtr)0;
		}
	}
}
