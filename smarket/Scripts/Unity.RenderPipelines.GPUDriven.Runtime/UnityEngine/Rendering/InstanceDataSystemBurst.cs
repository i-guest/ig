using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	[BurstCompile]
	internal static class InstanceDataSystemBurst
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ReallocateInstances_000002A0_0024PostfixBurstDelegate(bool implicitInstanceIndices, in NativeArray<EntityId> rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData> packedRendererData, in NativeArray<int> instanceOffsets, in NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash);

		internal static class ReallocateInstances_000002A0_0024BurstDirectCall
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

			public static void Invoke(bool implicitInstanceIndices, in NativeArray<EntityId> rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData> packedRendererData, in NativeArray<int> instanceOffsets, in NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void FreeRendererGroupInstances_000002A1_0024PostfixBurstDelegate(in NativeArray<EntityId>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash);

		internal static class FreeRendererGroupInstances_000002A1_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<EntityId>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
			{
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void FreeInstances_000002A2_0024PostfixBurstDelegate(in NativeArray<InstanceHandle>.ReadOnly instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash);

		internal static class FreeInstances_000002A2_0024BurstDirectCall
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

			public static void Invoke(in NativeArray<InstanceHandle>.ReadOnly instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(ReallocateInstances_000002A0_0024PostfixBurstDelegate))]
		public static void ReallocateInstances(bool implicitInstanceIndices, in NativeArray<EntityId> rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData> packedRendererData, in NativeArray<int> instanceOffsets, in NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(FreeRendererGroupInstances_000002A1_0024PostfixBurstDelegate))]
		public static void FreeRendererGroupInstances(in NativeArray<EntityId>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(FreeInstances_000002A2_0024PostfixBurstDelegate))]
		public static void FreeInstances(in NativeArray<InstanceHandle>.ReadOnly instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void ReallocateInstances_0024BurstManaged(bool implicitInstanceIndices, in NativeArray<EntityId> rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData> packedRendererData, in NativeArray<int> instanceOffsets, in NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void FreeRendererGroupInstances_0024BurstManaged(in NativeArray<EntityId>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal static void FreeInstances_0024BurstManaged(in NativeArray<InstanceHandle>.ReadOnly instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUPerCameraInstanceData perCameraInstanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
		}
	}
}
