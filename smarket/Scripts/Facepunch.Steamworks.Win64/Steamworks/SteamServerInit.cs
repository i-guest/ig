using System.Net;

namespace Steamworks
{
	public struct SteamServerInit
	{
		public IPAddress IpAddress;

		public ushort GamePort;

		public ushort QueryPort;

		public bool Secure;

		public string VersionString;

		public string ModDir;

		public string GameDescription;

		public bool DedicatedServer;

		public SteamServerInit(string modDir, string gameDesc)
		{
			IpAddress = null;
			GamePort = 0;
			QueryPort = 0;
			Secure = false;
			VersionString = null;
			ModDir = null;
			GameDescription = null;
			DedicatedServer = false;
		}

		public SteamServerInit WithQueryShareGamePort()
		{
			return default(SteamServerInit);
		}
	}
}
