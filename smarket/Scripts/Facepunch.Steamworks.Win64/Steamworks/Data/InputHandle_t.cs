using System;

namespace Steamworks.Data
{
	internal struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
	{
		public ulong Value;

		public static implicit operator InputHandle_t(ulong value)
		{
			return default(InputHandle_t);
		}

		public static implicit operator ulong(InputHandle_t value)
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

		public bool Equals(InputHandle_t p)
		{
			return false;
		}

		public static bool operator ==(InputHandle_t a, InputHandle_t b)
		{
			return false;
		}

		public static bool operator !=(InputHandle_t a, InputHandle_t b)
		{
			return false;
		}

		public int CompareTo(InputHandle_t other)
		{
			return 0;
		}
	}
}
