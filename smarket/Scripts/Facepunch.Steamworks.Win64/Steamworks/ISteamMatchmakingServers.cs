using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamMatchmakingServers : SteamInterface
	{
		public const string Version = "SteamMatchMakingServers002";

		private static int hasSuccessfulResponseOffset;

		internal ISteamMatchmakingServers(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		internal HServerListRequest RequestInternetServerList(AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[PreserveSig]
		private static extern HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse);

		internal HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[PreserveSig]
		private static extern HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		internal HServerListRequest RequestFriendsServerList(AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[PreserveSig]
		private static extern HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		internal HServerListRequest RequestFavoritesServerList(AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[PreserveSig]
		private static extern HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		internal HServerListRequest RequestHistoryServerList(AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[PreserveSig]
		private static extern HServerListRequest _RequestSpectatorServerList(IntPtr self, AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		internal HServerListRequest RequestSpectatorServerList(AppId iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[PreserveSig]
		private static extern void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest);

		internal void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		[PreserveSig]
		private static extern IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer);

		internal gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return default(gameserveritem_t);
		}

		[PreserveSig]
		private static extern void _CancelQuery(IntPtr self, HServerListRequest hRequest);

		internal void CancelQuery(HServerListRequest hRequest)
		{
		}

		[PreserveSig]
		private static extern void _RefreshQuery(IntPtr self, HServerListRequest hRequest);

		internal void RefreshQuery(HServerListRequest hRequest)
		{
		}

		[PreserveSig]
		private static extern bool _IsRefreshing(IntPtr self, HServerListRequest hRequest);

		internal bool IsRefreshing(HServerListRequest hRequest)
		{
			return false;
		}

		[PreserveSig]
		private static extern int _GetServerCount(IntPtr self, HServerListRequest hRequest);

		internal int GetServerCount(HServerListRequest hRequest)
		{
			return 0;
		}

		[PreserveSig]
		private static extern void _RefreshServer(IntPtr self, HServerListRequest hRequest, int iServer);

		internal void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		[PreserveSig]
		private static extern HServerQuery _PingServer(IntPtr self, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		internal HServerQuery PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[PreserveSig]
		private static extern HServerQuery _PlayerDetails(IntPtr self, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		internal HServerQuery PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[PreserveSig]
		private static extern HServerQuery _ServerRules(IntPtr self, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		internal HServerQuery ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[PreserveSig]
		private static extern void _CancelServerQuery(IntPtr self, HServerQuery hServerQuery);

		internal void CancelServerQuery(HServerQuery hServerQuery)
		{
		}

		internal bool HasServerResponded(HServerListRequest hRequest, int iServer)
		{
			return false;
		}
	}
}
