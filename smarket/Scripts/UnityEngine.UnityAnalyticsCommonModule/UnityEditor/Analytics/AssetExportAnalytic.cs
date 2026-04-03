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
	internal class AssetExportAnalytic : AnalyticsEventBase
	{
		public string package_name;

		public string error_message;

		public int items_count;

		public string[] asset_extensions;

		public bool include_upm_dependencies;

		public AssetExportAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static AssetExportAnalytic CreateAssetExportAnalytic()
		{
			return null;
		}
	}
}
