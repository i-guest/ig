using System;

namespace Steamworks.Data
{
	internal struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
	{
		public ulong Value;

		public static implicit operator InputDigitalActionHandle_t(ulong value)
		{
			return default(InputDigitalActionHandle_t);
		}

		public static implicit operator ulong(InputDigitalActionHandle_t value)
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

		public bool Equals(InputDigitalActionHandle_t p)
		{
			return false;
		}

		public static bool operator ==(InputDigitalActionHandle_t a, InputDigitalActionHandle_t b)
		{
			return false;
		}

		public static bool operator !=(InputDigitalActionHandle_t a, InputDigitalActionHandle_t b)
		{
			return false;
		}

		public int CompareTo(InputDigitalActionHandle_t other)
		{
			return 0;
		}
	}
}
