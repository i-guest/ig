using System;

namespace Steamworks.Data
{
	internal struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		public ulong Value;

		public static implicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		public static implicit operator ulong(UGCHandle_t value)
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

		public bool Equals(UGCHandle_t p)
		{
			return false;
		}

		public static bool operator ==(UGCHandle_t a, UGCHandle_t b)
		{
			return false;
		}

		public static bool operator !=(UGCHandle_t a, UGCHandle_t b)
		{
			return false;
		}

		public int CompareTo(UGCHandle_t other)
		{
			return 0;
		}
	}
}
