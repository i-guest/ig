using System;

namespace Steamworks.Data
{
	internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
	{
		public uint Value;

		public static implicit operator SteamNetworkingPOPID(uint value)
		{
			return default(SteamNetworkingPOPID);
		}

		public static implicit operator uint(SteamNetworkingPOPID value)
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

		public bool Equals(SteamNetworkingPOPID p)
		{
			return false;
		}

		public static bool operator ==(SteamNetworkingPOPID a, SteamNetworkingPOPID b)
		{
			return false;
		}

		public static bool operator !=(SteamNetworkingPOPID a, SteamNetworkingPOPID b)
		{
			return false;
		}

		public int CompareTo(SteamNetworkingPOPID other)
		{
			return 0;
		}
	}
}
