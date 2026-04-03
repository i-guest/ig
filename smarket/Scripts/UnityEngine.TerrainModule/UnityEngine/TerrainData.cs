using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
	[NativeHeader("TerrainScriptingClasses.h")]
	[UsedByNativeCode]
	public sealed class TerrainData : Object
	{
		private enum BoundaryValueType
		{
			MaxHeightmapRes = 0,
			MinDetailResPerPatch = 1,
			MaxDetailResPerPatch = 2,
			MaxDetailPatchCount = 3,
			MaxCoveragePerRes = 4,
			MinAlphamapRes = 5,
			MaxAlphamapRes = 6,
			MinBaseMapRes = 7,
			MaxBaseMapRes = 8
		}

		private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";

		private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";

		private const string k_HeightmapPrefix = "GetHeightmap().";

		private const string k_DetailDatabasePrefix = "GetDetailDatabase().";

		private const string k_TreeDatabasePrefix = "GetTreeDatabase().";

		private const string k_SplatDatabasePrefix = "GetSplatDatabase().";

		internal static readonly int k_MaximumResolution;

		internal static readonly int k_MinimumDetailResolutionPerPatch;

		internal static readonly int k_MaximumDetailResolutionPerPatch;

		internal static readonly int k_MaximumDetailPatchCount;

		internal static readonly int k_MinimumAlphamapResolution;

		internal static readonly int k_MaximumAlphamapResolution;

		internal static readonly int k_MinimumBaseMapResolution;

		internal static readonly int k_MaximumBaseMapResolution;

		public RenderTexture heightmapTexture
		{
			[NativeName("GetHeightmap().GetHeightmapTexture")]
			get
			{
				return null;
			}
		}

		public int heightmapResolution => 0;

		private int internalHeightmapResolution
		{
			[NativeName("GetHeightmap().GetResolution")]
			get
			{
				return 0;
			}
		}

		public Vector3 heightmapScale
		{
			[NativeName("GetHeightmap().GetScale")]
			get
			{
				return default(Vector3);
			}
		}

		public int holesResolution => 0;

		public Vector3 size
		{
			[NativeName("GetHeightmap().GetSize")]
			get
			{
				return default(Vector3);
			}
		}

		public TreeInstance[] treeInstances => null;

		public TreePrototype[] treePrototypes
		{
			[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = true)]
			get
			{
				return null;
			}
		}

		public int alphamapResolution => 0;

		private int Internal_alphamapResolution
		{
			[NativeName("GetSplatDatabase().GetAlphamapResolution")]
			get
			{
				return 0;
			}
		}

		public int alphamapWidth => 0;

		public int alphamapHeight => 0;

		internal Terrain[] users => null;

		[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType.DoubleColon)]
		[ThreadSafe]
		private static int GetBoundaryValue(BoundaryValueType type)
		{
			return 0;
		}

		[FreeFunction("TerrainDataScriptingInterface::Create")]
		private static void Internal_Create([Writable] TerrainData terrainData)
		{
		}

		public float[,] GetHeights(int xBase, int yBase, int width, int height)
		{
			return null;
		}

		[FreeFunction("TerrainDataScriptingInterface::GetHeights", HasExplicitThis = true)]
		private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height)
		{
			return null;
		}

		public bool[,] GetHoles(int xBase, int yBase, int width, int height)
		{
			return null;
		}

		[FreeFunction("TerrainDataScriptingInterface::GetHoles", HasExplicitThis = true)]
		private bool[,] Internal_GetHoles(int xBase, int yBase, int width, int height)
		{
			return null;
		}

		[NativeName("GetTreeDatabase().GetInstances")]
		private TreeInstance[] Internal_GetTreeInstances()
		{
			return null;
		}

		public float[,,] GetAlphamaps(int x, int y, int width, int height)
		{
			return null;
		}

		[FreeFunction("TerrainDataScriptingInterface::GetAlphamaps", HasExplicitThis = true)]
		private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height)
		{
			return null;
		}

		[RequiredByNativeCode]
		[NativeName("GetSplatDatabase().GetAlphamapResolution")]
		internal float GetAlphamapResolutionInternal()
		{
			return 0f;
		}

		private static IntPtr get_heightmapTexture_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static int get_internalHeightmapResolution_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void get_heightmapScale_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static float[,] Internal_GetHeights_Injected(IntPtr _unity_self, int xBase, int yBase, int width, int height)
		{
			return null;
		}

		private static bool[,] Internal_GetHoles_Injected(IntPtr _unity_self, int xBase, int yBase, int width, int height)
		{
			return null;
		}

		private static void Internal_GetTreeInstances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static TreePrototype[] get_treePrototypes_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static float[,,] Internal_GetAlphamaps_Injected(IntPtr _unity_self, int x, int y, int width, int height)
		{
			return null;
		}

		private static float GetAlphamapResolutionInternal_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static int get_Internal_alphamapResolution_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static Terrain[] get_users_Injected(IntPtr _unity_self)
		{
			return null;
		}
	}
}
