using System;

namespace Steamworks.Data
{
	internal struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		public uint Value;

		public static implicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		public static implicit operator uint(HTTPRequestHandle value)
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

		public bool Equals(HTTPRequestHandle p)
		{
			return false;
		}

		public static bool operator ==(HTTPRequestHandle a, HTTPRequestHandle b)
		{
			return false;
		}

		public static bool operator !=(HTTPRequestHandle a, HTTPRequestHandle b)
		{
			return false;
		}

		public int CompareTo(HTTPRequestHandle other)
		{
			return 0;
		}
	}
}
