using System;

namespace Steamworks.Data
{
	internal struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
	{
		public ulong Value;

		public static implicit operator InputActionSetHandle_t(ulong value)
		{
			return default(InputActionSetHandle_t);
		}

		public static implicit operator ulong(InputActionSetHandle_t value)
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

		public bool Equals(InputActionSetHandle_t p)
		{
			return false;
		}

		public static bool operator ==(InputActionSetHandle_t a, InputActionSetHandle_t b)
		{
			return false;
		}

		public static bool operator !=(InputActionSetHandle_t a, InputActionSetHandle_t b)
		{
			return false;
		}

		public int CompareTo(InputActionSetHandle_t other)
		{
			return 0;
		}
	}
}
