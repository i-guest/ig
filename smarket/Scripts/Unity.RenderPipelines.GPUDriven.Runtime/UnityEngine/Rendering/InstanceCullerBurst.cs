using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;

namespace UnityEngine.Rendering
{
	[BurstCompile]
	internal static class InstanceCullerBurst
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void SetupCullingJobInput_0000014D_0024PostfixBurstDelegate(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric, float* meshLodConstant);

		internal static class SetupCullingJobInput_0000014D_0024BurstDirectCall
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

			public unsafe static void Invoke(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric, float* meshLodConstant)
			{
			}
		}

		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(SetupCullingJobInput_0000014D_0024PostfixBurstDelegate))]
		public unsafe static void SetupCullingJobInput(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric, float* meshLodConstant)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void SetupCullingJobInput_0024BurstManaged(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric, float* meshLodConstant)
		{
		}
	}
}
