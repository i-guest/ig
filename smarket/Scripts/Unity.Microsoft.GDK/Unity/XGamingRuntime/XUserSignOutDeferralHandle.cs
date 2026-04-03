using System;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XUserSignOutDeferralHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		public XUserSignOutDeferralHandle(IntPtr interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
