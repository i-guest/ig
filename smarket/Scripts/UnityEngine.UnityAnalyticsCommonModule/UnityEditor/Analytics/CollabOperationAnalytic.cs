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
	public class CollabOperationAnalytic : AnalyticsEventBase
	{
		public string category;

		public string operation;

		public string result;

		public long start_ts;

		public long duration;

		public CollabOperationAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static CollabOperationAnalytic CreateCollabOperationAnalytic()
		{
			return null;
		}
	}
}
