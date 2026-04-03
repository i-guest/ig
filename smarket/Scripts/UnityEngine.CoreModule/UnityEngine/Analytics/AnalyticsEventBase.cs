using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	public class AnalyticsEventBase
	{
		private string eventName;

		private int eventVersion;

		private string eventPrefix;

		private SendEventOptions sendEventOptions;

		public AnalyticsEventBase(string eventName, int eventVersion, SendEventOptions sendEventOptions = SendEventOptions.kAppendNone, string eventPrefix = "")
		{
		}
	}
}
