using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	public class SubsystemsAnalyticBase : AnalyticsEventBase
	{
		public string subsystem;

		public SubsystemsAnalyticBase(string eventName)
			: base(null, 0, default(SendEventOptions), null)
		{
		}
	}
}
