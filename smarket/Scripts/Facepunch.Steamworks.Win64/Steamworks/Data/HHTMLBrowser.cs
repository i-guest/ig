using System;

namespace Steamworks.Data
{
	internal struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		public uint Value;

		public static implicit operator HHTMLBrowser(uint value)
		{
			return default(HHTMLBrowser);
		}

		public static implicit operator uint(HHTMLBrowser value)
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

		public bool Equals(HHTMLBrowser p)
		{
			return false;
		}

		public static bool operator ==(HHTMLBrowser a, HHTMLBrowser b)
		{
			return false;
		}

		public static bool operator !=(HHTMLBrowser a, HHTMLBrowser b)
		{
			return false;
		}

		public int CompareTo(HHTMLBrowser other)
		{
			return 0;
		}
	}
}
