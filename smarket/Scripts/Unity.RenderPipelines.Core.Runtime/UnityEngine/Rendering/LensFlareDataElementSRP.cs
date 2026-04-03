using System;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[Serializable]
	public sealed class LensFlareDataElementSRP
	{
		public LensFlareDataSRP lensFlareDataSRP;

		public bool visible;

		public float position;

		public Vector2 positionOffset;

		public float angularOffset;

		public Vector2 translationScale;

		[Range(0f, 1f)]
		public float ringThickness;

		[Range(-1f, 1f)]
		public float hoopFactor;

		public float noiseAmplitude;

		public int noiseFrequency;

		public float noiseSpeed;

		public float shapeCutOffSpeed;

		public float shapeCutOffRadius;

		[Min(0f)]
		[SerializeField]
		[FormerlySerializedAs("localIntensity")]
		private float m_LocalIntensity;

		public Texture lensFlareTexture;

		public float uniformScale;

		public Vector2 sizeXY;

		public bool allowMultipleElement;

		[Min(1f)]
		[SerializeField]
		[FormerlySerializedAs("count")]
		private int m_Count;

		public bool preserveAspectRatio;

		public float rotation;

		public SRPLensFlareColorType tintColorType;

		public Color tint;

		public TextureGradient tintGradient;

		public SRPLensFlareBlendMode blendMode;

		public bool autoRotate;

		public SRPLensFlareType flareType;

		public bool modulateByLightColor;

		[SerializeField]
		private bool isFoldOpened;

		public SRPLensFlareDistribution distribution;

		public float lengthSpread;

		public AnimationCurve positionCurve;

		public AnimationCurve scaleCurve;

		public int seed;

		public Gradient colorGradient;

		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("intensityVariation")]
		private float m_IntensityVariation;

		public Vector2 positionVariation;

		public float scaleVariation;

		public float rotationVariation;

		public bool enableRadialDistortion;

		public Vector2 targetSizeDistortion;

		public AnimationCurve distortionCurve;

		public bool distortionRelativeToCenter;

		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("fallOff")]
		private float m_FallOff;

		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("edgeOffset")]
		private float m_EdgeOffset;

		[Min(3f)]
		[SerializeField]
		[FormerlySerializedAs("sideCount")]
		private int m_SideCount;

		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("sdfRoundness")]
		private float m_SdfRoundness;

		public bool inverseSDF;

		public float uniformAngle;

		public AnimationCurve uniformAngleCurve;

		public float localIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float intensityVariation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fallOff
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float edgeOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int sideCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float sdfRoundness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LensFlareDataElementSRP Clone()
		{
			return null;
		}
	}
}
