using System;

namespace Steamworks.Data
{
	public struct TimelineEventHandle : IEquatable<TimelineEventHandle>, IComparable<TimelineEventHandle>
	{
		public ulong Value;

		public static implicit operator TimelineEventHandle(ulong value)
		{
			return default(TimelineEventHandle);
		}

		public static implicit operator ulong(TimelineEventHandle value)
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

		public bool Equals(TimelineEventHandle p)
		{
			return false;
		}

		public static bool operator ==(TimelineEventHandle a, TimelineEventHandle b)
		{
			return false;
		}

		public static bool operator !=(TimelineEventHandle a, TimelineEventHandle b)
		{
			return false;
		}

		public int CompareTo(TimelineEventHandle other)
		{
			return 0;
		}
	}
}
