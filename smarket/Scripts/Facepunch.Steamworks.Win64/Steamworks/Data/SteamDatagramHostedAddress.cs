using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 132)]
	internal struct SteamDatagramHostedAddress
	{
		internal int CbSize;

		internal byte[] Data;

		[PreserveSig]
		internal static extern void InternalClear(ref SteamDatagramHostedAddress self);

		[PreserveSig]
		internal static extern SteamNetworkingPOPID InternalGetPopID(ref SteamDatagramHostedAddress self);

		[PreserveSig]
		internal static extern void InternalSetDevAddress(ref SteamDatagramHostedAddress self, uint nIP, ushort nPort, SteamNetworkingPOPID popid);

		internal string DataUTF8()
		{
			return null;
		}
	}
}
