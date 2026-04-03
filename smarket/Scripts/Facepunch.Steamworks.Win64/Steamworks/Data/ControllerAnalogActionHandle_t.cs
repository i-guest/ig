using System;

namespace Steamworks.Data
{
	internal struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>, IComparable<ControllerAnalogActionHandle_t>
	{
		public ulong Value;

		public static implicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			return default(ControllerAnalogActionHandle_t);
		}

		public static implicit operator ulong(ControllerAnalogActionHandle_t value)
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

		public bool Equals(ControllerAnalogActionHandle_t p)
		{
			return false;
		}

		public static bool operator ==(ControllerAnalogActionHandle_t a, ControllerAnalogActionHandle_t b)
		{
			return false;
		}

		public static bool operator !=(ControllerAnalogActionHandle_t a, ControllerAnalogActionHandle_t b)
		{
			return false;
		}

		public int CompareTo(ControllerAnalogActionHandle_t other)
		{
			return 0;
		}
	}
}
