using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeContainer]
	[StaticAccessor("LightProbeContextWrapper", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Camera/RenderLoops/LightProbeContext.h")]
	public struct LightProbesQuery : IDisposable
	{
		[NativeContainer]
		internal struct LightProbesQueryDispose
		{
			[NativeDisableUnsafePtrRestriction]
			internal IntPtr m_LightProbeContextWrapper;

			public void Dispose()
			{
			}
		}

		internal struct LightProbesQueryDisposeJob : IJob
		{
			internal LightProbesQueryDispose Data;

			public void Execute()
			{
			}
		}

		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_LightProbeContextWrapper;

		internal Allocator m_AllocatorLabel;

		public LightProbesQuery(Allocator allocator)
		{
			m_LightProbeContextWrapper = (IntPtr)0;
			m_AllocatorLabel = default(Allocator);
		}

		public void Dispose()
		{
		}

		public JobHandle Dispose(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		private static IntPtr Create()
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		private static void Destroy(IntPtr lightProbeContextWrapper)
		{
		}

		public void CalculateInterpolatedLightAndOcclusionProbes(NativeArray<Vector3> positions, NativeArray<int> tetrahedronIndices, NativeArray<SphericalHarmonicsL2> lightProbes, NativeArray<Vector4> occlusionProbes)
		{
		}

		[ThreadSafe]
		private static void CalculateInterpolatedLightAndOcclusionProbes(IntPtr lightProbeContextWrapper, IntPtr positions, IntPtr tetrahedronIndices, IntPtr lightProbes, IntPtr occlusionProbes, int count)
		{
		}
	}
}
