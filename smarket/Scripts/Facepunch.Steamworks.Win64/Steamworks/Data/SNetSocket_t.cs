using System;

namespace Steamworks.Data
{
	internal struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		public uint Value;

		public static implicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		public static implicit operator uint(SNetSocket_t value)
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

		public bool Equals(SNetSocket_t p)
		{
			return false;
		}

		public static bool operator ==(SNetSocket_t a, SNetSocket_t b)
		{
			return false;
		}

		public static bool operator !=(SNetSocket_t a, SNetSocket_t b)
		{
			return false;
		}

		public int CompareTo(SNetSocket_t other)
		{
			return 0;
		}
	}
}
