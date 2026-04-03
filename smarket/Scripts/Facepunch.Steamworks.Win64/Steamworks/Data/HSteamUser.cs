using System;

namespace Steamworks.Data
{
	internal struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		public int Value;

		public static implicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		public static implicit operator int(HSteamUser value)
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

		public bool Equals(HSteamUser p)
		{
			return false;
		}

		public static bool operator ==(HSteamUser a, HSteamUser b)
		{
			return false;
		}

		public static bool operator !=(HSteamUser a, HSteamUser b)
		{
			return false;
		}

		public int CompareTo(HSteamUser other)
		{
			return 0;
		}
	}
}
