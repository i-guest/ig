using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct servernetadr_t
	{
		internal ushort ConnectionPort;

		internal ushort QueryPort;

		internal uint IP;

		[PreserveSig]
		internal static extern void InternalConstruct(ref servernetadr_t self);

		[PreserveSig]
		internal static extern void InternalInit(ref servernetadr_t self, uint ip, ushort usQueryPort, ushort usConnectionPort);

		[PreserveSig]
		internal static extern ushort InternalGetQueryPort(ref servernetadr_t self);

		[PreserveSig]
		internal static extern void InternalSetQueryPort(ref servernetadr_t self, ushort usPort);

		[PreserveSig]
		internal static extern ushort InternalGetConnectionPort(ref servernetadr_t self);

		[PreserveSig]
		internal static extern void InternalSetConnectionPort(ref servernetadr_t self, ushort usPort);

		[PreserveSig]
		internal static extern uint InternalGetIP(ref servernetadr_t self);

		[PreserveSig]
		internal static extern void InternalSetIP(ref servernetadr_t self, uint unIP);

		[PreserveSig]
		internal static extern Utf8StringPointer InternalGetConnectionAddressString(ref servernetadr_t self);

		[PreserveSig]
		internal static extern Utf8StringPointer InternalGetQueryAddressString(ref servernetadr_t self);

		[PreserveSig]
		internal static extern bool InternalIsLessThan(ref servernetadr_t self, ref servernetadr_t netadr);

		[PreserveSig]
		internal static extern void InternalAssign(ref servernetadr_t self, ref servernetadr_t that);
	}
}
