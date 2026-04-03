using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblPresenceRecordHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblPresenceRecordHandle(Unity.XGamingRuntime.Interop.XblPresenceRecordHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapInteropHandleAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblPresenceRecordHandle interopHandle, out XblPresenceRecordHandle handle)
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
