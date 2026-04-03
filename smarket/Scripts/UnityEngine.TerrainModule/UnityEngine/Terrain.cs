using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
	[NativeHeader("TerrainScriptingClasses.h")]
	[StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
	[NativeHeader("Modules/Terrain/Public/Terrain.h")]
	public sealed class Terrain : Behaviour
	{
		public TerrainData terrainData => null;

		public bool allowAutoConnect => false;

		public int groupingID => 0;

		[NativeProperty("ActiveTerrainsScriptingArray")]
		public static Terrain[] activeTerrains => null;

		public float SampleHeight(Vector3 worldPosition)
		{
			return 0f;
		}

		public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom)
		{
		}

		private static IntPtr get_terrainData_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static bool get_allowAutoConnect_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int get_groupingID_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static float SampleHeight_Injected(IntPtr _unity_self, [In] ref Vector3 worldPosition)
		{
			return 0f;
		}

		private static void SetNeighbors_Injected(IntPtr _unity_self, IntPtr left, IntPtr top, IntPtr right, IntPtr bottom)
		{
		}
	}
}
