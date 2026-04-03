using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 18)]
	public struct NetAddress
	{
		internal struct IPV4
		{
			internal ulong m_8zeros;

			internal ushort m_0000;

			internal ushort m_ffff;

			internal byte ip0;

			internal byte ip1;

			internal byte ip2;

			internal byte ip3;
		}

		[FieldOffset(0)]
		internal IPV4 ip;

		[FieldOffset(16)]
		internal ushort port;

		public ushort Port => 0;

		public static NetAddress Cleared => default(NetAddress);

		public bool IsIPv6AllZeros => false;

		public bool IsIPv4 => false;

		public bool IsFakeIPv4 => false;

		public bool IsLocalHost => false;

		public IPAddress Address => null;

		[PreserveSig]
		internal static extern void InternalClear(ref NetAddress self);

		[PreserveSig]
		internal static extern bool InternalIsIPv6AllZeros(ref NetAddress self);

		[PreserveSig]
		internal static extern void InternalSetIPv6(ref NetAddress self, ref byte ipv6, ushort nPort);

		[PreserveSig]
		internal static extern void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort);

		[PreserveSig]
		internal static extern bool InternalIsIPv4(ref NetAddress self);

		[PreserveSig]
		internal static extern uint InternalGetIPv4(ref NetAddress self);

		[PreserveSig]
		internal static extern void InternalSetIPv6LocalHost(ref NetAddress self, ushort nPort);

		[PreserveSig]
		internal static extern bool InternalIsLocalHost(ref NetAddress self);

		[PreserveSig]
		internal static extern void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort);

		[PreserveSig]
		internal static extern bool InternalParseString(ref NetAddress self, string pszStr);

		[PreserveSig]
		internal static extern bool InternalIsEqualTo(ref NetAddress self, ref NetAddress x);

		[PreserveSig]
		internal static extern SteamNetworkingFakeIPType InternalGetFakeIPType(ref NetAddress self);

		[PreserveSig]
		internal static extern bool InternalIsFakeIP(ref NetAddress self);

		public static NetAddress AnyIp(ushort port)
		{
			return default(NetAddress);
		}

		public static NetAddress LocalHost(ushort port)
		{
			return default(NetAddress);
		}

		public static NetAddress From(string addrStr, ushort port)
		{
			return default(NetAddress);
		}

		public static NetAddress From(IPAddress address, ushort port)
		{
			return default(NetAddress);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
