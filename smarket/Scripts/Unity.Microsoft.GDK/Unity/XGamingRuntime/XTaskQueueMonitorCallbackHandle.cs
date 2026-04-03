using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XTaskQueueMonitorCallbackHandle
	{
		internal Unity.XGamingRuntime.Interop.XTaskQueueMonitorCallbackHandle interop;

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

		internal XTaskQueueMonitorCallbackHandle(XTaskQueueHandle queue, Unity.XGamingRuntime.Interop.XTaskQueueMonitorCallback callback, IntPtr context)
		{
		}

		public void Unregister(XTaskQueueHandle queue)
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
