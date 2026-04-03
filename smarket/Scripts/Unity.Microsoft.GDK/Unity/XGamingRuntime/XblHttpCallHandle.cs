using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblHttpCallHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblHttpCallHandle(Unity.XGamingRuntime.Interop.XblHttpCallHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapInteropHandleAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblHttpCallHandle interopHandle, out XblHttpCallHandle handle)
		{
			handle = null;
			return 0;
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
