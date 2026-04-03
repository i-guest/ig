using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworkingMessages : SteamInterface
	{
		public const string Version = "SteamNetworkingMessages002";

		internal ISteamNetworkingMessages(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamNetworkingMessages_SteamAPI_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern Result _SendMessageToUser(IntPtr self, ref NetIdentity identityRemote, [In][Out] IntPtr[] pubData, uint cubData, int nSendFlags, int nRemoteChannel);

		internal Result SendMessageToUser(ref NetIdentity identityRemote, [In][Out] IntPtr[] pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern int _ReceiveMessagesOnChannel(IntPtr self, int nLocalChannel, IntPtr ppOutMessages, int nMaxMessages);

		internal int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _AcceptSessionWithUser(IntPtr self, ref NetIdentity identityRemote);

		internal bool AcceptSessionWithUser(ref NetIdentity identityRemote)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CloseSessionWithUser(IntPtr self, ref NetIdentity identityRemote);

		internal bool CloseSessionWithUser(ref NetIdentity identityRemote)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CloseChannelWithUser(IntPtr self, ref NetIdentity identityRemote, int nLocalChannel);

		internal bool CloseChannelWithUser(ref NetIdentity identityRemote, int nLocalChannel)
		{
			return false;
		}

		[PreserveSig]
		private static extern ConnectionState _GetSessionConnectionInfo(IntPtr self, ref NetIdentity identityRemote, ref ConnectionInfo pConnectionInfo, ref ConnectionStatus pQuickStatus);

		internal ConnectionState GetSessionConnectionInfo(ref NetIdentity identityRemote, ref ConnectionInfo pConnectionInfo, ref ConnectionStatus pQuickStatus)
		{
			return default(ConnectionState);
		}
	}
}
