using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworkingSockets : SteamInterface
	{
		public const string Version = "SteamNetworkingSockets012";

		internal ISteamNetworkingSockets(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Socket);
		}

		[PreserveSig]
		private static extern Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Connection);
		}

		[PreserveSig]
		private static extern Socket _CreateListenSocketP2P(IntPtr self, int nLocalVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Socket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Socket);
		}

		[PreserveSig]
		private static extern Connection _ConnectP2P(IntPtr self, ref NetIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Connection ConnectP2P(ref NetIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Connection);
		}

		[PreserveSig]
		private static extern Result _AcceptConnection(IntPtr self, Connection hConn);

		internal Result AcceptConnection(Connection hConn)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger);

		internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CloseListenSocket(IntPtr self, Socket hSocket);

		internal bool CloseListenSocket(Socket hSocket)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConnectionUserData(IntPtr self, Connection hPeer, long nUserData);

		internal bool SetConnectionUserData(Connection hPeer, long nUserData)
		{
			return false;
		}

		[PreserveSig]
		private static extern long _GetConnectionUserData(IntPtr self, Connection hPeer);

		internal long GetConnectionUserData(Connection hPeer)
		{
			return 0L;
		}

		[PreserveSig]
		private static extern void _SetConnectionName(IntPtr self, Connection hPeer, string pszName);

		internal void SetConnectionName(Connection hPeer, string pszName)
		{
		}

		[PreserveSig]
		private static extern bool _GetConnectionName(IntPtr self, Connection hPeer, IntPtr pszName, int nMaxLen);

		internal bool GetConnectionName(Connection hPeer, out string pszName)
		{
			pszName = null;
			return false;
		}

		[PreserveSig]
		private static extern Result _SendMessageToConnection(IntPtr self, Connection hConn, IntPtr pData, uint cbData, int nSendFlags, ref long pOutMessageNumber);

		internal Result SendMessageToConnection(Connection hConn, IntPtr pData, uint cbData, int nSendFlags, ref long pOutMessageNumber)
		{
			return default(Result);
		}

		[PreserveSig]
		private unsafe static extern void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult);

		internal unsafe void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult)
		{
		}

		[PreserveSig]
		private static extern Result _FlushMessagesOnConnection(IntPtr self, Connection hConn);

		internal Result FlushMessagesOnConnection(Connection hConn)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages);

		internal int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetConnectionInfo(IntPtr self, Connection hConn, ref ConnectionInfo pInfo);

		internal bool GetConnectionInfo(Connection hConn, ref ConnectionInfo pInfo)
		{
			return false;
		}

		[PreserveSig]
		private static extern Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In][Out] ConnectionLaneStatus[] pLanes);

		internal Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In][Out] ConnectionLaneStatus[] pLanes)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf);

		internal int GetDetailedConnectionStatus(Connection hConn, out string pszBuf)
		{
			pszBuf = null;
			return 0;
		}

		[PreserveSig]
		private static extern bool _GetListenSocketAddress(IntPtr self, Socket hSocket, ref NetAddress address);

		internal bool GetListenSocketAddress(Socket hSocket, ref NetAddress address)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CreateSocketPair(IntPtr self, [In][Out] Connection[] pOutConnection1, [In][Out] Connection[] pOutConnection2, bool bUseNetworkLoopback, ref NetIdentity pIdentity1, ref NetIdentity pIdentity2);

		internal bool CreateSocketPair([In][Out] Connection[] pOutConnection1, [In][Out] Connection[] pOutConnection2, bool bUseNetworkLoopback, ref NetIdentity pIdentity1, ref NetIdentity pIdentity2)
		{
			return false;
		}

		[PreserveSig]
		private static extern Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In][Out] int[] pLanePriorities, [In][Out] ushort[] pLaneWeights);

		internal Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In][Out] int[] pLanePriorities, [In][Out] ushort[] pLaneWeights)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity);

		internal bool GetIdentity(ref NetIdentity pIdentity)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamNetworkingAvailability _InitAuthentication(IntPtr self);

		internal SteamNetworkingAvailability InitAuthentication()
		{
			return default(SteamNetworkingAvailability);
		}

		[PreserveSig]
		private static extern SteamNetworkingAvailability _GetAuthenticationStatus(IntPtr self, ref SteamNetAuthenticationStatus_t pDetails);

		internal SteamNetworkingAvailability GetAuthenticationStatus(ref SteamNetAuthenticationStatus_t pDetails)
		{
			return default(SteamNetworkingAvailability);
		}

		[PreserveSig]
		private static extern HSteamNetPollGroup _CreatePollGroup(IntPtr self);

		internal HSteamNetPollGroup CreatePollGroup()
		{
			return default(HSteamNetPollGroup);
		}

		[PreserveSig]
		private static extern bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup);

		internal bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup);

		internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages);

		internal int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		[PreserveSig]
		private static extern bool _ReceivedRelayAuthTicket(IntPtr self, IntPtr pvTicket, int cbTicket, [In][Out] SteamDatagramRelayAuthTicket[] pOutParsedTicket);

		internal bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, [In][Out] SteamDatagramRelayAuthTicket[] pOutParsedTicket)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _FindRelayAuthTicketForServer(IntPtr self, ref NetIdentity identityGameServer, int nRemoteVirtualPort, [In][Out] SteamDatagramRelayAuthTicket[] pOutParsedTicket);

		internal int FindRelayAuthTicketForServer(ref NetIdentity identityGameServer, int nRemoteVirtualPort, [In][Out] SteamDatagramRelayAuthTicket[] pOutParsedTicket)
		{
			return 0;
		}

		[PreserveSig]
		private static extern Connection _ConnectToHostedDedicatedServer(IntPtr self, ref NetIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Connection ConnectToHostedDedicatedServer(ref NetIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Connection);
		}

		[PreserveSig]
		private static extern ushort _GetHostedDedicatedServerPort(IntPtr self);

		internal ushort GetHostedDedicatedServerPort()
		{
			return 0;
		}

		[PreserveSig]
		private static extern SteamNetworkingPOPID _GetHostedDedicatedServerPOPID(IntPtr self);

		internal SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			return default(SteamNetworkingPOPID);
		}

		[PreserveSig]
		private static extern Result _GetHostedDedicatedServerAddress(IntPtr self, ref SteamDatagramHostedAddress pRouting);

		internal Result GetHostedDedicatedServerAddress(ref SteamDatagramHostedAddress pRouting)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern Socket _CreateHostedDedicatedServerListenSocket(IntPtr self, int nLocalVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Socket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Socket);
		}

		[PreserveSig]
		private static extern Result _GetGameCoordinatorServerLogin(IntPtr self, ref SteamDatagramGameCoordinatorServerLogin pLoginInfo, ref int pcbSignedBlob, IntPtr pBlob);

		internal Result GetGameCoordinatorServerLogin(ref SteamDatagramGameCoordinatorServerLogin pLoginInfo, ref int pcbSignedBlob, IntPtr pBlob)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern Connection _ConnectP2PCustomSignaling(IntPtr self, IntPtr pSignaling, ref NetIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Connection ConnectP2PCustomSignaling(IntPtr pSignaling, ref NetIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Connection);
		}

		[PreserveSig]
		private static extern bool _ReceivedP2PCustomSignal(IntPtr self, IntPtr pMsg, int cbMsg, IntPtr pContext);

		internal bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, IntPtr pContext)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetCertificateRequest(IntPtr self, ref int pcbBlob, IntPtr pBlob, ref NetErrorMessage errMsg);

		internal bool GetCertificateRequest(ref int pcbBlob, IntPtr pBlob, ref NetErrorMessage errMsg)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetCertificate(IntPtr self, IntPtr pCertificate, int cbCertificate, ref NetErrorMessage errMsg);

		internal bool SetCertificate(IntPtr pCertificate, int cbCertificate, ref NetErrorMessage errMsg)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _ResetIdentity(IntPtr self, ref NetIdentity pIdentity);

		internal void ResetIdentity(ref NetIdentity pIdentity)
		{
		}

		[PreserveSig]
		private static extern void _RunCallbacks(IntPtr self);

		internal void RunCallbacks()
		{
		}

		[PreserveSig]
		private static extern bool _BeginAsyncRequestFakeIP(IntPtr self, int nNumPorts);

		internal bool BeginAsyncRequestFakeIP(int nNumPorts)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo);

		internal void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo)
		{
		}

		[PreserveSig]
		private static extern Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In][Out] NetKeyValue[] pOptions);

		internal Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In][Out] NetKeyValue[] pOptions)
		{
			return default(Socket);
		}

		[PreserveSig]
		private static extern Result _GetRemoteFakeIPForConnection(IntPtr self, Connection hConn, [In][Out] NetAddress[] pOutAddr);

		internal Result GetRemoteFakeIPForConnection(Connection hConn, [In][Out] NetAddress[] pOutAddr)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern IntPtr _CreateFakeUDPPort(IntPtr self, int idxFakeServerPort);

		internal IntPtr CreateFakeUDPPort(int idxFakeServerPort)
		{
			return (IntPtr)0;
		}
	}
}
