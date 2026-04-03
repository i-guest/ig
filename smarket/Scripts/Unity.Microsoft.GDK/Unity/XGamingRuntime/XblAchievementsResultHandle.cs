using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblAchievementsResultHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblAchievementsResultHandle(Unity.XGamingRuntime.Interop.XblAchievementsResultHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
