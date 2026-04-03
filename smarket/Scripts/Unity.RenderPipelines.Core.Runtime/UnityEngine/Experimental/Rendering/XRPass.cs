using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	public class XRPass
	{
		private readonly List<XRView> m_Views;

		private readonly XROcclusionMesh m_OcclusionMesh;

		private readonly XRVisibleMesh m_VisibleMesh;

		public bool enabled => false;

		public bool supportsFoveatedRendering => false;

		public bool copyDepth { get; private set; }

		public bool hasMotionVectorPass { get; private set; }

		public bool spaceWarpRightHandedNDC { get; private set; }

		public bool isFirstCameraPass => false;

		public bool isLastCameraPass { get; private set; }

		public int multipassId { get; private set; }

		public int cullingPassId { get; private set; }

		public int renderTargetScaledWidth { get; private set; }

		public int renderTargetScaledHeight { get; private set; }

		public RenderTargetIdentifier renderTarget { get; private set; }

		public RenderTextureDescriptor renderTargetDesc { get; private set; }

		public RenderTargetIdentifier motionVectorRenderTarget { get; private set; }

		public RenderTextureDescriptor motionVectorRenderTargetDesc { get; private set; }

		public ScriptableCullingParameters cullingParams { get; private set; }

		public int viewCount => 0;

		public bool singlePassEnabled => false;

		public IntPtr foveatedRenderingInfo { get; private set; }

		public bool isHDRDisplayOutputActive => false;

		public ColorGamut hdrDisplayOutputColorGamut => default(ColorGamut);

		public HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation => default(HDROutputUtils.HDRDisplayInformation);

		public float occlusionMeshScale { get; private set; }

		public bool hasValidOcclusionMesh => false;

		public bool hasValidVisibleMesh => false;

		public static XRPass CreateDefault(XRPassCreateInfo createInfo)
		{
			return null;
		}

		public virtual void Release()
		{
		}

		public Matrix4x4 GetProjMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public bool GetPrevViewValid(int viewIndex = 0)
		{
			return false;
		}

		public Matrix4x4 GetPrevViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Rect GetViewport(int viewIndex = 0)
		{
			return default(Rect);
		}

		public Mesh GetOcclusionMesh(int viewIndex = 0)
		{
			return null;
		}

		public Mesh GetVisibleMesh(int viewIndex = 0)
		{
			return null;
		}

		public int GetTextureArraySlice(int viewIndex = 0)
		{
			return 0;
		}

		public void StartSinglePass(CommandBuffer cmd)
		{
		}

		public void StartSinglePass(IRasterCommandBuffer cmd)
		{
		}

		public void StopSinglePass(CommandBuffer cmd)
		{
		}

		public void StopSinglePass(BaseCommandBuffer cmd)
		{
		}

		public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false)
		{
		}

		public void RenderOcclusionMesh(RasterCommandBuffer cmd, bool renderIntoTexture = false)
		{
		}

		public void RenderVisibleMeshCustomMaterial(RasterCommandBuffer cmd, float occlusionMeshScale, Material material, MaterialPropertyBlock materialBlock, int shaderPass, bool renderIntoTexture = false)
		{
		}

		public void RenderVisibleMeshCustomMaterial(CommandBuffer cmd, float occlusionMeshScale, Material material, MaterialPropertyBlock materialBlock, int shaderPass = 0, bool renderIntoTexture = false)
		{
		}

		public void RenderDebugXRViewsFrustum()
		{
		}

		public Vector4 ApplyXRViewCenterOffset(Vector2 center)
		{
			return default(Vector4);
		}

		internal void AssignView(int viewId, XRView xrView)
		{
		}

		internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
		{
		}

		internal void UpdateCombinedOcclusionMesh()
		{
		}

		public void InitBase(XRPassCreateInfo createInfo)
		{
		}

		internal void AddView(XRView xrView)
		{
		}
	}
}
