using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XAsyncProviderData
	{
		internal Unity.XGamingRuntime.Interop.XAsyncProviderData interop;

		internal XAsyncBlock _async;

		public XAsyncBlock Async
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ulong BufferSize
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public IntPtr Buffer
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		public IntPtr Context
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		internal XAsyncProviderData(Unity.XGamingRuntime.Interop.XAsyncProviderData interop, XAsyncBlock block)
		{
		}
	}
}
