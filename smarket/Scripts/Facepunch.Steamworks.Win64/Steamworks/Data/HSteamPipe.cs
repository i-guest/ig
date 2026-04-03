using System;

namespace Steamworks.Data
{
	internal struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		public int Value;

		public static implicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		public static implicit operator int(HSteamPipe value)
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

		public bool Equals(HSteamPipe p)
		{
			return false;
		}

		public static bool operator ==(HSteamPipe a, HSteamPipe b)
		{
			return false;
		}

		public static bool operator !=(HSteamPipe a, HSteamPipe b)
		{
			return false;
		}

		public int CompareTo(HSteamPipe other)
		{
			return 0;
		}
	}
}
