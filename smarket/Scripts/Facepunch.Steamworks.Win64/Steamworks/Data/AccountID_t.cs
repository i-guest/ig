using System;

namespace Steamworks.Data
{
	internal struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		public uint Value;

		public static implicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		public static implicit operator uint(AccountID_t value)
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

		public bool Equals(AccountID_t p)
		{
			return false;
		}

		public static bool operator ==(AccountID_t a, AccountID_t b)
		{
			return false;
		}

		public static bool operator !=(AccountID_t a, AccountID_t b)
		{
			return false;
		}

		public int CompareTo(AccountID_t other)
		{
			return 0;
		}
	}
}
