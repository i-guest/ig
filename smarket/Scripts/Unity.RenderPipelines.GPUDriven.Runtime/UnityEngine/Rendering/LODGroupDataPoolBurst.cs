using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	[BurstCompile]
	internal static class LODGroupDataPoolBurst
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int FreeLODGroupData_000002F2_0024PostfixBurstDelegate(in NativeArray<EntityId> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles);

		internal static class FreeLODGroupData_000002F2_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static int Invoke(in NativeArray<EntityId> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
			{
				return 0;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate int AllocateOrGetLODGroupDataInstances_000002F3_0024PostfixBurstDelegate(in NativeArray<EntityId> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances);

		internal static class AllocateOrGetLODGroupDataInstances_000002F3_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static int Invoke(in NativeArray<EntityId> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
			{
				return 0;
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(FreeLODGroupData_000002F2_0024PostfixBurstDelegate))]
		public static int FreeLODGroupData(in NativeArray<EntityId> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
		{
			return 0;
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(AllocateOrGetLODGroupDataInstances_000002F3_0024PostfixBurstDelegate))]
		public static int AllocateOrGetLODGroupDataInstances(in NativeArray<EntityId> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static int FreeLODGroupData_0024BurstManaged(in NativeArray<EntityId> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static int AllocateOrGetLODGroupDataInstances_0024BurstManaged(in NativeArray<EntityId> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
		{
			return 0;
		}
	}
}
