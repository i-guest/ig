using System;

namespace Steamworks.Data
{
	internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		public uint Value;

		public static implicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		public static implicit operator uint(HAuthTicket value)
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

		public bool Equals(HAuthTicket p)
		{
			return false;
		}

		public static bool operator ==(HAuthTicket a, HAuthTicket b)
		{
			return false;
		}

		public static bool operator !=(HAuthTicket a, HAuthTicket b)
		{
			return false;
		}

		public int CompareTo(HAuthTicket other)
		{
			return 0;
		}
	}
}
