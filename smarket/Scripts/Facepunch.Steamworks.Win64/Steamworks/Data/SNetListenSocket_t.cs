using System;

namespace Steamworks.Data
{
	internal struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		public uint Value;

		public static implicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		public static implicit operator uint(SNetListenSocket_t value)
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

		public bool Equals(SNetListenSocket_t p)
		{
			return false;
		}

		public static bool operator ==(SNetListenSocket_t a, SNetListenSocket_t b)
		{
			return false;
		}

		public static bool operator !=(SNetListenSocket_t a, SNetListenSocket_t b)
		{
			return false;
		}

		public int CompareTo(SNetListenSocket_t other)
		{
			return 0;
		}
	}
}
