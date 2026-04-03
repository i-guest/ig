using System;

namespace Steamworks.Data
{
	internal struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		public int Value;

		public static implicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		public static implicit operator int(HServerQuery value)
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

		public bool Equals(HServerQuery p)
		{
			return false;
		}

		public static bool operator ==(HServerQuery a, HServerQuery b)
		{
			return false;
		}

		public static bool operator !=(HServerQuery a, HServerQuery b)
		{
			return false;
		}

		public int CompareTo(HServerQuery other)
		{
			return 0;
		}
	}
}
