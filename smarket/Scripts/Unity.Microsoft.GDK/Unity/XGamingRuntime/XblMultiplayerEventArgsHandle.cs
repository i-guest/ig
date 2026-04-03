using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerEventArgsHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblMultiplayerEventArgsHandle(Unity.XGamingRuntime.Interop.XblMultiplayerEventArgsHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapInteropHandleAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblMultiplayerEventArgsHandle interopHandle, out XblMultiplayerEventArgsHandle handle)
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
