using System;

namespace Steamworks.Data
{
	internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		public ulong Value;

		public static implicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		public static implicit operator ulong(SteamAPICall_t value)
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

		public bool Equals(SteamAPICall_t p)
		{
			return false;
		}

		public static bool operator ==(SteamAPICall_t a, SteamAPICall_t b)
		{
			return false;
		}

		public static bool operator !=(SteamAPICall_t a, SteamAPICall_t b)
		{
			return false;
		}

		public int CompareTo(SteamAPICall_t other)
		{
			return 0;
		}
	}
}
