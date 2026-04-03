using System;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	[AddComponentMenu("Rendering/Lens Flare (SRP)")]
	public sealed class LensFlareComponentSRP : MonoBehaviour
	{
		private enum Version
		{
			Initial = 0
		}

		[SerializeField]
		private LensFlareDataSRP m_LensFlareData;

		[SerializeField]
		private Version version;

		[Min(0f)]
		public float intensity;

		[Min(1E-05f)]
		public float maxAttenuationDistance;

		[Min(1E-05f)]
		public float maxAttenuationScale;

		public AnimationCurve distanceAttenuationCurve;

		public AnimationCurve scaleByDistanceCurve;

		public bool attenuationByLightShape;

		public AnimationCurve radialScreenAttenuationCurve;

		public bool useOcclusion;

		[Obsolete("Replaced by environmentOcclusion. #from(6000.0)")]
		public bool useBackgroundCloudOcclusion;

		[FormerlySerializedAs("volumetricCloudOcclusion")]
		[FormerlySerializedAs("useFogOpacityOcclusion")]
		public bool environmentOcclusion;

		[Obsolete("Replaced by environmentOcclusion. #from(6000.0)")]
		public bool useWaterOcclusion;

		[Min(0f)]
		public float occlusionRadius;

		[Range(1f, 64f)]
		public uint sampleCount;

		public float occlusionOffset;

		[Min(0f)]
		public float scale;

		public bool allowOffScreen;

		[Obsolete("Please use environmentOcclusion instead. #from(6000.0)")]
		public bool volumetricCloudOcclusion;

		private static float sCelestialAngularRadius;

		public TextureCurve occlusionRemapCurve;

		public Light lightOverride;

		public LensFlareDataSRP lensFlareData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float celestialProjectedOcclusionRadius(Camera mainCam)
		{
			return 0f;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
