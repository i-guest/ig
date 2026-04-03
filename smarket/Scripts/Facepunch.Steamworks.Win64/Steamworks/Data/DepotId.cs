namespace Steamworks.Data
{
	public struct DepotId
	{
		public uint Value;

		public static implicit operator DepotId(uint value)
		{
			return default(DepotId);
		}

		public static implicit operator DepotId(int value)
		{
			return default(DepotId);
		}

		public static implicit operator uint(DepotId value)
		{
			return 0u;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
