using System;

namespace Steamworks.Data
{
	internal struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		public ulong Value;

		public static implicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		public static implicit operator ulong(SteamLeaderboardEntries_t value)
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

		public bool Equals(SteamLeaderboardEntries_t p)
		{
			return false;
		}

		public static bool operator ==(SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b)
		{
			return false;
		}

		public static bool operator !=(SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b)
		{
			return false;
		}

		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return 0;
		}
	}
}
