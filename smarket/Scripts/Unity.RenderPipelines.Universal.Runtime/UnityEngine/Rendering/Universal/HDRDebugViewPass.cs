using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class HDRDebugViewPass : ScriptableRenderPass
	{
		private enum HDRDebugPassId
		{
			CIExyPrepass = 0,
			DebugViewPass = 1
		}

		private class PassDataCIExy
		{
			internal Material material;

			internal Vector4 luminanceParameters;

			internal TextureHandle srcColor;

			internal TextureHandle xyBuffer;

			internal TextureHandle passThrough;
		}

		private class PassDataDebugView
		{
			internal Material material;

			internal HDRDebugMode hdrDebugMode;

			internal UniversalCameraData cameraData;

			internal Vector4 luminanceParameters;

			internal TextureHandle xyBuffer;

			internal TextureHandle srcColor;

			internal TextureHandle dstColor;
		}

		internal class ShaderConstants
		{
			public static readonly int _DebugHDRModeId;

			public static readonly int _HDRDebugParamsId;

			public static readonly int _xyTextureId;

			public static readonly int _SizeOfHDRXYMapping;

			public static readonly int _CIExyUAVIndex;
		}

		private RTHandle m_PassthroughRT;

		private Material m_material;

		private PassDataCIExy m_PassDataCIExy;

		private RTHandle m_CIExyTarget;

		private PassDataDebugView m_PassDataDebugView;

		public HDRDebugViewPass(Material mat)
		{
		}

		public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor)
		{
		}

		internal static Vector4 GetLuminanceParameters(UniversalCameraData cameraData)
		{
			return default(Vector4);
		}

		private static void ExecuteCIExyPrepass(CommandBuffer cmd, PassDataCIExy data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture)
		{
		}

		private static void ExecuteHDRDebugViewFinalPass(RasterCommandBuffer cmd, in PassDataDebugView data, RTHandle source, Vector4 scaleBias, RTHandle destination, RTHandle xyTarget)
		{
		}

		public void Dispose()
		{
		}

		public void Setup(UniversalCameraData cameraData, HDRDebugMode hdrdebugMode)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void ExecutePass(CommandBuffer cmd, PassDataCIExy dataCIExy, PassDataDebugView dataDebugView, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture)
		{
		}

		internal void RenderHDRDebug(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayUITexture, TextureHandle dstColor, HDRDebugMode hdrDebugMode)
		{
		}
	}
}
