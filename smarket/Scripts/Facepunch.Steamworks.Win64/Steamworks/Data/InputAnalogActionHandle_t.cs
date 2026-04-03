using System;

namespace Steamworks.Data
{
	internal struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t>
	{
		public ulong Value;

		public static implicit operator InputAnalogActionHandle_t(ulong value)
		{
			return default(InputAnalogActionHandle_t);
		}

		public static implicit operator ulong(InputAnalogActionHandle_t value)
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

		public bool Equals(InputAnalogActionHandle_t p)
		{
			return false;
		}

		public static bool operator ==(InputAnalogActionHandle_t a, InputAnalogActionHandle_t b)
		{
			return false;
		}

		public static bool operator !=(InputAnalogActionHandle_t a, InputAnalogActionHandle_t b)
		{
			return false;
		}

		public int CompareTo(InputAnalogActionHandle_t other)
		{
			return 0;
		}
	}
}
