using System;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	public sealed class RayTracingContext : IDisposable
	{
		private readonly IRayTracingBackend m_Backend;

		private readonly ReferenceCounter m_AccelStructCounter;

		private readonly GraphicsBuffer m_DispatchBuffer;

		public RayTracingResources Resources { get; private set; }

		public RayTracingBackend BackendType { get; private set; }

		public RayTracingContext(RayTracingBackend backend, RayTracingResources resources)
		{
		}

		public RayTracingContext(RayTracingResources resources)
		{
		}

		public void Dispose()
		{
		}

		public static bool IsBackendSupported(RayTracingBackend backend)
		{
			return false;
		}

		public IRayTracingShader CreateRayTracingShader(Object shader)
		{
			return null;
		}

		public IRayTracingShader LoadRayTracingShaderFromAssetBundle(AssetBundle assetBundle, string name)
		{
			return null;
		}

		public IRayTracingAccelStruct CreateAccelerationStructure(AccelerationStructureOptions options)
		{
			return null;
		}

		public ulong GetRequiredTraceScratchBufferSizeInBytes(uint width, uint height, uint depth)
		{
			return 0uL;
		}

		public static uint GetScratchBufferStrideInBytes()
		{
			return 0u;
		}
	}
}
