using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	[BurstCompile]
	internal static class GPUResidentDrawerBurst
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ClassifyMaterials_000000EA_0024PostfixBurstDelegate(in NativeArray<EntityId> materialIDs, in NativeParallelHashMap<EntityId, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<EntityId> supportedMaterialIDs, ref NativeList<EntityId> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);

		internal static class ClassifyMaterials_000000EA_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<EntityId> materialIDs, in NativeParallelHashMap<EntityId, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<EntityId> supportedMaterialIDs, ref NativeList<EntityId> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void FindUnsupportedRenderers_000000EB_0024PostfixBurstDelegate(in NativeArray<EntityId> unsupportedMaterials, in NativeArray<SmallEntityIdArray>.ReadOnly materialIDArrays, in NativeArray<EntityId>.ReadOnly rendererGroups, ref NativeList<EntityId> unsupportedRenderers);

		internal static class FindUnsupportedRenderers_000000EB_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<EntityId> unsupportedMaterials, in NativeArray<SmallEntityIdArray>.ReadOnly materialIDArrays, in NativeArray<EntityId>.ReadOnly rendererGroups, ref NativeList<EntityId> unsupportedRenderers)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void GetMaterialsWithChangedPackedMaterial_000000EC_0024PostfixBurstDelegate(in NativeArray<EntityId> materialIDs, in NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<EntityId> filteredMaterials);

		internal static class GetMaterialsWithChangedPackedMaterial_000000EC_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<EntityId> materialIDs, in NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<EntityId> filteredMaterials)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(ClassifyMaterials_000000EA_0024PostfixBurstDelegate))]
		public static void ClassifyMaterials(in NativeArray<EntityId> materialIDs, in NativeParallelHashMap<EntityId, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<EntityId> supportedMaterialIDs, ref NativeList<EntityId> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
		{
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(FindUnsupportedRenderers_000000EB_0024PostfixBurstDelegate))]
		public static void FindUnsupportedRenderers(in NativeArray<EntityId> unsupportedMaterials, in NativeArray<SmallEntityIdArray>.ReadOnly materialIDArrays, in NativeArray<EntityId>.ReadOnly rendererGroups, ref NativeList<EntityId> unsupportedRenderers)
		{
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(GetMaterialsWithChangedPackedMaterial_000000EC_0024PostfixBurstDelegate))]
		public static void GetMaterialsWithChangedPackedMaterial(in NativeArray<EntityId> materialIDs, in NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<EntityId> filteredMaterials)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void ClassifyMaterials_0024BurstManaged(in NativeArray<EntityId> materialIDs, in NativeParallelHashMap<EntityId, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<EntityId> supportedMaterialIDs, ref NativeList<EntityId> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void FindUnsupportedRenderers_0024BurstManaged(in NativeArray<EntityId> unsupportedMaterials, in NativeArray<SmallEntityIdArray>.ReadOnly materialIDArrays, in NativeArray<EntityId>.ReadOnly rendererGroups, ref NativeList<EntityId> unsupportedRenderers)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void GetMaterialsWithChangedPackedMaterial_0024BurstManaged(in NativeArray<EntityId> materialIDs, in NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<EntityId> filteredMaterials)
		{
		}
	}
}
