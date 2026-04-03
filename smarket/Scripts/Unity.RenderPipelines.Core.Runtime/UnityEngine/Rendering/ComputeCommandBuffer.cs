using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Profiling;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public class ComputeCommandBuffer : BaseCommandBuffer, IComputeCommandBuffer, IBaseCommandBuffer
	{
		internal ComputeCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync)
			: base(null, null, isAsync: false)
		{
		}

		public void SetInvertCulling(bool invertCulling)
		{
		}

		public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val)
		{
		}

		public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val)
		{
		}

		public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val)
		{
		}

		public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values)
		{
		}

		public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val)
		{
		}

		public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values)
		{
		}

		public void SetRayTracingShaderPass(RayTracingShader rayTracingShader, string passName)
		{
		}

		public void SetViewport(Rect pixelRect)
		{
		}

		public void EnableScissorRect(Rect scissor)
		{
		}

		public void DisableScissorRect()
		{
		}

		public void SetGlobalFloat(int nameID, float value)
		{
		}

		public void SetGlobalInt(int nameID, int value)
		{
		}

		public void SetGlobalInteger(int nameID, int value)
		{
		}

		public void SetGlobalVector(int nameID, Vector4 value)
		{
		}

		public void SetGlobalColor(int nameID, Color value)
		{
		}

		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
		}

		public void EnableShaderKeyword(string keyword)
		{
		}

		public void EnableKeyword(in GlobalKeyword keyword)
		{
		}

		public void EnableKeyword(Material material, in LocalKeyword keyword)
		{
		}

		public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword)
		{
		}

		public void DisableShaderKeyword(string keyword)
		{
		}

		public void DisableKeyword(in GlobalKeyword keyword)
		{
		}

		public void DisableKeyword(Material material, in LocalKeyword keyword)
		{
		}

		public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword)
		{
		}

		public void SetKeyword(in GlobalKeyword keyword, bool value)
		{
		}

		public void SetKeyword(Material material, in LocalKeyword keyword, bool value)
		{
		}

		public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value)
		{
		}

		public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
		{
		}

		public void SetGlobalDepthBias(float bias, float slopeBias)
		{
		}

		public void SetGlobalFloatArray(int nameID, float[] values)
		{
		}

		public void SetGlobalVectorArray(int nameID, Vector4[] values)
		{
		}

		public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values)
		{
		}

		public void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat)
		{
		}

		public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
		{
		}

		public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType)
		{
		}

		public void BeginSample(string name)
		{
		}

		public void EndSample(string name)
		{
		}

		public void BeginSample(CustomSampler sampler)
		{
		}

		public void EndSample(CustomSampler sampler)
		{
		}

		public void BeginSample(ProfilerMarker marker)
		{
		}

		public void EndSample(ProfilerMarker marker)
		{
		}

		public void IncrementUpdateCount(RenderTargetIdentifier dest)
		{
		}

		public void SetBufferData(ComputeBuffer buffer, Array data)
		{
		}

		public void SetBufferData<T>(ComputeBuffer buffer, List<T> data) where T : struct
		{
		}

		public void SetBufferData<T>(ComputeBuffer buffer, NativeArray<T> data) where T : struct
		{
		}

		public void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
		}

		public void SetBufferData<T>(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
		}

		public void SetBufferData<T>(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
		}

		public void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue)
		{
		}

		public void SetBufferData(GraphicsBuffer buffer, Array data)
		{
		}

		public void SetBufferData<T>(GraphicsBuffer buffer, List<T> data) where T : struct
		{
		}

		public void SetBufferData<T>(GraphicsBuffer buffer, NativeArray<T> data) where T : struct
		{
		}

		public void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
		}

		public void SetBufferData<T>(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
		}

		public void SetBufferData<T>(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
		}

		public void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue)
		{
		}

		public void SetupCameraProperties(Camera camera)
		{
		}

		public void InvokeOnRenderObjectCallbacks()
		{
		}

		public void SetComputeFloatParam(ComputeShader computeShader, string name, float val)
		{
		}

		public void SetComputeIntParam(ComputeShader computeShader, string name, int val)
		{
		}

		public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
		{
		}

		public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values)
		{
		}

		public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val)
		{
		}

		public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values)
		{
		}

		public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
		{
		}

		public void SetComputeFloatParams(ComputeShader computeShader, int nameID, params float[] values)
		{
		}

		public void SetComputeIntParams(ComputeShader computeShader, string name, params int[] values)
		{
		}

		public void SetComputeIntParams(ComputeShader computeShader, int nameID, params int[] values)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel, RenderTextureSubElement element)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel, RenderTextureSubElement element)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBufferHandle bufferHandle)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer)
		{
		}

		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size)
		{
		}

		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
		}

		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size)
		{
		}

		public void SetComputeParamsFromMaterial(ComputeShader computeShader, int kernelIndex, Material material)
		{
		}

		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
		}

		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset)
		{
		}

		public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure)
		{
		}

		public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin)
		{
		}

		public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, RayTracingAccelerationStructure.BuildSettings buildSettings)
		{
		}

		public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
		}

		public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
		}

		public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
		}

		public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure)
		{
		}

		public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer)
		{
		}

		public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
		{
		}

		public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer)
		{
		}

		public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer)
		{
		}

		public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBufferHandle bufferHandle)
		{
		}

		public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle)
		{
		}

		public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size)
		{
		}

		public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
		}

		public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size)
		{
		}

		public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, TextureHandle rt)
		{
		}

		public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, TextureHandle rt)
		{
		}

		public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val)
		{
		}

		public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val)
		{
		}

		public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, params float[] values)
		{
		}

		public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, params float[] values)
		{
		}

		public void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val)
		{
		}

		public void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val)
		{
		}

		public void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, params int[] values)
		{
		}

		public void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, params int[] values)
		{
		}

		public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val)
		{
		}

		public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val)
		{
		}

		public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, params Vector4[] values)
		{
		}

		public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, params Vector4[] values)
		{
		}

		public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val)
		{
		}

		public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
		{
		}

		public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, params Matrix4x4[] values)
		{
		}

		public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, params Matrix4x4[] values)
		{
		}

		public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera)
		{
		}

		public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, GraphicsBuffer argsBuffer, uint argsOffset, Camera camera)
		{
		}

		public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
		}

		public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
		}

		public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
		}

		public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
		}

		public void SetGlobalFloat(string name, float value)
		{
		}

		public void SetGlobalInt(string name, int value)
		{
		}

		public void SetGlobalInteger(string name, int value)
		{
		}

		public void SetGlobalVector(string name, Vector4 value)
		{
		}

		public void SetGlobalColor(string name, Color value)
		{
		}

		public void SetGlobalMatrix(string name, Matrix4x4 value)
		{
		}

		public void SetGlobalFloatArray(string propertyName, List<float> values)
		{
		}

		public void SetGlobalFloatArray(int nameID, List<float> values)
		{
		}

		public void SetGlobalFloatArray(string propertyName, float[] values)
		{
		}

		public void SetGlobalVectorArray(string propertyName, List<Vector4> values)
		{
		}

		public void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
		}

		public void SetGlobalVectorArray(string propertyName, Vector4[] values)
		{
		}

		public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values)
		{
		}

		public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
		}

		public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values)
		{
		}

		public void SetGlobalTexture(string name, TextureHandle value)
		{
		}

		public void SetGlobalTexture(int nameID, TextureHandle value)
		{
		}

		public void SetGlobalTexture(string name, TextureHandle value, RenderTextureSubElement element)
		{
		}

		public void SetGlobalTexture(int nameID, TextureHandle value, RenderTextureSubElement element)
		{
		}

		public void SetGlobalBuffer(string name, ComputeBuffer value)
		{
		}

		public void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
		}

		public void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
		}

		public void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
		}

		public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size)
		{
		}

		public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size)
		{
		}

		public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size)
		{
		}

		public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size)
		{
		}

		public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
		}

		public void SetSinglePassStereo(SinglePassStereoMode mode)
		{
		}

		public void IssuePluginEvent(IntPtr callback, int eventID)
		{
		}

		public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data)
		{
		}

		public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
		}

		public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData)
		{
		}

		void IBaseCommandBuffer.EnableKeyword(in GlobalKeyword keyword)
		{
		}

		void IBaseCommandBuffer.EnableKeyword(Material material, in LocalKeyword keyword)
		{
		}

		void IBaseCommandBuffer.EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword)
		{
		}

		void IBaseCommandBuffer.DisableKeyword(in GlobalKeyword keyword)
		{
		}

		void IBaseCommandBuffer.DisableKeyword(Material material, in LocalKeyword keyword)
		{
		}

		void IBaseCommandBuffer.DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword)
		{
		}

		void IBaseCommandBuffer.SetKeyword(in GlobalKeyword keyword, bool value)
		{
		}

		void IBaseCommandBuffer.SetKeyword(Material material, in LocalKeyword keyword, bool value)
		{
		}

		void IBaseCommandBuffer.SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value)
		{
		}
	}
}
