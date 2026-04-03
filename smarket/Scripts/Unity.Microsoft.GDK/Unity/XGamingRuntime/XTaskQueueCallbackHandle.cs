using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XTaskQueueCallbackHandle
	{
		internal Unity.XGamingRuntime.Interop.XTaskQueueCallbackHandle interop;

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

		internal XTaskQueueCallbackHandle(Unity.XGamingRuntime.Interop.XTaskQueueCallback callback, IntPtr context)
		{
		}

		public void Dispose()
		{
		}
	}
}
