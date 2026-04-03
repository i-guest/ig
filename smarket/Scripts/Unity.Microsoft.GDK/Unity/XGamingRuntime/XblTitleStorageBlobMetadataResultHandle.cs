using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblTitleStorageBlobMetadataResultHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblTitleStorageBlobMetadataResultHandle(Unity.XGamingRuntime.Interop.XblTitleStorageBlobMetadataResultHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
