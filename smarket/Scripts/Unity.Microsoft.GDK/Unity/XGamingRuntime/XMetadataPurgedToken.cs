using System;
using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XMetadataPurgedToken
	{
		internal Unity.XGamingRuntime.Interop.XMetadataPurgedToken interop { get; private set; }

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

		internal XMetadataPurgedToken(Unity.XGamingRuntime.Interop.XAppCaptureMetadataPurgedCallback callback, IntPtr context)
		{
		}

		public bool Unregister(bool wait)
		{
			return false;
		}
	}
}
