using System;

namespace Steamworks.Data
{
	internal struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>, IComparable<ControllerDigitalActionHandle_t>
	{
		public ulong Value;

		public static implicit operator ControllerDigitalActionHandle_t(ulong value)
		{
			return default(ControllerDigitalActionHandle_t);
		}

		public static implicit operator ulong(ControllerDigitalActionHandle_t value)
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

		public bool Equals(ControllerDigitalActionHandle_t p)
		{
			return false;
		}

		public static bool operator ==(ControllerDigitalActionHandle_t a, ControllerDigitalActionHandle_t b)
		{
			return false;
		}

		public static bool operator !=(ControllerDigitalActionHandle_t a, ControllerDigitalActionHandle_t b)
		{
			return false;
		}

		public int CompareTo(ControllerDigitalActionHandle_t other)
		{
			return 0;
		}
	}
}
