namespace Steamworks
{
	internal class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers>
	{
		internal static ISteamMatchmakingServers Internal => null;

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}
	}
}
