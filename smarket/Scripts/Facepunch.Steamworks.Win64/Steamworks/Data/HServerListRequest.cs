using System;

namespace Steamworks.Data
{
	internal struct HServerListRequest : IEquatable<HServerListRequest>, IComparable<HServerListRequest>
	{
		public IntPtr Value;

		public static implicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		public static implicit operator IntPtr(HServerListRequest value)
		{
			return (IntPtr)0;
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

		public bool Equals(HServerListRequest p)
		{
			return false;
		}

		public static bool operator ==(HServerListRequest a, HServerListRequest b)
		{
			return false;
		}

		public static bool operator !=(HServerListRequest a, HServerListRequest b)
		{
			return false;
		}

		public int CompareTo(HServerListRequest other)
		{
			return 0;
		}
	}
}
