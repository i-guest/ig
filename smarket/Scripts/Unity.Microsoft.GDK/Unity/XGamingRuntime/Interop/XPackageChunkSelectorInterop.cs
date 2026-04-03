using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	[StructLayout((LayoutKind)2)]
	internal struct XPackageChunkSelectorInterop
	{
		[FieldOffset(0)]
		internal XPackageChunkSelectorType type;

		[FieldOffset(8)]
		internal IntPtr languageOrTagOrFeature;

		[FieldOffset(8)]
		internal uint chunkId;
	}
}
