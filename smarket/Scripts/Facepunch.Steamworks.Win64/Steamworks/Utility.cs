using System;
using System.IO;
using System.Net;

namespace Steamworks
{
	public static class Utility
	{
		private static readonly byte[] readBuffer;

		internal static T ToType<T>(this IntPtr ptr)
		{
			return default(T);
		}

		internal static object ToType(this IntPtr ptr, Type t)
		{
			return null;
		}

		internal static uint Swap(uint x)
		{
			return 0u;
		}

		public static uint IpToInt32(this IPAddress ipAddress)
		{
			return 0u;
		}

		public static IPAddress Int32ToIp(uint ipAddress)
		{
			return null;
		}

		public static string FormatPrice(string currency, double price)
		{
			return null;
		}

		public static string ReadNullTerminatedUTF8String(this BinaryReader br)
		{
			return null;
		}
	}
}
