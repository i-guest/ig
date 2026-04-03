namespace UnityEngine.Rendering.UnifiedRayTracing
{
	public static class RayTracingHelper
	{
		public const GraphicsBuffer.Target ScratchBufferTarget = GraphicsBuffer.Target.Structured;

		public static GraphicsBuffer CreateDispatchIndirectBuffer()
		{
			return null;
		}

		public static GraphicsBuffer CreateScratchBufferForBuildAndDispatch(IRayTracingAccelStruct accelStruct, IRayTracingShader shader, uint dispatchWidth, uint dispatchHeight, uint dispatchDepth)
		{
			return null;
		}

		public static GraphicsBuffer CreateScratchBufferForBuild(IRayTracingAccelStruct accelStruct)
		{
			return null;
		}

		public static GraphicsBuffer CreateScratchBufferForTrace(IRayTracingShader shader, uint dispatchWidth, uint dispatchHeight, uint dispatchDepth)
		{
			return null;
		}

		public static void ResizeScratchBufferForTrace(IRayTracingShader shader, uint dispatchWidth, uint dispatchHeight, uint dispatchDepth, ref GraphicsBuffer scratchBuffer)
		{
		}

		public static void ResizeScratchBufferForBuild(IRayTracingAccelStruct accelStruct, ref GraphicsBuffer scratchBuffer)
		{
		}
	}
}
