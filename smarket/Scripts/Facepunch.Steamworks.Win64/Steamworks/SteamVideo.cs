namespace Steamworks
{
	public class SteamVideo : SteamClientClass<SteamVideo>
	{
		internal static ISteamVideo Internal => null;

		public static bool IsBroadcasting => false;

		public static int NumViewers => 0;

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal static void InstallEvents()
		{
		}
	}
}
