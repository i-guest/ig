using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime
{
	public abstract class EquatableHandle : SafeHandle
	{
		public IntPtr Handle => (IntPtr)0;

		public EquatableHandle(IntPtr invalidHandleValue, bool ownsHandle, IntPtr handle)
			: base((IntPtr)0, ownsHandle: false)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(EquatableHandle handle1, EquatableHandle handle2)
		{
			return false;
		}

		public static bool operator !=(EquatableHandle handle1, EquatableHandle handle2)
		{
			return false;
		}
	}
}
