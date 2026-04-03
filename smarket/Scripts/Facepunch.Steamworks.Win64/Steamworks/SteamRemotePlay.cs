using System;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamRemotePlay : SteamClientClass<SteamRemotePlay>
	{
		internal static ISteamRemotePlay Internal => null;

		public static int SessionCount => 0;

		public static event Action<RemotePlaySession> OnSessionConnected
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

		public static event Action<RemotePlaySession> OnSessionDisconnected
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

		internal void InstallEvents(bool server)
		{
		}

		public static RemotePlaySession GetSession(int index)
		{
			return default(RemotePlaySession);
		}

		public static bool SendInvite(SteamId steamid)
		{
			return false;
		}
	}
}
