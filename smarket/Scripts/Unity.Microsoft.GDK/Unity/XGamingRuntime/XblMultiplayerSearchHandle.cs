using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSearchHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblMultiplayerSearchHandle(Unity.XGamingRuntime.Interop.XblMultiplayerSearchHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapInteropHandleAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblMultiplayerSearchHandle interopHandle, out XblMultiplayerSearchHandle userHandle)
		{
			userHandle = null;
			return 0;
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
