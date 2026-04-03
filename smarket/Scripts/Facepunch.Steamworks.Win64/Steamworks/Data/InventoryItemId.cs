using System;

namespace Steamworks.Data
{
	public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId>
	{
		public ulong Value;

		public static implicit operator InventoryItemId(ulong value)
		{
			return default(InventoryItemId);
		}

		public static implicit operator ulong(InventoryItemId value)
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

		public bool Equals(InventoryItemId p)
		{
			return false;
		}

		public static bool operator ==(InventoryItemId a, InventoryItemId b)
		{
			return false;
		}

		public static bool operator !=(InventoryItemId a, InventoryItemId b)
		{
			return false;
		}

		public int CompareTo(InventoryItemId other)
		{
			return 0;
		}
	}
}
