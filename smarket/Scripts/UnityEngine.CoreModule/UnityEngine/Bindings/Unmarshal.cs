using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Bindings
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[VisibleToOtherModules]
	internal struct Unmarshal
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T UnmarshalUnityObject<T>(IntPtr gcHandlePtr) where T : Object
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle)
		{
			return default(GCHandle);
		}
	}
}
