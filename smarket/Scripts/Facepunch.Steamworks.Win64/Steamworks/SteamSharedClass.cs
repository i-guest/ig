namespace Steamworks
{
	public class SteamSharedClass<T> : SteamClass
	{
		internal static SteamInterface InterfaceClient;

		internal static SteamInterface InterfaceServer;

		internal static SteamInterface Interface => null;

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal virtual void SetInterface(bool server, SteamInterface iface)
		{
		}

		internal override void DestroyInterface(bool server)
		{
		}
	}
}
