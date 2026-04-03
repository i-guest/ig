using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	[BurstCompile]
	internal static class InstanceCullingBatcherBurst
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void RemoveDrawInstanceIndices_00000188_0024PostfixBurstDelegate(in NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches);

		internal static class RemoveDrawInstanceIndices_00000188_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CreateDrawBatches_0000018C_0024PostfixBurstDelegate(bool implicitInstanceIndices, in NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID> batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances);

		internal static class CreateDrawBatches_0000018C_0024BurstDirectCall
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

			public static void Invoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID> batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
			{
			}
		}

		private static void RemoveDrawRange(in RangeKey key, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges)
		{
		}

		private static void RemoveDrawBatch(in DrawKey key, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches)
		{
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(RemoveDrawInstanceIndices_00000188_0024PostfixBurstDelegate))]
		public static void RemoveDrawInstanceIndices(in NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
		{
		}

		private static ref DrawRange EditDrawRange(in RangeKey key, NativeParallelHashMap<RangeKey, int> rangeHash, NativeList<DrawRange> drawRanges)
		{
			throw null;
		}

		private static ref DrawBatch EditDrawBatch(in DrawKey key, in SubMeshDescriptor subMeshDescriptor, NativeParallelHashMap<DrawKey, int> batchHash, NativeList<DrawBatch> drawBatches)
		{
			throw null;
		}

		private static void ProcessRenderer(int i, bool implicitInstanceIndices, in GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<EntityId, BatchMeshID> batchMeshHash, NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialDataHash, NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash, NativeArray<InstanceHandle> instances, NativeList<DrawInstance> drawInstances, NativeParallelHashMap<RangeKey, int> rangeHash, NativeList<DrawRange> drawRanges, NativeParallelHashMap<DrawKey, int> batchHash, NativeList<DrawBatch> drawBatches)
		{
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(CreateDrawBatches_0000018C_0024PostfixBurstDelegate))]
		public static void CreateDrawBatches(bool implicitInstanceIndices, in NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID> batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void RemoveDrawInstanceIndices_0024BurstManaged(in NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void CreateDrawBatches_0024BurstManaged(bool implicitInstanceIndices, in NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<EntityId, BatchMeshID> batchMeshHash, in NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash, in NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
		{
		}
	}
}
