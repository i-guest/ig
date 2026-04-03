using System;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	[StructLayout((LayoutKind)0, Size = 16)]
	public readonly struct MemoryLabel
	{
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr pointer;

		internal readonly Allocator allocator;

		public bool IsCreated => false;

		public MemoryLabel(string areaName, string objectName, Allocator allocator = Allocator.Persistent)
		{
			pointer = (IntPtr)0;
			this.allocator = default(Allocator);
		}

		public static bool SupportsAllocator(Allocator allocator)
		{
			return false;
		}

		private static bool IsNullOrEmpty(string str)
		{
			return false;
		}

		private unsafe static bool IsNullOrEmpty__Unmanaged(byte* name, int nameLen)
		{
			return false;
		}
	}
}
