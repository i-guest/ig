using System;

namespace Steamworks.Data
{
	internal struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>, IComparable<ControllerActionSetHandle_t>
	{
		public ulong Value;

		public static implicit operator ControllerActionSetHandle_t(ulong value)
		{
			return default(ControllerActionSetHandle_t);
		}

		public static implicit operator ulong(ControllerActionSetHandle_t value)
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

		public bool Equals(ControllerActionSetHandle_t p)
		{
			return false;
		}

		public static bool operator ==(ControllerActionSetHandle_t a, ControllerActionSetHandle_t b)
		{
			return false;
		}

		public static bool operator !=(ControllerActionSetHandle_t a, ControllerActionSetHandle_t b)
		{
			return false;
		}

		public int CompareTo(ControllerActionSetHandle_t other)
		{
			return 0;
		}
	}
}
