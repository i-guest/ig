using System;
using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)2, Pack = 8, Size = 16)]
	internal struct NetKeyValue
	{
		[FieldOffset(0)]
		internal NetConfig Value;

		[FieldOffset(4)]
		internal NetConfigType DataType;

		[FieldOffset(8)]
		internal long Int64Value;

		[FieldOffset(8)]
		internal int Int32Value;

		[FieldOffset(8)]
		internal float FloatValue;

		[FieldOffset(8)]
		internal IntPtr PointerValue;

		[PreserveSig]
		internal static extern void InternalSetInt32(ref NetKeyValue self, NetConfig eVal, int data);

		[PreserveSig]
		internal static extern void InternalSetInt64(ref NetKeyValue self, NetConfig eVal, long data);

		[PreserveSig]
		internal static extern void InternalSetFloat(ref NetKeyValue self, NetConfig eVal, float data);

		[PreserveSig]
		internal static extern void InternalSetPtr(ref NetKeyValue self, NetConfig eVal, IntPtr data);

		[PreserveSig]
		internal static extern void InternalSetString(ref NetKeyValue self, NetConfig eVal, string data);
	}
}
