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
	public class StallSummaryAnalytic : AnalyticsEventBase
	{
		public double Duration;

		public StallSummaryAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static StallSummaryAnalytic CreateStallSummaryAnalytic()
		{
			return null;
		}
	}
}
