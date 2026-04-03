using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	public struct CameraData
	{
		private ContextContainer frameData;

		internal UniversalCameraData universalCameraData => null;

		public ref Camera camera
		{
			get
			{
				throw null;
			}
		}

		public ref UniversalCameraHistory historyManager
		{
			get
			{
				throw null;
			}
		}

		public ref CameraRenderType renderType
		{
			get
			{
				throw null;
			}
		}

		public ref RenderTexture targetTexture
		{
			get
			{
				throw null;
			}
		}

		public ref RenderTextureDescriptor cameraTargetDescriptor
		{
			get
			{
				throw null;
			}
		}

		internal ref Rect pixelRect
		{
			get
			{
				throw null;
			}
		}

		internal ref bool useScreenCoordOverride
		{
			get
			{
				throw null;
			}
		}

		internal ref Vector4 screenSizeOverride
		{
			get
			{
				throw null;
			}
		}

		internal ref Vector4 screenCoordScaleBias
		{
			get
			{
				throw null;
			}
		}

		internal ref int pixelWidth
		{
			get
			{
				throw null;
			}
		}

		internal ref int pixelHeight
		{
			get
			{
				throw null;
			}
		}

		internal ref float aspectRatio
		{
			get
			{
				throw null;
			}
		}

		public ref float renderScale
		{
			get
			{
				throw null;
			}
		}

		internal ref ImageScalingMode imageScalingMode
		{
			get
			{
				throw null;
			}
		}

		internal ref ImageUpscalingFilter upscalingFilter
		{
			get
			{
				throw null;
			}
		}

		internal ref bool fsrOverrideSharpness
		{
			get
			{
				throw null;
			}
		}

		internal ref float fsrSharpness
		{
			get
			{
				throw null;
			}
		}

		internal ref HDRColorBufferPrecision hdrColorBufferPrecision
		{
			get
			{
				throw null;
			}
		}

		public ref bool clearDepth
		{
			get
			{
				throw null;
			}
		}

		public ref CameraType cameraType
		{
			get
			{
				throw null;
			}
		}

		public ref bool isDefaultViewport
		{
			get
			{
				throw null;
			}
		}

		public ref bool isHdrEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref bool allowHDROutput
		{
			get
			{
				throw null;
			}
		}

		public ref bool isAlphaOutputEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref bool requiresDepthTexture
		{
			get
			{
				throw null;
			}
		}

		public ref bool requiresOpaqueTexture
		{
			get
			{
				throw null;
			}
		}

		public ref bool postProcessingRequiresDepthTexture
		{
			get
			{
				throw null;
			}
		}

		public ref bool xrRendering
		{
			get
			{
				throw null;
			}
		}

		internal bool requireSrgbConversion => false;

		public bool isSceneViewCamera => false;

		public bool isPreviewCamera => false;

		internal bool isRenderPassSupportedCamera => false;

		internal bool resolveToScreen => false;

		public bool isHDROutputActive => false;

		public HDROutputUtils.HDRDisplayInformation hdrDisplayInformation => default(HDROutputUtils.HDRDisplayInformation);

		public ColorGamut hdrDisplayColorGamut => default(ColorGamut);

		public bool rendersOverlayUI => false;

		public ref SortingCriteria defaultOpaqueSortFlags
		{
			get
			{
				throw null;
			}
		}

		public XRPass xr
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal XRPassUniversal xrUniversal => null;

		public ref float maxShadowDistance
		{
			get
			{
				throw null;
			}
		}

		public ref bool postProcessEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions
		{
			get
			{
				throw null;
			}
		}

		public ref LayerMask volumeLayerMask
		{
			get
			{
				throw null;
			}
		}

		public ref Transform volumeTrigger
		{
			get
			{
				throw null;
			}
		}

		public ref bool isStopNaNEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref bool isDitheringEnabled
		{
			get
			{
				throw null;
			}
		}

		public ref AntialiasingMode antialiasing
		{
			get
			{
				throw null;
			}
		}

		public ref AntialiasingQuality antialiasingQuality
		{
			get
			{
				throw null;
			}
		}

		public ref ScriptableRenderer renderer
		{
			get
			{
				throw null;
			}
		}

		public ref bool resolveFinalTarget
		{
			get
			{
				throw null;
			}
		}

		public ref Vector3 worldSpaceCameraPos
		{
			get
			{
				throw null;
			}
		}

		public ref Color backgroundColor
		{
			get
			{
				throw null;
			}
		}

		internal ref TaaHistory taaHistory
		{
			get
			{
				throw null;
			}
		}

		internal ref TemporalAA.Settings taaSettings
		{
			get
			{
				throw null;
			}
		}

		internal bool resetHistory => false;

		public ref Camera baseCamera
		{
			get
			{
				throw null;
			}
		}

		internal CameraData(ContextContainer frameData)
		{
			this.frameData = null;
		}

		internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
		{
		}

		internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix)
		{
		}

		internal void PushBuiltinShaderConstantsXR(RasterCommandBuffer cmd, bool renderIntoTexture)
		{
		}

		public Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public bool IsHandleYFlipped(RTHandle handle)
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public bool IsCameraProjectionMatrixFlipped()
		{
			return false;
		}

		public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null)
		{
			return false;
		}

		internal bool IsTemporalAAEnabled()
		{
			return false;
		}
	}
}
