using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	internal class BatchRenderGroupUsageAnalytic : AnalyticsEventBase
	{
		public int maxBRGInstance;

		public int maxMeshCount;

		public int maxMaterialCount;

		public int maxDrawCommandBatch;

		public BatchRenderGroupUsageAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic()
		{
			return null;
		}
	}
}
