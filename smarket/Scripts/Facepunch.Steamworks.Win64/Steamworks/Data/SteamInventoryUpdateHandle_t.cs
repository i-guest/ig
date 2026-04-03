using System;

namespace Steamworks.Data
{
	internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		public ulong Value;

		public static implicit operator SteamInventoryUpdateHandle_t(ulong value)
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		public static implicit operator ulong(SteamInventoryUpdateHandle_t value)
		{
			return 0uL;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public bool Equals(SteamInventoryUpdateHandle_t p)
		{
			return false;
		}

		public static bool operator ==(SteamInventoryUpdateHandle_t a, SteamInventoryUpdateHandle_t b)
		{
			return false;
		}

		public static bool operator !=(SteamInventoryUpdateHandle_t a, SteamInventoryUpdateHandle_t b)
		{
			return false;
		}

		public int CompareTo(SteamInventoryUpdateHandle_t other)
		{
			return 0;
		}
	}
}
