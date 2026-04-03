using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Profiling;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
	public class CommandBuffer : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(CommandBuffer commandBuffer)
			{
				return (IntPtr)0;
			}
		}

		public static bool ThrowOnSetRenderTarget;

		internal IntPtr m_Ptr;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sizeInBytes
		{
			[NativeMethod("GetBufferSize")]
			get
			{
				return 0;
			}
		}

		public void RequestAsyncReadback(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_1([NotNull] ComputeBuffer src, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_2([NotNull] ComputeBuffer src, int size, int offset, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_3([NotNull] Texture src, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_4([NotNull] Texture src, int mipIndex, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_5([NotNull] Texture src, int mipIndex, GraphicsFormat dstFormat, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_6([NotNull] Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_7([NotNull] Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_8([NotNull] GraphicsBuffer src, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddRequestAsyncReadback")]
		private unsafe void Internal_RequestAsyncReadback_9([NotNull] GraphicsBuffer src, int size, int offset, [NotNull] Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null)
		{
		}

		[NativeMethod("AddSetInvertCulling")]
		public void SetInvertCulling(bool invertCulling)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = true)]
		private void Internal_SetSinglePassStereo(SinglePassStereoMode mode)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
		private static IntPtr InitBuffer()
		{
			return (IntPtr)0;
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = true)]
		private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return (IntPtr)0;
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = true)]
		private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = true, IsThreadSafe = true)]
		private void ReleaseBuffer()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeFloatParam", HasExplicitThis = true)]
		public void SetComputeFloatParam([NotNull] ComputeShader computeShader, int nameID, float val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = true)]
		public void SetComputeIntParam([NotNull] ComputeShader computeShader, int nameID, int val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = true)]
		public void SetComputeVectorParam([NotNull] ComputeShader computeShader, int nameID, Vector4 val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = true)]
		public void SetComputeVectorArrayParam([NotNull] ComputeShader computeShader, int nameID, Vector4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixParam", HasExplicitThis = true)]
		public void SetComputeMatrixParam([NotNull] ComputeShader computeShader, int nameID, Matrix4x4 val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixArrayParam", HasExplicitThis = true)]
		public void SetComputeMatrixArrayParam([NotNull] ComputeShader computeShader, int nameID, Matrix4x4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = true)]
		private void Internal_SetComputeFloats([NotNull] ComputeShader computeShader, int nameID, float[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeInts", HasExplicitThis = true)]
		private void Internal_SetComputeInts([NotNull] ComputeShader computeShader, int nameID, int[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = true)]
		private void Internal_SetComputeTextureParam([NotNull] ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeBufferParam([NotNull] ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeGraphicsBufferHandleParam([NotNull] ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeGraphicsBufferParam([NotNull] ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeConstantComputeBufferParam([NotNull] ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeConstantGraphicsBufferParam([NotNull] ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeParamsFromMaterial", HasExplicitThis = true)]
		private void Internal_SetComputeParamsFromMaterial([NotNull] ComputeShader computeShader, int kernelIndex, Material material)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = true, ThrowsException = true)]
		private void Internal_DispatchCompute([NotNull] ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchComputeIndirect", HasExplicitThis = true, ThrowsException = true)]
		private void Internal_DispatchComputeIndirect([NotNull] ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchComputeIndirect", HasExplicitThis = true, ThrowsException = true)]
		private void Internal_DispatchComputeIndirectGraphicsBuffer([NotNull] ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingComputeBufferParam([NotNull] RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingGraphicsBufferParam([NotNull] RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingGraphicsBufferHandleParam([NotNull] RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingConstantBufferParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingConstantComputeBufferParam([NotNull] RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingConstantBufferParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingConstantGraphicsBufferParam([NotNull] RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingTextureParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingTextureParam([NotNull] RayTracingShader rayTracingShader, int nameID, ref RenderTargetIdentifier rt)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingFloatParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingFloatParam([NotNull] RayTracingShader rayTracingShader, int nameID, float val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingIntParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingIntParam([NotNull] RayTracingShader rayTracingShader, int nameID, int val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingVectorParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingVectorParam([NotNull] RayTracingShader rayTracingShader, int nameID, Vector4 val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingVectorArrayParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingVectorArrayParam([NotNull] RayTracingShader rayTracingShader, int nameID, Vector4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingMatrixParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingMatrixParam([NotNull] RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingMatrixArrayParam", HasExplicitThis = true)]
		private void Internal_SetRayTracingMatrixArrayParam([NotNull] RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingFloats", HasExplicitThis = true)]
		private void Internal_SetRayTracingFloats([NotNull] RayTracingShader rayTracingShader, int nameID, float[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingInts", HasExplicitThis = true)]
		private void Internal_SetRayTracingInts([NotNull] RayTracingShader rayTracingShader, int nameID, int[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_BuildRayTracingAccelerationStructure", HasExplicitThis = true)]
		private void Internal_BuildRayTracingAccelerationStructure([NotNull] RayTracingAccelerationStructure accelerationStructure, RayTracingAccelerationStructure.BuildSettings buildSettings)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingAccelerationStructure", HasExplicitThis = true)]
		private void Internal_SetRayTracingAccelerationStructure([NotNull] RayTracingShader rayTracingShader, int nameID, [NotNull] RayTracingAccelerationStructure accelerationStructure)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeRayTracingAccelerationStructure", HasExplicitThis = true)]
		private void Internal_SetComputeRayTracingAccelerationStructure([NotNull] ComputeShader computeShader, int kernelIndex, int nameID, [NotNull] RayTracingAccelerationStructure accelerationStructure)
		{
		}

		[NativeMethod("AddSetRayTracingShaderPass")]
		public void SetRayTracingShaderPass([NotNull] RayTracingShader rayTracingShader, string passName)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchRays", HasExplicitThis = true, ThrowsException = true)]
		private void Internal_DispatchRays([NotNull] RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, Camera camera = null)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchRaysIndirect", HasExplicitThis = true, ThrowsException = true)]
		private void Internal_DispatchRaysIndirect([NotNull] RayTracingShader rayTracingShader, string rayGenShaderName, [NotNull] GraphicsBuffer argsBuffer, uint argsOffset = 0u, Camera camera = null)
		{
		}

		[NativeMethod("AddGenerateMips")]
		private void Internal_GenerateMips(RenderTargetIdentifier rt)
		{
		}

		[NativeMethod("AddCopyCounterValue")]
		private void CopyCounterValueCC(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
		}

		[NativeMethod("AddCopyCounterValue")]
		private void CopyCounterValueGC(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
		{
		}

		[NativeMethod("AddCopyCounterValue")]
		private void CopyCounterValueCG(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
		}

		[NativeMethod("AddCopyCounterValue")]
		private void CopyCounterValueGG(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes)
		{
		}

		[NativeMethod("ClearCommands")]
		public void Clear()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = true)]
		private void Internal_DrawMesh([NotNull] Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		[NativeMethod("AddDrawMultipleMeshes")]
		private void Internal_DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, int[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		[NativeMethod("AddDrawRenderer")]
		private void Internal_DrawRenderer([NotNull] Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
		}

		[NativeMethod("AddDrawRendererList")]
		private void Internal_DrawRendererList(RendererList rendererList)
		{
		}

		[NativeMethod("AddDrawProcedural")]
		private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		[NativeMethod("AddDrawProceduralIndexed")]
		private void Internal_DrawProceduralIndexed(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndirect", HasExplicitThis = true)]
		private void Internal_DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndexedIndirect", HasExplicitThis = true)]
		private void Internal_DrawProceduralIndexedIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndirect", HasExplicitThis = true)]
		private void Internal_DrawProceduralIndirectGraphicsBuffer(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndexedIndirect", HasExplicitThis = true)]
		private void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = true)]
		private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedProcedural", HasExplicitThis = true)]
		private void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedIndirect", HasExplicitThis = true)]
		private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedIndirect", HasExplicitThis = true)]
		private void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = true)]
		private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Texture", HasExplicitThis = true, ThrowsException = true)]
		private void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = true, ThrowsException = true)]
		private void SetRandomWriteTarget_Buffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = true, ThrowsException = true)]
		private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = true, ThrowsException = true)]
		public void ClearRandomWriteTargets()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = true, ThrowsException = true)]
		public void SetViewport(Rect pixelRect)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableScissorRect", HasExplicitThis = true, ThrowsException = true)]
		public void EnableScissorRect(Rect scissor)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = true, ThrowsException = true)]
		public void DisableScissorRect()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = true)]
		private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = true)]
		private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = true)]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = true)]
		private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = true)]
		public void ReleaseTemporaryRT(int nameID)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1f, uint stencil = 0u)
		{
		}

		public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth = 1f, uint stencil = 0u)
		{
		}

		public void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth = 1f, uint stencil = 0u)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = true)]
		public void SetGlobalFloat(int nameID, float value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = true)]
		public void SetGlobalInt(int nameID, int value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = true)]
		public void SetGlobalInteger(int nameID, int value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = true)]
		public void SetGlobalVector(int nameID, Vector4 value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = true)]
		public void SetGlobalColor(int nameID, Color value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = true)]
		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = true)]
		public void EnableShaderKeyword(string keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = true)]
		private void EnableGlobalKeyword(GlobalKeyword keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableMaterialKeyword", HasExplicitThis = true)]
		private void EnableMaterialKeyword(Material material, LocalKeyword keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableComputeKeyword", HasExplicitThis = true)]
		private void EnableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword)
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

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = true)]
		public void DisableShaderKeyword(string keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = true)]
		private void DisableGlobalKeyword(GlobalKeyword keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableMaterialKeyword", HasExplicitThis = true)]
		private void DisableMaterialKeyword(Material material, LocalKeyword keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableComputeKeyword", HasExplicitThis = true)]
		private void DisableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword)
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

		[FreeFunction("RenderingCommandBuffer_Bindings::SetShaderKeyword", HasExplicitThis = true)]
		private void SetGlobalKeyword(GlobalKeyword keyword, bool value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetMaterialKeyword", HasExplicitThis = true)]
		private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeKeyword", HasExplicitThis = true)]
		private void SetComputeKeyword(ComputeShader computeShader, LocalKeyword keyword, bool value)
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

		[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = true, ThrowsException = true)]
		public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
		{
		}

		[NativeMethod("AddSetGlobalDepthBias")]
		public void SetGlobalDepthBias(float bias, float slopeBias)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
		public void SetExecutionFlags(CommandBufferExecutionFlags flags)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
		private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags)
		{
			return false;
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArrayListImpl", HasExplicitThis = true)]
		private void SetGlobalFloatArrayListImpl(int nameID, object values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArrayListImpl", HasExplicitThis = true)]
		private void SetGlobalVectorArrayListImpl(int nameID, object values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArrayListImpl", HasExplicitThis = true)]
		private void SetGlobalMatrixArrayListImpl(int nameID, object values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = true, ThrowsException = true)]
		public void SetGlobalFloatArray(int nameID, [NotNull] float[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = true, ThrowsException = true)]
		public void SetGlobalVectorArray(int nameID, [NotNull] Vector4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = true, ThrowsException = true)]
		public void SetGlobalMatrixArray(int nameID, [NotNull] Matrix4x4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = true, ThrowsException = true)]
		public void SetLateLatchProjectionMatrices([NotNull] Matrix4x4[] projectionMat)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = true)]
		public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = true)]
		public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = true)]
		private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = true)]
		private void SetGlobalBufferInternal(int nameID, ComputeBuffer value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = true)]
		private void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetShadowSamplingMode_Impl", HasExplicitThis = true)]
		private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventInternal", HasExplicitThis = true)]
		private void IssuePluginEventInternal(IntPtr callback, int eventID)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = true)]
		public void BeginSample(string name)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = true)]
		public void EndSample(string name)
		{
		}

		public void BeginSample(CustomSampler sampler)
		{
		}

		public void EndSample(CustomSampler sampler)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = true)]
		private void BeginSample_CustomSampler([NotNull] CustomSampler sampler)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = true)]
		private void EndSample_CustomSampler([NotNull] CustomSampler sampler)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventAndDataInternal", HasExplicitThis = true)]
		private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginCustomBlitInternal", HasExplicitThis = true)]
		private void IssuePluginCustomBlitInternal(IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginCustomTextureUpdateInternal", HasExplicitThis = true)]
		private void IssuePluginCustomTextureUpdateInternal(IntPtr callback, Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = true)]
		private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = true)]
		private void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::IncrementUpdateCount", HasExplicitThis = true)]
		public void IncrementUpdateCount(RenderTargetIdentifier dest)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = true)]
		public void SetInstanceMultiplier(uint multiplier)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetFoveatedRenderingMode", HasExplicitThis = true)]
		public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetWireframe", HasExplicitThis = true)]
		public void SetWireframe(bool enable)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ConfigureFoveatedRendering", HasExplicitThis = true)]
		public void ConfigureFoveatedRendering(IntPtr platformData)
		{
		}

		private static void CheckThrowOnSetRenderTarget()
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetRenderTarget(RenderTargetBinding binding)
		{
		}

		private void ClearRenderTargetSingle_Internal(RTClearFlags clearFlags, Color color, float depth, uint stencil)
		{
		}

		private void ClearRenderTargetMulti_Internal(RTClearFlags clearFlags, Color[] colors, float depth, uint stencil)
		{
		}

		private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		private void SetRenderTargetColorDepthSubtarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
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

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferNativeData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetComputeBufferNativeData([NotNull] ComputeBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetComputeBufferData([NotNull] ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferCounterValue", HasExplicitThis = true)]
		private void InternalSetComputeBufferCounterValue([NotNull] ComputeBuffer buffer, uint counterValue)
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

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferNativeData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetGraphicsBufferNativeData([NotNull] GraphicsBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetGraphicsBufferData([NotNull] GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferCounterValue", HasExplicitThis = true)]
		private void InternalSetGraphicsBufferCounterValue([NotNull] GraphicsBuffer buffer, uint counterValue)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::BeginRenderPass", HasExplicitThis = true)]
		private void BeginRenderPass_Internal(int width, int height, int volumeDepth, int samples, ReadOnlySpan<AttachmentDescriptor> attachments, int depthAttachmentIndex, int shadingRateImageAttachmentIndex, ReadOnlySpan<SubPassDescriptor> subPasses, ReadOnlySpan<byte> debugNameUtf8)
		{
		}

		public void BeginRenderPass(int width, int height, int volumeDepth, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex, int shadingRateImageAttachmentIndex, NativeArray<SubPassDescriptor> subPasses, ReadOnlySpan<byte> debugNameUtf8)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::NextSubPass", HasExplicitThis = true)]
		private void NextSubPass_Internal()
		{
		}

		public void NextSubPass()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EndRenderPass", HasExplicitThis = true)]
		private void EndRenderPass_Internal()
		{
		}

		public void EndRenderPass()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetupCameraProperties", HasExplicitThis = true)]
		private void SetupCameraProperties_Internal([NotNull] Camera camera)
		{
		}

		public void SetupCameraProperties(Camera camera)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::InvokeOnRenderObjectCallbacks", HasExplicitThis = true)]
		private void InvokeOnRenderObjectCallbacks_Internal()
		{
		}

		public void InvokeOnRenderObjectCallbacks()
		{
		}

		public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize)
		{
		}

		public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner)
		{
		}

		public void SetShadingRateImage(in RenderTargetIdentifier shadingRateImage)
		{
		}

		public void ResetShadingRate()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetShadingRateFragmentSize_Impl", HasExplicitThis = true)]
		private void SetShadingRateFragmentSize_Impl(ShadingRateFragmentSize shadingRateFragmentSize)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetShadingRateCombiner_Impl", HasExplicitThis = true)]
		private void SetShadingRateCombiner_Impl(ShadingRateCombinerStage stage, ShadingRateCombiner combiner)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetShadingRateImage_Impl", HasExplicitThis = true)]
		private void SetShadingRateImage_Impl(in RenderTargetIdentifier shadingRateImage)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ResetShadingRate_Impl", HasExplicitThis = true)]
		private void ResetShadingRate_Impl()
		{
		}

		~CommandBuffer()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		public void Release()
		{
		}

		public GraphicsFence CreateAsyncGraphicsFence()
		{
			return default(GraphicsFence);
		}

		public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return default(GraphicsFence);
		}

		public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage)
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

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
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

		public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt)
		{
		}

		public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt)
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

		public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera = null)
		{
		}

		public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, GraphicsBuffer argsBuffer, uint argsOffset, Camera camera = null)
		{
		}

		public void GenerateMips(RenderTargetIdentifier rt)
		{
		}

		public void GenerateMips(RenderTexture rt)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
		}

		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
		}

		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
		}

		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
		}

		[ExcludeFromDocs]
		public void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, int[] subsetIndices, int count, Material material, int shaderPass, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass)
		{
		}

		[ExcludeFromDocs]
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
		}

		[ExcludeFromDocs]
		public void DrawRenderer(Renderer renderer, Material material)
		{
		}

		public void DrawRendererList(RendererList rendererList)
		{
		}

		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
		}

		[ExcludeFromDocs]
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
		}

		[ExcludeFromDocs]
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
		{
		}

		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount)
		{
		}

		public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount)
		{
		}

		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
		}

		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
		}

		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
		}

		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
		}

		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
		}

		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs)
		{
		}

		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
		}

		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs)
		{
		}

		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
		{
		}

		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count)
		{
		}

		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices)
		{
		}

		public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties = null)
		{
		}

		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset)
		{
		}

		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs)
		{
		}

		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
		}

		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
		}

		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs)
		{
		}

		public void DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
		}

		public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt)
		{
		}

		public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue)
		{
		}

		public void SetRandomWriteTarget(int index, ComputeBuffer buffer)
		{
		}

		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue)
		{
		}

		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer)
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

		public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
		}

		public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
		}

		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip)
		{
		}

		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
		{
		}

		public void Blit(Texture source, RenderTargetIdentifier dest)
		{
		}

		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
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

		public void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
		}

		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
		}

		public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
		}

		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
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

		private unsafe static void Internal_RequestAsyncReadback_1_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_2_Injected(IntPtr _unity_self, IntPtr src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_3_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_4_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_5_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_6_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_7_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_8_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private unsafe static void Internal_RequestAsyncReadback_9_Injected(IntPtr _unity_self, IntPtr src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData)
		{
		}

		private static void SetInvertCulling_Injected(IntPtr _unity_self, bool invertCulling)
		{
		}

		private static void Internal_SetSinglePassStereo_Injected(IntPtr _unity_self, SinglePassStereoMode mode)
		{
		}

		private static IntPtr CreateGPUFence_Internal_Injected(IntPtr _unity_self, GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return (IntPtr)0;
		}

		private static void WaitOnGPUFence_Internal_Injected(IntPtr _unity_self, IntPtr fencePtr, SynchronisationStageFlags stage)
		{
		}

		private static void ReleaseBuffer_Injected(IntPtr _unity_self)
		{
		}

		private static void SetComputeFloatParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, float val)
		{
		}

		private static void SetComputeIntParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, int val)
		{
		}

		private static void SetComputeVectorParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, [In] ref Vector4 val)
		{
		}

		private static void SetComputeVectorArrayParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void SetComputeMatrixParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, [In] ref Matrix4x4 val)
		{
		}

		private static void SetComputeMatrixArrayParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetComputeFloats_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetComputeInts_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetComputeTextureParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
		}

		private static void Internal_SetComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer)
		{
		}

		private static void Internal_SetComputeGraphicsBufferHandleParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, [In] ref GraphicsBufferHandle bufferHandle)
		{
		}

		private static void Internal_SetComputeGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer)
		{
		}

		private static void Internal_SetComputeConstantComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size)
		{
		}

		private static void Internal_SetComputeConstantGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size)
		{
		}

		private static void Internal_SetComputeParamsFromMaterial_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr material)
		{
		}

		private static void Internal_DispatchCompute_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		private static void Internal_DispatchComputeIndirect_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset)
		{
		}

		private static void Internal_DispatchComputeIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset)
		{
		}

		private static void Internal_SetRayTracingComputeBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer)
		{
		}

		private static void Internal_SetRayTracingGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer)
		{
		}

		private static void Internal_SetRayTracingGraphicsBufferHandleParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, [In] ref GraphicsBufferHandle bufferHandle)
		{
		}

		private static void Internal_SetRayTracingConstantComputeBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size)
		{
		}

		private static void Internal_SetRayTracingConstantGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size)
		{
		}

		private static void Internal_SetRayTracingTextureParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref RenderTargetIdentifier rt)
		{
		}

		private static void Internal_SetRayTracingFloatParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, float val)
		{
		}

		private static void Internal_SetRayTracingIntParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, int val)
		{
		}

		private static void Internal_SetRayTracingVectorParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, [In] ref Vector4 val)
		{
		}

		private static void Internal_SetRayTracingVectorArrayParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetRayTracingMatrixParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, [In] ref Matrix4x4 val)
		{
		}

		private static void Internal_SetRayTracingMatrixArrayParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetRayTracingFloats_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetRayTracingInts_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_BuildRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr accelerationStructure, [In] ref RayTracingAccelerationStructure.BuildSettings buildSettings)
		{
		}

		private static void Internal_SetRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr accelerationStructure)
		{
		}

		private static void Internal_SetComputeRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr accelerationStructure)
		{
		}

		private static void SetRayTracingShaderPass_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper passName)
		{
		}

		private static void Internal_DispatchRays_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper rayGenShaderName, uint width, uint height, uint depth, IntPtr camera)
		{
		}

		private static void Internal_DispatchRaysIndirect_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper rayGenShaderName, IntPtr argsBuffer, uint argsOffset, IntPtr camera)
		{
		}

		private static void Internal_GenerateMips_Injected(IntPtr _unity_self, [In] ref RenderTargetIdentifier rt)
		{
		}

		private static void CopyCounterValueCC_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes)
		{
		}

		private static void CopyCounterValueGC_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes)
		{
		}

		private static void CopyCounterValueCG_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes)
		{
		}

		private static void CopyCounterValueGG_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes)
		{
		}

		private static void get_name_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_name_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static int get_sizeInBytes_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void Clear_Injected(IntPtr _unity_self)
		{
		}

		private static void Internal_DrawMesh_Injected(IntPtr _unity_self, IntPtr mesh, [In] ref Matrix4x4 matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties)
		{
		}

		private static void Internal_DrawMultipleMeshes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper matrices, Mesh[] meshes, ref ManagedSpanWrapper subsetIndices, int count, IntPtr material, int shaderPass, IntPtr properties)
		{
		}

		private static void Internal_DrawRenderer_Injected(IntPtr _unity_self, IntPtr renderer, IntPtr material, int submeshIndex, int shaderPass)
		{
		}

		private static void Internal_DrawRendererList_Injected(IntPtr _unity_self, [In] ref RendererList rendererList)
		{
		}

		private static void Internal_DrawProcedural_Injected(IntPtr _unity_self, [In] ref Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, IntPtr properties)
		{
		}

		private static void Internal_DrawProceduralIndexed_Injected(IntPtr _unity_self, IntPtr indexBuffer, [In] ref Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, IntPtr properties)
		{
		}

		private static void Internal_DrawProceduralIndirect_Injected(IntPtr _unity_self, [In] ref Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties)
		{
		}

		private static void Internal_DrawProceduralIndexedIndirect_Injected(IntPtr _unity_self, IntPtr indexBuffer, [In] ref Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties)
		{
		}

		private static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(IntPtr _unity_self, [In] ref Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties)
		{
		}

		private static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr indexBuffer, [In] ref Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties)
		{
		}

		private static void Internal_DrawMeshInstanced_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, ref ManagedSpanWrapper matrices, int count, IntPtr properties)
		{
		}

		private static void Internal_DrawMeshInstancedProcedural_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, int count, IntPtr properties)
		{
		}

		private static void Internal_DrawMeshInstancedIndirect_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties)
		{
		}

		private static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties)
		{
		}

		private static void Internal_DrawOcclusionMesh_Injected(IntPtr _unity_self, [In] ref RectInt normalizedCamViewport)
		{
		}

		private static void SetRandomWriteTarget_Texture_Injected(IntPtr _unity_self, int index, ref RenderTargetIdentifier rt)
		{
		}

		private static void SetRandomWriteTarget_Buffer_Injected(IntPtr _unity_self, int index, IntPtr uav, bool preserveCounterValue)
		{
		}

		private static void SetRandomWriteTarget_GraphicsBuffer_Injected(IntPtr _unity_self, int index, IntPtr uav, bool preserveCounterValue)
		{
		}

		private static void ClearRandomWriteTargets_Injected(IntPtr _unity_self)
		{
		}

		private static void SetViewport_Injected(IntPtr _unity_self, [In] ref Rect pixelRect)
		{
		}

		private static void EnableScissorRect_Injected(IntPtr _unity_self, [In] ref Rect scissor)
		{
		}

		private static void DisableScissorRect_Injected(IntPtr _unity_self)
		{
		}

		private static void CopyTexture_Internal_Injected(IntPtr _unity_self, ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode)
		{
		}

		private static void Blit_Texture_Injected(IntPtr _unity_self, IntPtr source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, [In] ref Vector2 scale, [In] ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		private static void Blit_Identifier_Injected(IntPtr _unity_self, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, [In] ref Vector2 scale, [In] ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		private static void GetTemporaryRTWithDescriptor_Injected(IntPtr _unity_self, int nameID, [In] ref RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		private static void ReleaseTemporaryRT_Injected(IntPtr _unity_self, int nameID)
		{
		}

		private static void SetGlobalFloat_Injected(IntPtr _unity_self, int nameID, float value)
		{
		}

		private static void SetGlobalInt_Injected(IntPtr _unity_self, int nameID, int value)
		{
		}

		private static void SetGlobalInteger_Injected(IntPtr _unity_self, int nameID, int value)
		{
		}

		private static void SetGlobalVector_Injected(IntPtr _unity_self, int nameID, [In] ref Vector4 value)
		{
		}

		private static void SetGlobalColor_Injected(IntPtr _unity_self, int nameID, [In] ref Color value)
		{
		}

		private static void SetGlobalMatrix_Injected(IntPtr _unity_self, int nameID, [In] ref Matrix4x4 value)
		{
		}

		private static void EnableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
		}

		private static void EnableGlobalKeyword_Injected(IntPtr _unity_self, [In] ref GlobalKeyword keyword)
		{
		}

		private static void EnableMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, [In] ref LocalKeyword keyword)
		{
		}

		private static void EnableComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, [In] ref LocalKeyword keyword)
		{
		}

		private static void DisableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
		}

		private static void DisableGlobalKeyword_Injected(IntPtr _unity_self, [In] ref GlobalKeyword keyword)
		{
		}

		private static void DisableMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, [In] ref LocalKeyword keyword)
		{
		}

		private static void DisableComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, [In] ref LocalKeyword keyword)
		{
		}

		private static void SetGlobalKeyword_Injected(IntPtr _unity_self, [In] ref GlobalKeyword keyword, bool value)
		{
		}

		private static void SetMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, [In] ref LocalKeyword keyword, bool value)
		{
		}

		private static void SetComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, [In] ref LocalKeyword keyword, bool value)
		{
		}

		private static void SetViewProjectionMatrices_Injected(IntPtr _unity_self, [In] ref Matrix4x4 view, [In] ref Matrix4x4 proj)
		{
		}

		private static void SetGlobalDepthBias_Injected(IntPtr _unity_self, float bias, float slopeBias)
		{
		}

		private static void SetExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags flags)
		{
		}

		private static bool ValidateAgainstExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags)
		{
			return false;
		}

		private static void SetGlobalFloatArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values)
		{
		}

		private static void SetGlobalVectorArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values)
		{
		}

		private static void SetGlobalMatrixArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values)
		{
		}

		private static void SetGlobalFloatArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void SetGlobalVectorArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void SetGlobalMatrixArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void SetLateLatchProjectionMatrices_Injected(IntPtr _unity_self, ref ManagedSpanWrapper projectionMat)
		{
		}

		private static void MarkLateLatchMatrixShaderPropertyID_Injected(IntPtr _unity_self, CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
		{
		}

		private static void UnmarkLateLatchMatrix_Injected(IntPtr _unity_self, CameraLateLatchMatrixType matrixPropertyType)
		{
		}

		private static void SetGlobalTexture_Impl_Injected(IntPtr _unity_self, int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element)
		{
		}

		private static void SetGlobalBufferInternal_Injected(IntPtr _unity_self, int nameID, IntPtr value)
		{
		}

		private static void SetGlobalGraphicsBufferInternal_Injected(IntPtr _unity_self, int nameID, IntPtr value)
		{
		}

		private static void SetShadowSamplingMode_Impl_Injected(IntPtr _unity_self, ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
		}

		private static void IssuePluginEventInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID)
		{
		}

		private static void BeginSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
		}

		private static void EndSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
		}

		private static void BeginSample_CustomSampler_Injected(IntPtr _unity_self, IntPtr sampler)
		{
		}

		private static void EndSample_CustomSampler_Injected(IntPtr _unity_self, IntPtr sampler)
		{
		}

		private static void IssuePluginEventAndDataInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID, IntPtr data)
		{
		}

		private static void IssuePluginCustomBlitInternal_Injected(IntPtr _unity_self, IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags)
		{
		}

		private static void IssuePluginCustomTextureUpdateInternal_Injected(IntPtr _unity_self, IntPtr callback, IntPtr targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2)
		{
		}

		private static void SetGlobalConstantBufferInternal_Injected(IntPtr _unity_self, IntPtr buffer, int nameID, int offset, int size)
		{
		}

		private static void SetGlobalConstantGraphicsBufferInternal_Injected(IntPtr _unity_self, IntPtr buffer, int nameID, int offset, int size)
		{
		}

		private static void IncrementUpdateCount_Injected(IntPtr _unity_self, [In] ref RenderTargetIdentifier dest)
		{
		}

		private static void SetInstanceMultiplier_Injected(IntPtr _unity_self, uint multiplier)
		{
		}

		private static void SetFoveatedRenderingMode_Injected(IntPtr _unity_self, FoveatedRenderingMode foveatedRenderingMode)
		{
		}

		private static void SetWireframe_Injected(IntPtr _unity_self, bool enable)
		{
		}

		private static void ConfigureFoveatedRendering_Injected(IntPtr _unity_self, IntPtr platformData)
		{
		}

		private static void ClearRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, [In] ref Color color, float depth, uint stencil)
		{
		}

		private static void ClearRenderTargetMulti_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, ref ManagedSpanWrapper colors, float depth, uint stencil)
		{
		}

		private static void SetRenderTargetSingle_Internal_Injected(IntPtr _unity_self, [In] ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		private static void SetRenderTargetColorDepth_Internal_Injected(IntPtr _unity_self, [In] ref RenderTargetIdentifier color, [In] ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		private static void SetRenderTargetMulti_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, [In] ref RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		private static void SetRenderTargetColorDepthSubtarget_Injected(IntPtr _unity_self, [In] ref RenderTargetIdentifier color, [In] ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		private static void SetRenderTargetMultiSubtarget_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, [In] ref RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		private static void InternalSetComputeBufferNativeData_Injected(IntPtr _unity_self, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalSetComputeBufferData_Injected(IntPtr _unity_self, IntPtr buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalSetComputeBufferCounterValue_Injected(IntPtr _unity_self, IntPtr buffer, uint counterValue)
		{
		}

		private static void InternalSetGraphicsBufferNativeData_Injected(IntPtr _unity_self, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalSetGraphicsBufferData_Injected(IntPtr _unity_self, IntPtr buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalSetGraphicsBufferCounterValue_Injected(IntPtr _unity_self, IntPtr buffer, uint counterValue)
		{
		}

		private static void BeginRenderPass_Internal_Injected(IntPtr _unity_self, int width, int height, int volumeDepth, int samples, ref ManagedSpanWrapper attachments, int depthAttachmentIndex, int shadingRateImageAttachmentIndex, ref ManagedSpanWrapper subPasses, ref ManagedSpanWrapper debugNameUtf8)
		{
		}

		private static void NextSubPass_Internal_Injected(IntPtr _unity_self)
		{
		}

		private static void EndRenderPass_Internal_Injected(IntPtr _unity_self)
		{
		}

		private static void SetupCameraProperties_Internal_Injected(IntPtr _unity_self, IntPtr camera)
		{
		}

		private static void InvokeOnRenderObjectCallbacks_Internal_Injected(IntPtr _unity_self)
		{
		}

		private static void SetShadingRateFragmentSize_Impl_Injected(IntPtr _unity_self, ShadingRateFragmentSize shadingRateFragmentSize)
		{
		}

		private static void SetShadingRateCombiner_Impl_Injected(IntPtr _unity_self, ShadingRateCombinerStage stage, ShadingRateCombiner combiner)
		{
		}

		private static void SetShadingRateImage_Impl_Injected(IntPtr _unity_self, in RenderTargetIdentifier shadingRateImage)
		{
		}

		private static void ResetShadingRate_Impl_Injected(IntPtr _unity_self)
		{
		}
	}
}
