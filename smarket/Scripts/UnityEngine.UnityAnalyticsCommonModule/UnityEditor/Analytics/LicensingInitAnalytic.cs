using System;
using System.Runtime.InteropServices;
using UnityEngine.Analytics;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	public class LicensingInitAnalytic : AnalyticsEventBase
	{
		public string licensingProtocolVersion;

		public string licensingClientVersion;

		public string channelType;

		public double initTime;

		public bool isLegacy;

		public string sessionId;

		public string correlationId;

		public LicensingInitAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static LicensingInitAnalytic CreateLicensingInitAnalytic()
		{
			return null;
		}
	}
}
