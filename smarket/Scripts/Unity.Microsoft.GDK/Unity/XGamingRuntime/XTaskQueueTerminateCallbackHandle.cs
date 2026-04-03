using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XTaskQueueTerminateCallbackHandle
	{
		internal Unity.XGamingRuntime.Interop.XTaskQueueTerminateCallbackHandle interop;

		public bool IsValid => false;

		public ulong Token
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XTaskQueueTerminateCallbackHandle(Unity.XGamingRuntime.Interop.XTaskQueueTerminatedCallback callback, IntPtr context)
		{
		}

		public void Dispose()
		{
		}
	}
}
