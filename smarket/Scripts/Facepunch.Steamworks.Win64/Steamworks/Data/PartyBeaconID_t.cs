using System;

namespace Steamworks.Data
{
	internal struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
	{
		public ulong Value;

		public static implicit operator PartyBeaconID_t(ulong value)
		{
			return default(PartyBeaconID_t);
		}

		public static implicit operator ulong(PartyBeaconID_t value)
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

		public bool Equals(PartyBeaconID_t p)
		{
			return false;
		}

		public static bool operator ==(PartyBeaconID_t a, PartyBeaconID_t b)
		{
			return false;
		}

		public static bool operator !=(PartyBeaconID_t a, PartyBeaconID_t b)
		{
			return false;
		}

		public int CompareTo(PartyBeaconID_t other)
		{
			return 0;
		}
	}
}
