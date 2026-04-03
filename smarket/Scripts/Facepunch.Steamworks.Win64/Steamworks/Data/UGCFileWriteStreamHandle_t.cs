using System;

namespace Steamworks.Data
{
	internal struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		public ulong Value;

		public static implicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		public static implicit operator ulong(UGCFileWriteStreamHandle_t value)
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

		public bool Equals(UGCFileWriteStreamHandle_t p)
		{
			return false;
		}

		public static bool operator ==(UGCFileWriteStreamHandle_t a, UGCFileWriteStreamHandle_t b)
		{
			return false;
		}

		public static bool operator !=(UGCFileWriteStreamHandle_t a, UGCFileWriteStreamHandle_t b)
		{
			return false;
		}

		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return 0;
		}
	}
}
