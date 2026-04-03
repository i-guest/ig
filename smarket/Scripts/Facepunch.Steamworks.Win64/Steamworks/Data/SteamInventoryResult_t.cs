using System;

namespace Steamworks.Data
{
	internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		public int Value;

		public static implicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		public static implicit operator int(SteamInventoryResult_t value)
		{
			return 0;
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

		public bool Equals(SteamInventoryResult_t p)
		{
			return false;
		}

		public static bool operator ==(SteamInventoryResult_t a, SteamInventoryResult_t b)
		{
			return false;
		}

		public static bool operator !=(SteamInventoryResult_t a, SteamInventoryResult_t b)
		{
			return false;
		}

		public int CompareTo(SteamInventoryResult_t other)
		{
			return 0;
		}
	}
}
