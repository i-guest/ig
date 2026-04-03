using System;

namespace Steamworks.Data
{
	internal struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		public ulong Value;

		public static implicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		public static implicit operator ulong(SteamLeaderboard_t value)
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

		public bool Equals(SteamLeaderboard_t p)
		{
			return false;
		}

		public static bool operator ==(SteamLeaderboard_t a, SteamLeaderboard_t b)
		{
			return false;
		}

		public static bool operator !=(SteamLeaderboard_t a, SteamLeaderboard_t b)
		{
			return false;
		}

		public int CompareTo(SteamLeaderboard_t other)
		{
			return 0;
		}
	}
}
