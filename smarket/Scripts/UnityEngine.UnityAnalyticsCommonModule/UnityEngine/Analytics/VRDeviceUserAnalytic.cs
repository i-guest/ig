using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	[ExcludeFromDocs]
	public class VRDeviceUserAnalytic : VRDeviceAnalyticBase
	{
		public int vr_user_presence;

		[RequiredByNativeCode]
		internal static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic()
		{
			return null;
		}
	}
}
