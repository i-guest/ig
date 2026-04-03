using System;

namespace Steamworks.Data
{
	internal struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		public ulong Value;

		public static implicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		public static implicit operator ulong(UGCUpdateHandle_t value)
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

		public bool Equals(UGCUpdateHandle_t p)
		{
			return false;
		}

		public static bool operator ==(UGCUpdateHandle_t a, UGCUpdateHandle_t b)
		{
			return false;
		}

		public static bool operator !=(UGCUpdateHandle_t a, UGCUpdateHandle_t b)
		{
			return false;
		}

		public int CompareTo(UGCUpdateHandle_t other)
		{
			return 0;
		}
	}
}
