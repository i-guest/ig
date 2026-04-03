using System;

namespace Steamworks.Data
{
	public struct InventoryDefId : IEquatable<InventoryDefId>, IComparable<InventoryDefId>
	{
		public int Value;

		public static implicit operator InventoryDefId(int value)
		{
			return default(InventoryDefId);
		}

		public static implicit operator int(InventoryDefId value)
		{
			return 0;
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

		public bool Equals(InventoryDefId p)
		{
			return false;
		}

		public static bool operator ==(InventoryDefId a, InventoryDefId b)
		{
			return false;
		}

		public static bool operator !=(InventoryDefId a, InventoryDefId b)
		{
			return false;
		}

		public int CompareTo(InventoryDefId other)
		{
			return 0;
		}
	}
}
