using System;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPackageMountHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		public XPackageMountHandle(IntPtr handle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
