using System;

namespace UnityEngine.Rendering.Universal
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Light))]
	public class UniversalAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
	{
		private enum Version
		{
			Initial = 0,
			RenderingLayers = 2,
			SoftShadowQuality = 3,
			RenderingLayersMask = 4,
			Count = 5
		}

		[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
		[SerializeField]
		private bool m_UsePipelineSettings;

		public static readonly int AdditionalLightsShadowResolutionTierCustom;

		public static readonly int AdditionalLightsShadowResolutionTierLow;

		public static readonly int AdditionalLightsShadowResolutionTierMedium;

		public static readonly int AdditionalLightsShadowResolutionTierHigh;

		public static readonly int AdditionalLightsShadowDefaultResolutionTier;

		public static readonly int AdditionalLightsShadowDefaultCustomResolution;

		[NonSerialized]
		private Light m_Light;

		public static readonly int AdditionalLightsShadowMinimumResolution;

		[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
		[SerializeField]
		private int m_AdditionalLightsShadowResolutionTier;

		[SerializeField]
		private bool m_CustomShadowLayers;

		[SerializeField]
		private Vector2 m_LightCookieSize;

		[SerializeField]
		private Vector2 m_LightCookieOffset;

		[SerializeField]
		private SoftShadowQuality m_SoftShadowQuality;

		[SerializeField]
		private RenderingLayerMask m_RenderingLayersMask;

		[SerializeField]
		private RenderingLayerMask m_ShadowRenderingLayersMask;

		[SerializeField]
		private Version m_Version;

		[Obsolete("This is obsolete, please use m_RenderingLayerMask instead. #from(2023.1)")]
		[SerializeField]
		private LightLayerEnum m_LightLayerMask;

		[Obsolete("This is obsolete, please use m_RenderingLayerMask instead. #from(2023.1)")]
		[SerializeField]
		private LightLayerEnum m_ShadowLayerMask;

		[SerializeField]
		[Obsolete("This is obsolete, please use m_RenderingLayersMask instead. #from(6000.2)")]
		private uint m_RenderingLayers;

		[SerializeField]
		[Obsolete("This is obsolete, please use renderingLayersMask instead. #from(6000.2)")]
		private uint m_ShadowRenderingLayers;

		public bool usePipelineSettings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Light light => null;

		public int additionalLightsShadowResolutionTier => 0;

		public bool customShadowLayers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
		public Vector2 lightCookieSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
		public Vector2 lightCookieOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[Tooltip("Controls the filtering quality of soft shadows. Higher quality has lower performance.")]
		public SoftShadowQuality softShadowQuality
		{
			get
			{
				return default(SoftShadowQuality);
			}
			set
			{
			}
		}

		public RenderingLayerMask renderingLayers
		{
			get
			{
				return default(RenderingLayerMask);
			}
			set
			{
			}
		}

		public RenderingLayerMask shadowRenderingLayers
		{
			get
			{
				return default(RenderingLayerMask);
			}
			set
			{
			}
		}

		[Obsolete("This is obsolete, please use renderingLayerMask instead. #from(2023.1) #breakingFrom(2023.1)", true)]
		public LightLayerEnum lightLayerMask
		{
			get
			{
				return default(LightLayerEnum);
			}
			set
			{
			}
		}

		[Obsolete("This is obsolete, please use shadowRenderingLayerMask instead. #from(2023.1) #breakingFrom(2023.1)", true)]
		public LightLayerEnum shadowLayerMask
		{
			get
			{
				return default(LightLayerEnum);
			}
			set
			{
			}
		}

		private void SyncLightAndShadowLayers()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
