using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public class XRDepthMotionPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal RendererListHandle objMotionRendererList;

			internal Matrix4x4[] previousViewProjectionStereo;

			internal Matrix4x4[] viewProjectionStereo;

			internal Material xrMotionVector;
		}

		public const string k_MotionOnlyShaderTagIdName = "XRMotionVectors";

		private static readonly ShaderTagId k_MotionOnlyShaderTagId;

		private static readonly int k_SpaceWarpNDCModifier;

		private RTHandle m_XRMotionVectorColor;

		private TextureHandle xrMotionVectorColor;

		private RTHandle m_XRMotionVectorDepth;

		private TextureHandle xrMotionVectorDepth;

		private bool m_XRSpaceWarpRightHandedNDC;

		private const int k_XRViewCountPerPass = 2;

		private Matrix4x4[] m_StagingMatrixArray;

		private Matrix4x4[] m_PreviousStagingMatrixArray;

		private const int k_XRViewCount = 4;

		private Matrix4x4[] m_ViewProjection;

		private Matrix4x4[] m_PreviousViewProjection;

		private int m_LastFrameIndex;

		private Material m_XRMotionVectorMaterial;

		public XRDepthMotionPass(RenderPassEvent evt, Shader xrMotionVector)
		{
		}

		private static DrawingSettings GetObjectMotionDrawingSettings(Camera camera)
		{
			return default(DrawingSettings);
		}

		private void InitObjectMotionRendererLists(ref PassData passData, ref CullingResults cullResults, RenderGraph renderGraph, Camera camera)
		{
		}

		private void InitPassData(ref PassData passData, UniversalCameraData cameraData)
		{
		}

		private void ImportXRMotionColorAndDepth(RenderGraph renderGraph, UniversalCameraData cameraData)
		{
		}

		internal void Render(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		private void ResetMotionData()
		{
		}

		public void Update(ref UniversalCameraData cameraData)
		{
		}

		public void Dispose()
		{
		}
	}
}
