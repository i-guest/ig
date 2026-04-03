using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworking : SteamInterface
	{
		public const string Version = "SteamNetworking006";

		internal ISteamNetworking(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamNetworking_v006();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _SendP2PPacket(IntPtr self, SteamId steamIDRemote, IntPtr pubData, uint cubData, P2PSend eP2PSendType, int nChannel);

		internal bool SendP2PPacket(SteamId steamIDRemote, IntPtr pubData, uint cubData, P2PSend eP2PSendType, int nChannel)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _IsP2PPacketAvailable(IntPtr self, ref uint pcubMsgSize, int nChannel);

		internal bool IsP2PPacketAvailable(ref uint pcubMsgSize, int nChannel)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ReadP2PPacket(IntPtr self, IntPtr pubDest, uint cubDest, ref uint pcubMsgSize, ref SteamId psteamIDRemote, int nChannel);

		internal bool ReadP2PPacket(IntPtr pubDest, uint cubDest, ref uint pcubMsgSize, ref SteamId psteamIDRemote, int nChannel)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AcceptP2PSessionWithUser(IntPtr self, SteamId steamIDRemote);

		internal bool AcceptP2PSessionWithUser(SteamId steamIDRemote)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CloseP2PSessionWithUser(IntPtr self, SteamId steamIDRemote);

		internal bool CloseP2PSessionWithUser(SteamId steamIDRemote)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CloseP2PChannelWithUser(IntPtr self, SteamId steamIDRemote, int nChannel);

		internal bool CloseP2PChannelWithUser(SteamId steamIDRemote, int nChannel)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetP2PSessionState(IntPtr self, SteamId steamIDRemote, ref P2PSessionState_t pConnectionState);

		internal bool GetP2PSessionState(SteamId steamIDRemote, ref P2PSessionState_t pConnectionState)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AllowP2PPacketRelay(IntPtr self, bool bAllow);

		internal bool AllowP2PPacketRelay(bool bAllow)
		{
			return false;
		}

		[PreserveSig]
		private static extern SNetSocket_t _CreateP2PConnectionSocket(IntPtr self, SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		internal SNetSocket_t CreateP2PConnectionSocket(SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}
	}
}
