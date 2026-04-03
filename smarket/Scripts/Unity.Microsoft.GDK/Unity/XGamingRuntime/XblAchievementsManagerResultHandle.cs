using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblAchievementsManagerResultHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		internal XblAchievementsManagerResultHandle(Unity.XGamingRuntime.Interop.XblAchievementsManagerResultHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapAndReturnHResult(int hresult, Unity.XGamingRuntime.Interop.XblAchievementsManagerResultHandle interopHandle, out XblAchievementsManagerResultHandle handle)
		{
			handle = null;
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		public static bool operator ==(XblAchievementsManagerResultHandle handle1, XblAchievementsManagerResultHandle handle2)
		{
			return false;
		}

		public static bool operator !=(XblAchievementsManagerResultHandle handle1, XblAchievementsManagerResultHandle handle2)
		{
			return false;
		}
	}
}
