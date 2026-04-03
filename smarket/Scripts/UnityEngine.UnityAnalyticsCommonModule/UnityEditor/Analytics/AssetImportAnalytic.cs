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
	internal class AssetImportAnalytic : AnalyticsEventBase
	{
		public string package_name;

		public int package_import_choice;

		public AssetImportAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static AssetImportAnalytic CreateAssetImportAnalytic()
		{
			return null;
		}
	}
}
