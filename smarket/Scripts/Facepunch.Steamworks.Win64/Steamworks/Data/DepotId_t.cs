using System;

namespace Steamworks.Data
{
	internal struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		public uint Value;

		public static implicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		public static implicit operator uint(DepotId_t value)
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

		public bool Equals(DepotId_t p)
		{
			return false;
		}

		public static bool operator ==(DepotId_t a, DepotId_t b)
		{
			return false;
		}

		public static bool operator !=(DepotId_t a, DepotId_t b)
		{
			return false;
		}

		public int CompareTo(DepotId_t other)
		{
			return 0;
		}
	}
}
