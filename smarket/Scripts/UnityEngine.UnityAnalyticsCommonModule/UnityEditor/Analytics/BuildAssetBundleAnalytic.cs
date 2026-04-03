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
	public class BuildAssetBundleAnalytic : AnalyticsEventBase
	{
		public bool success;

		public string error;

		public BuildAssetBundleAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic()
		{
			return null;
		}
	}
}
