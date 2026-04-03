using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.AI
{
	[StaticAccessor("NavMeshBuilderBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
	public static class NavMeshBuilder
	{
		public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results)
		{
		}

		public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results)
		{
		}

		private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects)
		{
			return null;
		}

		public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds)
		{
			return false;
		}

		private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds)
		{
			return false;
		}

		public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds)
		{
			return null;
		}

		private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds)
		{
			return null;
		}

		private static void CollectSourcesInternal_Injected(int includedLayerMask, [In] ref Bounds includedWorldBounds, IntPtr root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, ref ManagedSpanWrapper markups, bool includeOnlyMarkedObjects, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static bool UpdateNavMeshDataListInternal_Injected(IntPtr data, [In] ref NavMeshBuildSettings buildSettings, object sources, [In] ref Bounds localBounds)
		{
			return false;
		}

		private static IntPtr UpdateNavMeshDataAsyncListInternal_Injected(IntPtr data, [In] ref NavMeshBuildSettings buildSettings, object sources, [In] ref Bounds localBounds)
		{
			return (IntPtr)0;
		}
	}
}
