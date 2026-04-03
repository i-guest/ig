namespace Steamworks.Data
{
	public struct RemotePlaySession
	{
		public uint Id { get; set; }

		public bool IsValid => false;

		public SteamId SteamId => default(SteamId);

		public string ClientName => null;

		public SteamDeviceFormFactor FormFactor => default(SteamDeviceFormFactor);

		public override string ToString()
		{
			return null;
		}

		public static implicit operator RemotePlaySession(uint value)
		{
			return default(RemotePlaySession);
		}

		public static implicit operator uint(RemotePlaySession value)
		{
			return 0u;
		}
	}
}
