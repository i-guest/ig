using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamServer : SteamServerClass<SteamServer>
	{
		private static readonly List<SteamClass> openInterfaces;

		private static bool _dedicatedServer;

		private static int _maxplayers;

		private static int _botcount;

		private static string _mapname;

		private static string _modDir;

		private static string _product;

		private static string _gameDescription;

		private static string _serverName;

		private static bool _passworded;

		private static string _gametags;

		private static Dictionary<string, string> KeyValue;

		internal static ISteamGameServer Internal => null;

		public static bool IsValid => false;

		public static bool DedicatedServer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int MaxPlayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int BotCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string MapName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string ModDir
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public static string Product
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public static string GameDescription
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public static string ServerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool Passworded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string GameTags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static SteamId SteamId => default(SteamId);

		public static bool LoggedOn => false;

		public static IPAddress PublicIp => null;

		[Obsolete("Renamed to AdvertiseServer in 1.52")]
		public static bool AutomaticHeartbeats
		{
			set
			{
			}
		}

		public static bool AdvertiseServer
		{
			set
			{
			}
		}

		public static event Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse
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

		public static event Action OnSteamServersConnected
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

		public static event Action<Result, bool> OnSteamServerConnectFailure
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

		public static event Action<Result> OnSteamServersDisconnected
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

		public static event Action<SteamNetworkingAvailability> OnSteamNetAuthenticationStatus
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

		internal static void InstallEvents()
		{
		}

		public static void Init(AppId appid, SteamServerInit init, bool asyncCallbacks = true)
		{
		}

		internal static void AddInterface<T>() where T : SteamClass, new()
		{
		}

		internal static void ShutdownInterfaces()
		{
		}

		public static void Shutdown()
		{
		}

		public static void RunCallbacks()
		{
		}

		public static void LogOnAnonymous()
		{
		}

		public static void LogOff()
		{
		}

		[Obsolete("No longer used")]
		public static void ForceHeartbeat()
		{
		}

		public static void UpdatePlayer(SteamId steamid, string name, int score)
		{
		}

		public static void SetKey(string Key, string Value)
		{
		}

		public static void ClearKeys()
		{
		}

		public static bool BeginAuthSession(byte[] data, SteamId steamid)
		{
			return false;
		}

		public static void EndSession(SteamId steamid)
		{
		}

		public static bool GetOutgoingPacket(out OutgoingPacket packet)
		{
			packet = default(OutgoingPacket);
			return false;
		}

		public static void HandleIncomingPacket(byte[] data, int size, uint address, ushort port)
		{
		}

		public static void HandleIncomingPacket(IntPtr ptr, int size, uint address, ushort port)
		{
		}

		public static UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamid, AppId appid)
		{
			return default(UserHasLicenseForAppResult);
		}
	}
}
