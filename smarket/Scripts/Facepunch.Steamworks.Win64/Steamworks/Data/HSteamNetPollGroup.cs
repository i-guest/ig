using System;

namespace Steamworks.Data
{
	internal struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
	{
		public uint Value;

		public static implicit operator HSteamNetPollGroup(uint value)
		{
			return default(HSteamNetPollGroup);
		}

		public static implicit operator uint(HSteamNetPollGroup value)
		{
			return 0u;
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

		public bool Equals(HSteamNetPollGroup p)
		{
			return false;
		}

		public static bool operator ==(HSteamNetPollGroup a, HSteamNetPollGroup b)
		{
			return false;
		}

		public static bool operator !=(HSteamNetPollGroup a, HSteamNetPollGroup b)
		{
			return false;
		}

		public int CompareTo(HSteamNetPollGroup other)
		{
			return 0;
		}
	}
}
