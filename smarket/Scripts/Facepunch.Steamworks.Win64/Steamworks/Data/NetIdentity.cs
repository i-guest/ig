using System;
using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 136)]
	public struct NetIdentity
	{
		internal enum IdentityType
		{
			Invalid = 0,
			IPAddress = 1,
			GenericString = 2,
			GenericBytes = 3,
			SteamID = 16
		}

		[FieldOffset(0)]
		internal IdentityType type;

		[FieldOffset(4)]
		internal int size;

		[FieldOffset(8)]
		internal ulong steamid;

		[FieldOffset(8)]
		internal NetAddress netaddress;

		public static NetIdentity LocalHost => default(NetIdentity);

		public bool IsSteamId => false;

		public bool IsIpAddress => false;

		public bool IsLocalHost => false;

		public SteamId SteamId => default(SteamId);

		public NetAddress Address => default(NetAddress);

		[PreserveSig]
		internal static extern void InternalClear(ref NetIdentity self);

		[PreserveSig]
		internal static extern bool InternalIsInvalid(ref NetIdentity self);

		[PreserveSig]
		internal static extern void InternalSetSteamID(ref NetIdentity self, SteamId steamID);

		[PreserveSig]
		internal static extern SteamId InternalGetSteamID(ref NetIdentity self);

		[PreserveSig]
		internal static extern void InternalSetSteamID64(ref NetIdentity self, ulong steamID);

		[PreserveSig]
		internal static extern ulong InternalGetSteamID64(ref NetIdentity self);

		[PreserveSig]
		internal static extern bool InternalSetXboxPairwiseID(ref NetIdentity self, string pszString);

		[PreserveSig]
		internal static extern Utf8StringPointer InternalGetXboxPairwiseID(ref NetIdentity self);

		[PreserveSig]
		internal static extern void InternalSetPSNID(ref NetIdentity self, ulong id);

		[PreserveSig]
		internal static extern ulong InternalGetPSNID(ref NetIdentity self);

		[PreserveSig]
		internal static extern void InternalSetIPAddr(ref NetIdentity self, ref NetAddress addr);

		[PreserveSig]
		internal static extern IntPtr InternalGetIPAddr(ref NetIdentity self);

		[PreserveSig]
		internal static extern void InternalSetIPv4Addr(ref NetIdentity self, uint nIPv4, ushort nPort);

		[PreserveSig]
		internal static extern uint InternalGetIPv4(ref NetIdentity self);

		[PreserveSig]
		internal static extern SteamNetworkingFakeIPType InternalGetFakeIPType(ref NetIdentity self);

		[PreserveSig]
		internal static extern bool InternalIsFakeIP(ref NetIdentity self);

		[PreserveSig]
		internal static extern void InternalSetLocalHost(ref NetIdentity self);

		[PreserveSig]
		internal static extern bool InternalIsLocalHost(ref NetIdentity self);

		[PreserveSig]
		internal static extern bool InternalSetGenericString(ref NetIdentity self, string pszString);

		[PreserveSig]
		internal static extern Utf8StringPointer InternalGetGenericString(ref NetIdentity self);

		[PreserveSig]
		internal static extern bool InternalSetGenericBytes(ref NetIdentity self, IntPtr data, uint cbLen);

		[PreserveSig]
		internal static extern byte InternalGetGenericBytes(ref NetIdentity self, ref int cbLen);

		[PreserveSig]
		internal static extern bool InternalIsEqualTo(ref NetIdentity self, ref NetIdentity x);

		[PreserveSig]
		internal static extern void InternalToString(ref NetIdentity self, IntPtr buf, uint cbBuf);

		[PreserveSig]
		internal static extern bool InternalParseString(ref NetIdentity self, string pszStr);

		public static implicit operator NetIdentity(SteamId value)
		{
			return default(NetIdentity);
		}

		public static implicit operator NetIdentity(NetAddress address)
		{
			return default(NetIdentity);
		}

		public static implicit operator SteamId(NetIdentity value)
		{
			return default(SteamId);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
