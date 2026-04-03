using System;

namespace Steamworks.Data
{
	internal struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
	{
		public uint Value;

		public static implicit operator RTime32(uint value)
		{
			return default(RTime32);
		}

		public static implicit operator uint(RTime32 value)
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

		public bool Equals(RTime32 p)
		{
			return false;
		}

		public static bool operator ==(RTime32 a, RTime32 b)
		{
			return false;
		}

		public static bool operator !=(RTime32 a, RTime32 b)
		{
			return false;
		}

		public int CompareTo(RTime32 other)
		{
			return 0;
		}
	}
}
