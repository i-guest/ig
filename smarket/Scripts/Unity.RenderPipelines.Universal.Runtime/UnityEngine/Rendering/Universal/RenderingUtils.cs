using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public static class RenderingUtils
	{
		private static List<ShaderTagId> m_LegacyShaderPassNames;

		private static AttachmentDescriptor s_EmptyAttachment;

		private static Mesh s_FullscreenMesh;

		private static Material s_ErrorMaterial;

		private static ShaderTagId[] s_ShaderTagValues;

		private static RenderStateBlock[] s_RenderStateBlocks;

		private static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport;

		internal static AttachmentDescriptor emptyAttachment => default(AttachmentDescriptor);

		[Obsolete("Use Blitter.BlitCameraTexture instead of CommandBuffer.DrawMesh(fullscreenMesh, ...). #from(2022.2)")]
		public static Mesh fullscreenMesh => null;

		internal static bool useStructuredBuffer => false;

		private static Material errorMaterial => null;

		internal static bool SupportsLightLayers(GraphicsDeviceType type)
		{
			return false;
		}

		public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
		{
		}

		public static void SetViewAndProjectionMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
		{
		}

		internal static void SetScaleBiasRt(RasterCommandBuffer cmd, in UniversalCameraData cameraData, RTHandle rTHandle)
		{
		}

		internal static void SetupOffscreenUIViewportParams(Material material, ref Rect pixelRect, bool isRenderToBackBufferTarget)
		{
		}

		internal static void SetScaleBiasRt(RasterCommandBuffer cmd, in RenderingData renderingData)
		{
		}

		internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
		{
		}

		internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
		{
		}

		internal static void FinalBlit(CommandBuffer cmd, UniversalCameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal static void CreateRendererParamsObjectsWithError(ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererListParams param)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal static void CreateRendererListObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererList rl)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal static void CreateRendererListObjectsWithError(RenderGraph renderGraph, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererListHandle rl)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		internal static void DrawRendererListObjectsWithError(RasterCommandBuffer cmd, ref RendererList rl)
		{
		}

		internal static void CreateRendererListWithRenderStateBlock(ScriptableRenderContext context, ref CullingResults cullResults, DrawingSettings ds, FilteringSettings fs, RenderStateBlock rsb, ref RendererList rl)
		{
		}

		internal static void CreateRendererListWithRenderStateBlock(RenderGraph renderGraph, ref CullingResults cullResults, DrawingSettings ds, FilteringSettings fs, RenderStateBlock rsb, ref RendererListHandle rl)
		{
		}

		internal static void ClearSystemInfoCache()
		{
		}

		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return false;
		}

		[Obsolete("Use SystemInfo.IsFormatSupported instead. #from(2023.2)")]
		public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage)
		{
			return false;
		}

		internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers)
		{
			return 0;
		}

		internal static uint GetValidColorBufferCount(RTHandle[] colorBuffers)
		{
			return 0u;
		}

		internal static bool IsMRT(RTHandle[] colorBuffers)
		{
			return false;
		}

		internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return false;
		}

		internal static int IndexOf(RTHandle[] source, RenderTargetIdentifier value)
		{
			return 0;
		}

		internal static int IndexOf(RTHandle[] source, RTHandle value)
		{
			return 0;
		}

		internal static uint CountDistinct(RTHandle[] source, RTHandle value)
		{
			return 0u;
		}

		internal static int LastValid(RTHandle[] source)
		{
			return 0;
		}

		internal static bool Contains(ClearFlag a, ClearFlag b)
		{
			return false;
		}

		internal static bool SequenceEqual(RTHandle[] left, RTHandle[] right)
		{
			return false;
		}

		internal static bool MultisampleDepthResolveSupported()
		{
			return false;
		}

		internal static bool RTHandleNeedsReAlloc(RTHandle handle, in TextureDesc descriptor, bool scaled)
		{
			return false;
		}

		internal static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData)
		{
			return default(RenderTargetIdentifier);
		}

		[Obsolete("This method will be removed in a future release. Please use ReAllocateHandleIfNeeded instead. #from(2023.3)")]
		public static bool ReAllocateIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		[Obsolete("This method will be removed in a future release. Please use ReAllocateHandleIfNeeded instead. #from(2023.3)")]
		public static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		[Obsolete("This method will be removed in a future release. Please use ReAllocateHandleIfNeeded instead. #from(2023.3)")]
		public static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, TextureDesc descriptor, string name)
		{
			return false;
		}

		public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			return false;
		}

		public static bool SetMaxRTHandlePoolCapacity(int capacity)
		{
			return false;
		}

		internal static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle)
		{
		}

		public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		internal static bool IsHandleYFlipped(in RasterGraphContext renderGraphContext, in TextureHandle textureHandle)
		{
			return false;
		}

		internal static Vector4 GetFinalBlitScaleBias(RTHandle source, RTHandle destination, UniversalCameraData cameraData)
		{
			return default(Vector4);
		}

		internal static Vector4 GetFinalBlitScaleBias(in RasterGraphContext renderGraphContext, in TextureHandle source, in TextureHandle destination)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static RTHandleAllocInfo CreateRTHandleAllocInfo(in RenderTextureDescriptor descriptor, FilterMode filterMode, TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name)
		{
			return default(RTHandleAllocInfo);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static RTHandleAllocInfo CreateRTHandleAllocInfo(in TextureDesc descriptor, string name)
		{
			return default(RTHandleAllocInfo);
		}
	}
}
