namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal class ComputeRayTracingBackend : IRayTracingBackend
	{
		private readonly RayTracingResources m_Resources;

		public ComputeRayTracingBackend(RayTracingResources resources)
		{
		}

		public IRayTracingShader CreateRayTracingShader(Object shader, string kernelName, GraphicsBuffer dispatchBuffer)
		{
			return null;
		}

		public IRayTracingAccelStruct CreateAccelerationStructure(AccelerationStructureOptions options, ReferenceCounter counter)
		{
			return null;
		}

		public ulong GetRequiredTraceScratchBufferSizeInBytes(uint width, uint height, uint depth)
		{
			return 0uL;
		}
	}
}
