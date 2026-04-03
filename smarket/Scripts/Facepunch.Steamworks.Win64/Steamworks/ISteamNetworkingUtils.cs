using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworkingUtils : SteamInterface
	{
		public const string Version = "SteamNetworkingUtils004";

		internal ISteamNetworkingUtils(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004();

		public override IntPtr GetGlobalInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private unsafe static extern NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer);

		internal unsafe NetMsg* AllocateMessage(int cbAllocateBuffer)
		{
			return null;
		}

		[PreserveSig]
		private static extern void _InitRelayNetworkAccess(IntPtr self);

		internal void InitRelayNetworkAccess()
		{
		}

		[PreserveSig]
		private static extern SteamNetworkingAvailability _GetRelayNetworkStatus(IntPtr self, ref SteamRelayNetworkStatus_t pDetails);

		internal SteamNetworkingAvailability GetRelayNetworkStatus(ref SteamRelayNetworkStatus_t pDetails)
		{
			return default(SteamNetworkingAvailability);
		}

		[PreserveSig]
		private static extern float _GetLocalPingLocation(IntPtr self, ref NetPingLocation result);

		internal float GetLocalPingLocation(ref NetPingLocation result)
		{
			return 0f;
		}

		[PreserveSig]
		private static extern int _EstimatePingTimeBetweenTwoLocations(IntPtr self, ref NetPingLocation location1, ref NetPingLocation location2);

		internal int EstimatePingTimeBetweenTwoLocations(ref NetPingLocation location1, ref NetPingLocation location2)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _EstimatePingTimeFromLocalHost(IntPtr self, ref NetPingLocation remoteLocation);

		internal int EstimatePingTimeFromLocalHost(ref NetPingLocation remoteLocation)
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _ConvertPingLocationToString(IntPtr self, ref NetPingLocation location, IntPtr pszBuf, int cchBufSize);

		internal void ConvertPingLocationToString(ref NetPingLocation location, out string pszBuf)
		{
			pszBuf = null;
		}

		[PreserveSig]
		private static extern bool _ParsePingLocationString(IntPtr self, string pszString, ref NetPingLocation result);

		internal bool ParsePingLocationString(string pszString, ref NetPingLocation result)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _CheckPingDataUpToDate(IntPtr self, float flMaxAgeSeconds);

		internal bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetPingToDataCenter(IntPtr self, SteamNetworkingPOPID popID, ref SteamNetworkingPOPID pViaRelayPoP);

		internal int GetPingToDataCenter(SteamNetworkingPOPID popID, ref SteamNetworkingPOPID pViaRelayPoP)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetDirectPingToPOP(IntPtr self, SteamNetworkingPOPID popID);

		internal int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetPOPCount(IntPtr self);

		internal int GetPOPCount()
		{
			return 0;
		}

		[PreserveSig]
		private static extern int _GetPOPList(IntPtr self, ref SteamNetworkingPOPID list, int nListSz);

		internal int GetPOPList(ref SteamNetworkingPOPID list, int nListSz)
		{
			return 0;
		}

		[PreserveSig]
		private static extern long _GetLocalTimestamp(IntPtr self);

		internal long GetLocalTimestamp()
		{
			return 0L;
		}

		[PreserveSig]
		private static extern void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc);

		internal void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc)
		{
		}

		[PreserveSig]
		private static extern bool _IsFakeIPv4(IntPtr self, uint nIPv4);

		internal bool IsFakeIPv4(uint nIPv4)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamNetworkingFakeIPType _GetIPv4FakeIPType(IntPtr self, uint nIPv4);

		internal SteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
		{
			return default(SteamNetworkingFakeIPType);
		}

		[PreserveSig]
		private static extern Result _GetRealIdentityForFakeIP(IntPtr self, ref NetAddress fakeIP, [In][Out] NetIdentity[] pOutRealIdentity);

		internal Result GetRealIdentityForFakeIP(ref NetAddress fakeIP, [In][Out] NetIdentity[] pOutRealIdentity)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern bool _SetGlobalConfigValueInt32(IntPtr self, NetConfig eValue, int val);

		internal bool SetGlobalConfigValueInt32(NetConfig eValue, int val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalConfigValueFloat(IntPtr self, NetConfig eValue, float val);

		internal bool SetGlobalConfigValueFloat(NetConfig eValue, float val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalConfigValueString(IntPtr self, NetConfig eValue, string val);

		internal bool SetGlobalConfigValueString(NetConfig eValue, string val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalConfigValuePtr(IntPtr self, NetConfig eValue, IntPtr val);

		internal bool SetGlobalConfigValuePtr(NetConfig eValue, IntPtr val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConnectionConfigValueInt32(IntPtr self, Connection hConn, NetConfig eValue, int val);

		internal bool SetConnectionConfigValueInt32(Connection hConn, NetConfig eValue, int val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConnectionConfigValueFloat(IntPtr self, Connection hConn, NetConfig eValue, float val);

		internal bool SetConnectionConfigValueFloat(Connection hConn, NetConfig eValue, float val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConnectionConfigValueString(IntPtr self, Connection hConn, NetConfig eValue, string val);

		internal bool SetConnectionConfigValueString(Connection hConn, NetConfig eValue, string val)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalCallback_SteamNetConnectionStatusChanged(IntPtr self, FnSteamNetConnectionStatusChanged fnCallback);

		internal bool SetGlobalCallback_SteamNetConnectionStatusChanged(FnSteamNetConnectionStatusChanged fnCallback)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalCallback_SteamNetAuthenticationStatusChanged(IntPtr self, FnSteamNetAuthenticationStatusChanged fnCallback);

		internal bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(FnSteamNetAuthenticationStatusChanged fnCallback)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalCallback_SteamRelayNetworkStatusChanged(IntPtr self, FnSteamRelayNetworkStatusChanged fnCallback);

		internal bool SetGlobalCallback_SteamRelayNetworkStatusChanged(FnSteamRelayNetworkStatusChanged fnCallback)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalCallback_FakeIPResult(IntPtr self, FnSteamNetworkingFakeIPResult fnCallback);

		internal bool SetGlobalCallback_FakeIPResult(FnSteamNetworkingFakeIPResult fnCallback)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalCallback_MessagesSessionRequest(IntPtr self, FnSteamNetworkingMessagesSessionRequest fnCallback);

		internal bool SetGlobalCallback_MessagesSessionRequest(FnSteamNetworkingMessagesSessionRequest fnCallback)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetGlobalCallback_MessagesSessionFailed(IntPtr self, FnSteamNetworkingMessagesSessionFailed fnCallback);

		internal bool SetGlobalCallback_MessagesSessionFailed(FnSteamNetworkingMessagesSessionFailed fnCallback)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg);

		internal bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetConfigValueStruct(IntPtr self, ref NetKeyValue opt, NetConfigScope eScopeType, IntPtr scopeObj);

		internal bool SetConfigValueStruct(ref NetKeyValue opt, NetConfigScope eScopeType, IntPtr scopeObj)
		{
			return false;
		}

		[PreserveSig]
		private static extern NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult);

		internal NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult)
		{
			return default(NetConfigResult);
		}

		[PreserveSig]
		private static extern Utf8StringPointer _GetConfigValueInfo(IntPtr self, NetConfig eValue, ref NetConfigType pOutDataType, [In][Out] NetConfigScope[] pOutScope);

		internal string GetConfigValueInfo(NetConfig eValue, ref NetConfigType pOutDataType, [In][Out] NetConfigScope[] pOutScope)
		{
			return null;
		}

		[PreserveSig]
		private static extern NetConfig _IterateGenericEditableConfigValues(IntPtr self, NetConfig eCurrent, bool bEnumerateDevVars);

		internal NetConfig IterateGenericEditableConfigValues(NetConfig eCurrent, bool bEnumerateDevVars)
		{
			return default(NetConfig);
		}

		[PreserveSig]
		private static extern void _SteamNetworkingIPAddr_ToString(IntPtr self, ref NetAddress addr, IntPtr buf, uint cbBuf, bool bWithPort);

		internal void SteamNetworkingIPAddr_ToString(ref NetAddress addr, out string buf, bool bWithPort)
		{
			buf = null;
		}

		[PreserveSig]
		private static extern bool _SteamNetworkingIPAddr_ParseString(IntPtr self, ref NetAddress pAddr, string pszStr);

		internal bool SteamNetworkingIPAddr_ParseString(ref NetAddress pAddr, string pszStr)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamNetworkingFakeIPType _SteamNetworkingIPAddr_GetFakeIPType(IntPtr self, ref NetAddress addr);

		internal SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref NetAddress addr)
		{
			return default(SteamNetworkingFakeIPType);
		}

		[PreserveSig]
		private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf);

		internal void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf)
		{
			buf = null;
		}

		[PreserveSig]
		private static extern bool _SteamNetworkingIdentity_ParseString(IntPtr self, ref NetIdentity pIdentity, string pszStr);

		internal bool SteamNetworkingIdentity_ParseString(ref NetIdentity pIdentity, string pszStr)
		{
			return false;
		}
	}
}
