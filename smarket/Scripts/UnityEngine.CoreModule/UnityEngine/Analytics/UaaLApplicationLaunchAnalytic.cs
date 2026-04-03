using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase
	{
		public int launch_type;

		public int launch_process_type;

		public UaaLApplicationLaunchAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic()
		{
			return null;
		}
	}
}
