using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal
{
	public static class TemporalAA
	{
		internal static class ShaderConstants
		{
			public static readonly int _TaaAccumulationTex;

			public static readonly int _TaaMotionVectorTex;

			public static readonly int _TaaFilterWeights;

			public static readonly int _TaaFrameInfluence;

			public static readonly int _TaaVarianceClampScale;

			public static readonly int _CameraDepthTexture;
		}

		internal static class ShaderKeywords
		{
			public static readonly string TAA_LOW_PRECISION_SOURCE;
		}

		[Serializable]
		public struct Settings
		{
			[SerializeField]
			[FormerlySerializedAs("quality")]
			internal TemporalAAQuality m_Quality;

			[SerializeField]
			[FormerlySerializedAs("frameInfluence")]
			internal float m_FrameInfluence;

			[SerializeField]
			[FormerlySerializedAs("jitterScale")]
			internal float m_JitterScale;

			[SerializeField]
			[FormerlySerializedAs("mipBias")]
			internal float m_MipBias;

			[SerializeField]
			[FormerlySerializedAs("varianceClampScale")]
			internal float m_VarianceClampScale;

			[SerializeField]
			[FormerlySerializedAs("contrastAdaptiveSharpening")]
			internal float m_ContrastAdaptiveSharpening;

			[NonSerialized]
			internal int resetHistoryFrames;

			[NonSerialized]
			internal int jitterFrameCountOffset;

			public TemporalAAQuality quality
			{
				get
				{
					return default(TemporalAAQuality);
				}
				set
				{
				}
			}

			public float baseBlendFactor
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float jitterScale
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float mipBias
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float varianceClampScale
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float contrastAdaptiveSharpening
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public static Settings Create()
			{
				return default(Settings);
			}
		}

		internal delegate void JitterFunc(int frameIndex, out Vector2 jitter, out bool allowScaling);

		private class TaaPassData
		{
			internal TextureHandle dstTex;

			internal TextureHandle srcColorTex;

			internal TextureHandle srcDepthTex;

			internal TextureHandle srcMotionVectorTex;

			internal TextureHandle srcTaaAccumTex;

			internal Material material;

			internal int passIndex;

			internal float taaFrameInfluence;

			internal float taaVarianceClampScale;

			internal float[] taaFilterWeights;

			internal bool taaLowPrecisionSource;

			internal bool taaAlphaOutput;
		}

		internal static JitterFunc s_JitterFunc;

		private static readonly Vector2[] taaFilterOffsets;

		private static readonly float[] taaFilterWeights;

		internal static GraphicsFormat[] AccumulationFormatList;

		private static uint s_warnCounter;

		internal static int CalculateTaaFrameIndex(ref Settings settings)
		{
			return 0;
		}

		internal static Matrix4x4 CalculateJitterMatrix(UniversalCameraData cameraData, JitterFunc jitterFunc)
		{
			return default(Matrix4x4);
		}

		internal static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling)
		{
			jitter = default(Vector2);
			allowScaling = default(bool);
		}

		internal static float[] CalculateFilterWeights(ref Settings settings)
		{
			return null;
		}

		internal static RenderTextureDescriptor TemporalAADescFromCameraDesc(ref RenderTextureDescriptor cameraDesc)
		{
			return default(RenderTextureDescriptor);
		}

		internal static string ValidateAndWarn(UniversalCameraData cameraData, bool isSTPRequested = false)
		{
			return null;
		}

		internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors)
		{
		}

		internal static void Render(RenderGraph renderGraph, Material taaMaterial, UniversalCameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor)
		{
		}
	}
}
