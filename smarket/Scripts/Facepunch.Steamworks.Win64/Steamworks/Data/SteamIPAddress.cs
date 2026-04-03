using System.Net;
using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)2, Pack = 8, Size = 20)]
	internal struct SteamIPAddress
	{
		[FieldOffset(0)]
		public uint Ip4Address;

		[FieldOffset(16)]
		internal SteamIPType Type;

		[PreserveSig]
		internal static extern bool InternalIsSet(ref SteamIPAddress self);

		public static implicit operator IPAddress(SteamIPAddress value)
		{
			return null;
		}
	}
}
