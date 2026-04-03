using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblSocialManagerUserGroupHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblSocialManagerUserGroupHandle(Unity.XGamingRuntime.Interop.XblSocialManagerUserGroupHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblSocialManagerUserGroupHandle interopHandle, out XblSocialManagerUserGroupHandle handle)
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
