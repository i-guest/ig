using System;

namespace Steamworks.Data
{
	internal struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		public ulong Value;

		public static implicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		public static implicit operator ulong(UGCQueryHandle_t value)
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

		public bool Equals(UGCQueryHandle_t p)
		{
			return false;
		}

		public static bool operator ==(UGCQueryHandle_t a, UGCQueryHandle_t b)
		{
			return false;
		}

		public static bool operator !=(UGCQueryHandle_t a, UGCQueryHandle_t b)
		{
			return false;
		}

		public int CompareTo(UGCQueryHandle_t other)
		{
			return 0;
		}
	}
}
