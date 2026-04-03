using System.Collections.Generic;

namespace Steamworks
{
	public static class SteamClient
	{
		private static bool initialized;

		private static readonly List<SteamClass> openInterfaces;

		public static bool IsValid => false;

		public static bool IsLoggedOn => false;

		public static SteamId SteamId => default(SteamId);

		public static string Name => null;

		public static FriendState State => default(FriendState);

		public static AppId AppId { get; internal set; }

		public static void Init(uint appid, bool asyncCallbacks = true)
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

		internal static void Cleanup()
		{
		}

		public static void RunCallbacks()
		{
		}

		public static bool RestartAppIfNecessary(uint appid)
		{
			return false;
		}

		internal static void ValidCheck()
		{
		}
	}
}
