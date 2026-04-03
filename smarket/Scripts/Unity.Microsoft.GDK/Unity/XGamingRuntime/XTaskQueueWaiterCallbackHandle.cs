using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XTaskQueueWaiterCallbackHandle
	{
		internal Unity.XGamingRuntime.Interop.XTaskQueueWaiterCallbackHandle interop;

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

		internal XTaskQueueWaiterCallbackHandle(XTaskQueueHandle queue, Unity.XGamingRuntime.Interop.XTaskQueueCallback callback, IntPtr context)
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
