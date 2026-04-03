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
	public class NavmeshBakingAnalytic : AnalyticsEventBase
	{
		private bool new_nav_api;

		private bool bake_at_runtime;

		private int height_meshes_count;

		private int offmesh_links_count;

		public NavmeshBakingAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic()
		{
			return null;
		}
	}
}
