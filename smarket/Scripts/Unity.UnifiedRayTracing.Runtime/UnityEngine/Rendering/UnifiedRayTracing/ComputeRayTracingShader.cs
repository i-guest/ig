using Unity.Mathematics;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal class ComputeRayTracingShader : IRayTracingShader
	{
		private readonly ComputeShader m_Shader;

		private readonly int m_KernelIndex;

		private readonly int m_ComputeIndirectDispatchDimsKernelIndex;

		private uint3 m_ThreadGroupSizes;

		private readonly GraphicsBuffer m_DispatchBuffer;

		internal ComputeRayTracingShader(ComputeShader shader, string dispatchFuncName, GraphicsBuffer dispatchBuffer)
		{
		}

		public uint3 GetThreadGroupSizes()
		{
			return default(uint3);
		}

		public void SetAccelerationStructure(CommandBuffer cmd, string name, IRayTracingAccelStruct accelStruct)
		{
		}

		public void SetIntParam(CommandBuffer cmd, int nameID, int val)
		{
		}

		public void SetFloatParam(CommandBuffer cmd, int nameID, float val)
		{
		}

		public void SetVectorParam(CommandBuffer cmd, int nameID, Vector4 val)
		{
		}

		public void SetMatrixParam(CommandBuffer cmd, int nameID, Matrix4x4 val)
		{
		}

		public void SetTextureParam(CommandBuffer cmd, int nameID, RenderTargetIdentifier rt)
		{
		}

		public void SetBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer)
		{
		}

		public void SetBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer)
		{
		}

		public void SetConstantBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
		}

		public void SetConstantBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		public void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, uint width, uint height, uint depth)
		{
		}

		public void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, GraphicsBuffer argsBuffer)
		{
		}

		internal void SetIndirectDispatchDimensions(CommandBuffer cmd, GraphicsBuffer argsBuffer)
		{
		}

		internal void DispatchIndirect(CommandBuffer cmd, GraphicsBuffer scratchBuffer, GraphicsBuffer argsBuffer)
		{
		}

		public ulong GetTraceScratchBufferRequiredSizeInBytes(uint width, uint height, uint depth)
		{
			return 0uL;
		}
	}
}
