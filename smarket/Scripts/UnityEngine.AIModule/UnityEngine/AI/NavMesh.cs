using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	public static class NavMesh
	{
		public delegate void OnNavMeshPreUpdate();

		public static OnNavMeshPreUpdate onPreUpdate;

		[StaticAccessor("GetNavMeshManager()")]
		public static float avoidancePredictionTime
		{
			set
			{
			}
		}

		[StaticAccessor("GetNavMeshManager()")]
		public static int pathfindingIterationsPerFrame
		{
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void ClearPreUpdateListeners()
		{
		}

		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate()
		{
		}

		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			return false;
		}

		private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			return false;
		}

		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask)
		{
			hit = default(NavMeshHit);
			return false;
		}

		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
		{
			hit = default(NavMeshHit);
			return false;
		}

		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData)
		{
			return default(NavMeshDataInstance);
		}

		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
		{
			return default(NavMeshDataInstance);
		}

		[NativeName("IsValidSurfaceID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidNavMeshDataHandle(int handle)
		{
			return false;
		}

		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidLinkHandle(int handle)
		{
			return false;
		}

		[NativeName("SetSurfaceUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetOwner(int dataID, EntityId ownerID)
		{
			return false;
		}

		[StaticAccessor("GetNavMeshManager()")]
		[NativeName("SetLinkUserID")]
		internal static bool InternalSetLinkOwner(int linkID, EntityId ownerID)
		{
			return false;
		}

		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataInternal(NavMeshData navMeshData)
		{
			return 0;
		}

		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
		{
			return 0;
		}

		[NativeName("UnloadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveNavMeshDataInternal(int handle)
		{
		}

		public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation)
		{
			return default(NavMeshLinkInstance);
		}

		public static void RemoveLink(NavMeshLinkInstance handle)
		{
		}

		public static void SetLinkActive(NavMeshLinkInstance handle, bool value)
		{
		}

		public static bool IsLinkOccupied(NavMeshLinkInstance handle)
		{
			return false;
		}

		public static bool IsLinkValid(NavMeshLinkInstance handle)
		{
			return false;
		}

		public static void SetLinkOwner(NavMeshLinkInstance handle, Object owner)
		{
		}

		[NativeName("AddLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation)
		{
			return 0;
		}

		[StaticAccessor("GetNavMeshManager()")]
		[NativeName("RemoveLink")]
		internal static void RemoveLinkInternal(int handle)
		{
		}

		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsOffMeshConnectionOccupied(int handle)
		{
			return false;
		}

		[StaticAccessor("GetNavMeshManager()")]
		internal static void SetOffMeshConnectionActive(int linkHandle, bool activated)
		{
		}

		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, NavMeshQueryFilter filter, NavMeshPath path)
		{
			return false;
		}

		private static bool CalculatePathFilterInternal(Vector3 sourcePosition, Vector3 targetPosition, NavMeshPath path, int type, int mask, float[] costs)
		{
			return false;
		}

		public static NavMeshBuildSettings GetSettingsByID(int agentTypeID)
		{
			return default(NavMeshBuildSettings);
		}

		private static bool CalculatePathInternal_Injected([In] ref Vector3 sourcePosition, [In] ref Vector3 targetPosition, int areaMask, IntPtr path)
		{
			return false;
		}

		private static bool FindClosestEdge_Injected([In] ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask)
		{
			hit = default(NavMeshHit);
			return false;
		}

		private static bool SamplePosition_Injected([In] ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
		{
			hit = default(NavMeshHit);
			return false;
		}

		private static bool InternalSetOwner_Injected(int dataID, [In] ref EntityId ownerID)
		{
			return false;
		}

		private static bool InternalSetLinkOwner_Injected(int linkID, [In] ref EntityId ownerID)
		{
			return false;
		}

		private static int AddNavMeshDataInternal_Injected(IntPtr navMeshData)
		{
			return 0;
		}

		private static int AddNavMeshDataTransformedInternal_Injected(IntPtr navMeshData, [In] ref Vector3 position, [In] ref Quaternion rotation)
		{
			return 0;
		}

		private static int AddLinkInternal_Injected([In] ref NavMeshLinkData link, [In] ref Vector3 position, [In] ref Quaternion rotation)
		{
			return 0;
		}

		private static bool CalculatePathFilterInternal_Injected([In] ref Vector3 sourcePosition, [In] ref Vector3 targetPosition, IntPtr path, int type, int mask, ref ManagedSpanWrapper costs)
		{
			return false;
		}

		private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret)
		{
			ret = default(NavMeshBuildSettings);
		}
	}
}
