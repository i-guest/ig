using System;

namespace Steamworks.Data
{
	internal struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		public uint Value;

		public static implicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		public static implicit operator uint(HTTPCookieContainerHandle value)
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

		public bool Equals(HTTPCookieContainerHandle p)
		{
			return false;
		}

		public static bool operator ==(HTTPCookieContainerHandle a, HTTPCookieContainerHandle b)
		{
			return false;
		}

		public static bool operator !=(HTTPCookieContainerHandle a, HTTPCookieContainerHandle b)
		{
			return false;
		}

		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return 0;
		}
	}
}
