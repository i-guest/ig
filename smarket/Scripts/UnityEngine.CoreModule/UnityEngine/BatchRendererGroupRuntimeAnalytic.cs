using System;
using System.Runtime.InteropServices;
using UnityEngine.Analytics;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	internal class BatchRendererGroupRuntimeAnalytic : AnalyticsEventBase
	{
		private int brgRuntimeStatus;

		private BatchRendererGroupRuntimeAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic()
		{
			return null;
		}
	}
}
