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
	public class LicensingErrorAnalytic : AnalyticsEventBase
	{
		public string licensingErrorType;

		public string additionalData;

		public string errorMessage;

		public string correlationId;

		public string sessionId;

		public LicensingErrorAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic()
		{
			return null;
		}
	}
}
