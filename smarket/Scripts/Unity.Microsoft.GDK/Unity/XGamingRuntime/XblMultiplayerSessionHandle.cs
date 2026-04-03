using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblMultiplayerSessionHandle(Unity.XGamingRuntime.Interop.XblMultiplayerSessionHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapInteropHandleAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblMultiplayerSessionHandle interopHandle, out XblMultiplayerSessionHandle sessionHandle)
		{
			sessionHandle = null;
			return 0;
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
