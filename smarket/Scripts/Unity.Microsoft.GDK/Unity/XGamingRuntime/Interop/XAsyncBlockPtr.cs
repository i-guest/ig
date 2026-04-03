using System;

namespace Unity.XGamingRuntime.Interop
{
	public struct XAsyncBlockPtr
	{
		internal readonly IntPtr IntPtr;

		internal XAsyncBlockPtr(IntPtr intPtr)
		{
			IntPtr = (IntPtr)0;
		}

		public static implicit operator IntPtr(XAsyncBlockPtr ptr)
		{
			return (IntPtr)0;
		}

		public static implicit operator XAsyncBlockPtr(XAsyncBlock block)
		{
			return default(XAsyncBlockPtr);
		}
	}
}
