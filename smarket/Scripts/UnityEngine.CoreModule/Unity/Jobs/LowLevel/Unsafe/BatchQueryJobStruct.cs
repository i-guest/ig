using System;
using System.Runtime.InteropServices;

namespace Unity.Jobs.LowLevel.Unsafe
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct BatchQueryJobStruct<T> where T : struct
	{
		internal static IntPtr jobReflectionData;

		public static IntPtr Initialize()
		{
			return (IntPtr)0;
		}
	}
}
