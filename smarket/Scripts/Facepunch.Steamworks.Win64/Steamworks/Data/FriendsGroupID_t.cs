using System;

namespace Steamworks.Data
{
	internal struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		public short Value;

		public static implicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		public static implicit operator short(FriendsGroupID_t value)
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

		public bool Equals(FriendsGroupID_t p)
		{
			return false;
		}

		public static bool operator ==(FriendsGroupID_t a, FriendsGroupID_t b)
		{
			return false;
		}

		public static bool operator !=(FriendsGroupID_t a, FriendsGroupID_t b)
		{
			return false;
		}

		public int CompareTo(FriendsGroupID_t other)
		{
			return 0;
		}
	}
}
