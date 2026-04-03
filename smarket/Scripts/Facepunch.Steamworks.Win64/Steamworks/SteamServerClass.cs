namespace Steamworks
{
	public class SteamServerClass<T> : SteamClass
	{
		internal static SteamInterface Interface;

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
