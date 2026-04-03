using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XSystemHandleCallbackHandle
	{
		internal Unity.XGamingRuntime.Interop.XSystemHandleCallbackHandle interop;

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

		internal XSystemHandleCallbackHandle(Unity.XGamingRuntime.Interop.XSystemHandleCallback callback, IntPtr context)
		{
		}

		public void Unregister()
		{
		}

		public void Dispose()
		{
		}
	}
}
