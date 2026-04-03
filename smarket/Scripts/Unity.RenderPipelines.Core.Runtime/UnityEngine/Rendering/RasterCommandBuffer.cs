using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.Profiling;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public class RasterCommandBuffer : BaseCommandBuffer, IRasterCommandBuffer, IBaseCommandBuffer
	{
		internal RasterCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync)
			: base(null, null, isAsync: false)
		{
		}

		public void SetInvertCulling(bool invertCulling)
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

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth, uint stencil)
		{
		}

		public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil)
		{
		}

		public void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth, uint stencil)
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

		public void SetInstanceMultiplier(uint multiplier)
		{
		}

		public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode)
		{
		}

		public void SetWireframe(bool enable)
		{
		}

		public void ConfigureFoveatedRendering(IntPtr platformData)
		{
		}

		public void SetupCameraProperties(Camera camera)
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

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
		}

		public void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, int[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material)
		{
		}

		public void DrawRendererList(RendererList rendererList)
		{
		}

		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
		}

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

		public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties)
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
