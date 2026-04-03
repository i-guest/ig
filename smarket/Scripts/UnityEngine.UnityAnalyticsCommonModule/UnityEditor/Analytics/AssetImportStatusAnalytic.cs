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
	internal class AssetImportStatusAnalytic : AnalyticsEventBase
	{
		public string package_name;

		public int package_items_count;

		public int package_import_status;

		public string error_message;

		public int project_assets_count;

		public int unselected_assets_count;

		public int selected_new_assets_count;

		public int selected_changed_assets_count;

		public int unchanged_assets_count;

		public string[] selected_asset_extensions;

		public AssetImportStatusAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic()
		{
			return null;
		}
	}
}
