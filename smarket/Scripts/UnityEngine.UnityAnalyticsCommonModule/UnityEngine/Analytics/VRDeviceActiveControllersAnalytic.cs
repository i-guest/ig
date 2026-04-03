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
	public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase
	{
		public string[] vr_active_controllers;

		[RequiredByNativeCode]
		internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic()
		{
			return null;
		}
	}
}
