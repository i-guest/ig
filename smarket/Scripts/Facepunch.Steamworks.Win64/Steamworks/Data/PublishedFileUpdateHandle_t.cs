using System;

namespace Steamworks.Data
{
	internal struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		public ulong Value;

		public static implicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		public static implicit operator ulong(PublishedFileUpdateHandle_t value)
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

		public bool Equals(PublishedFileUpdateHandle_t p)
		{
			return false;
		}

		public static bool operator ==(PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b)
		{
			return false;
		}

		public static bool operator !=(PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b)
		{
			return false;
		}

		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return 0;
		}
	}
}
