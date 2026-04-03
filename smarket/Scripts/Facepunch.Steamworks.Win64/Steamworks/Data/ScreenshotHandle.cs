using System;

namespace Steamworks.Data
{
	internal struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		public uint Value;

		public static implicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		public static implicit operator uint(ScreenshotHandle value)
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

		public bool Equals(ScreenshotHandle p)
		{
			return false;
		}

		public static bool operator ==(ScreenshotHandle a, ScreenshotHandle b)
		{
			return false;
		}

		public static bool operator !=(ScreenshotHandle a, ScreenshotHandle b)
		{
			return false;
		}

		public int CompareTo(ScreenshotHandle other)
		{
			return 0;
		}
	}
}
