namespace Steamworks
{
	public struct SteamId
	{
		public ulong Value;

		public uint AccountId => 0u;

		public bool IsValid => false;

		public static implicit operator SteamId(ulong value)
		{
			return default(SteamId);
		}

		public static implicit operator ulong(SteamId value)
		{
			return 0uL;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
