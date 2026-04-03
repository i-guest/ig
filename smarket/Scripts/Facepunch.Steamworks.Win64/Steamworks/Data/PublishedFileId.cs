using System;

namespace Steamworks.Data
{
	public struct PublishedFileId : IEquatable<PublishedFileId>, IComparable<PublishedFileId>
	{
		public ulong Value;

		public static implicit operator PublishedFileId(ulong value)
		{
			return default(PublishedFileId);
		}

		public static implicit operator ulong(PublishedFileId value)
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

		public bool Equals(PublishedFileId p)
		{
			return false;
		}

		public static bool operator ==(PublishedFileId a, PublishedFileId b)
		{
			return false;
		}

		public static bool operator !=(PublishedFileId a, PublishedFileId b)
		{
			return false;
		}

		public int CompareTo(PublishedFileId other)
		{
			return 0;
		}
	}
}
