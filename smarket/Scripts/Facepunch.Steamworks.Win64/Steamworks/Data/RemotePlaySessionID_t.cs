using System;

namespace Steamworks.Data
{
	internal struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
	{
		public uint Value;

		public static implicit operator RemotePlaySessionID_t(uint value)
		{
			return default(RemotePlaySessionID_t);
		}

		public static implicit operator uint(RemotePlaySessionID_t value)
		{
			return 0u;
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

		public bool Equals(RemotePlaySessionID_t p)
		{
			return false;
		}

		public static bool operator ==(RemotePlaySessionID_t a, RemotePlaySessionID_t b)
		{
			return false;
		}

		public static bool operator !=(RemotePlaySessionID_t a, RemotePlaySessionID_t b)
		{
			return false;
		}

		public int CompareTo(RemotePlaySessionID_t other)
		{
			return 0;
		}
	}
}
