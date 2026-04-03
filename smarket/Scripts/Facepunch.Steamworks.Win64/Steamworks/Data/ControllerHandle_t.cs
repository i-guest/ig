using System;

namespace Steamworks.Data
{
	internal struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
	{
		public ulong Value;

		public static implicit operator ControllerHandle_t(ulong value)
		{
			return default(ControllerHandle_t);
		}

		public static implicit operator ulong(ControllerHandle_t value)
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

		public bool Equals(ControllerHandle_t p)
		{
			return false;
		}

		public static bool operator ==(ControllerHandle_t a, ControllerHandle_t b)
		{
			return false;
		}

		public static bool operator !=(ControllerHandle_t a, ControllerHandle_t b)
		{
			return false;
		}

		public int CompareTo(ControllerHandle_t other)
		{
			return 0;
		}
	}
}
