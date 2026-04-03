using System;
using System.Runtime.InteropServices;
using UnityEngine.Analytics;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	[ExcludeFromDocs]
	internal class StallMarkerAnalytic : AnalyticsEventBase
	{
		public string Name;

		public bool HasProgressMarkup;

		public double Duration;

		public StallMarkerAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static StallMarkerAnalytic CreateStallMarkerAnalytic()
		{
			return null;
		}
	}
}
