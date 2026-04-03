using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamNetworkingSockets : SteamSharedClass<SteamNetworkingSockets>
	{
		private static readonly Dictionary<uint, SocketManager> SocketInterfaces;

		private static readonly Dictionary<uint, ConnectionManager> ConnectionInterfaces;

		internal static ISteamNetworkingSockets Internal => null;

		public static NetIdentity Identity => default(NetIdentity);

		public static event Action<Connection, ConnectionInfo> OnConnectionStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<NetAddress> OnFakeIPResult
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal static SocketManager GetSocketManager(uint id)
		{
			return null;
		}

		internal static void SetSocketManager(uint id, SocketManager manager)
		{
		}

		internal static ConnectionManager GetConnectionManager(uint id)
		{
			return null;
		}

		internal static void SetConnectionManager(uint id, ConnectionManager manager)
		{
		}

		internal void InstallEvents(bool server)
		{
		}

		private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data)
		{
		}

		private static void FakeIPResult(SteamNetworkingFakeIPResult_t data)
		{
		}

		public static T CreateNormalSocket<T>(NetAddress address) where T : SocketManager, new()
		{
			return null;
		}

		public static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface)
		{
			return null;
		}

		public static T ConnectNormal<T>(NetAddress address) where T : ConnectionManager, new()
		{
			return null;
		}

		public static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface)
		{
			return null;
		}

		public static T CreateRelaySocket<T>(int virtualport = 0) where T : SocketManager, new()
		{
			return null;
		}

		public static SocketManager CreateRelaySocket(int virtualport, ISocketManager intrface)
		{
			return null;
		}

		public static T ConnectRelay<T>(SteamId serverId, int virtualport = 0) where T : ConnectionManager, new()
		{
			return null;
		}

		public static ConnectionManager ConnectRelay(SteamId serverId, int virtualport, IConnectionManager iface)
		{
			return null;
		}

		public static bool RequestFakeIP(int numFakePorts = 1)
		{
			return false;
		}

		public static Result GetFakeIP(int fakePortIndex, out NetAddress address)
		{
			address = default(NetAddress);
			return default(Result);
		}

		public static T CreateRelaySocketFakeIP<T>(int fakePortIndex = 0) where T : SocketManager, new()
		{
			return null;
		}

		public static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface)
		{
			return null;
		}
	}
}
