using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[ReloadGroup]
	[ExcludeFromPreset]
	public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver
	{
		[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)")]
		public XRSystemData xrSystemData;

		public PostProcessData postProcessData;

		private const int k_LatestAssetVersion = 3;

		[SerializeField]
		private int m_AssetVersion;

		[SerializeField]
		private LayerMask m_PrepassLayerMask;

		[SerializeField]
		private LayerMask m_OpaqueLayerMask;

		[SerializeField]
		private LayerMask m_TransparentLayerMask;

		[SerializeField]
		private StencilStateData m_DefaultStencilState;

		[SerializeField]
		private bool m_ShadowTransparentReceive;

		[SerializeField]
		private RenderingMode m_RenderingMode;

		[SerializeField]
		private DepthPrimingMode m_DepthPrimingMode;

		[SerializeField]
		private CopyDepthMode m_CopyDepthMode;

		[SerializeField]
		private DepthFormat m_DepthAttachmentFormat;

		[SerializeField]
		private DepthFormat m_DepthTextureFormat;

		[SerializeField]
		private bool m_AccurateGbufferNormals;

		[SerializeField]
		private IntermediateTextureMode m_IntermediateTextureMode;

		[NonSerialized]
		private bool m_StripShadowsOffVariants;

		[NonSerialized]
		private bool m_StripAdditionalLightOffVariants;

		public LayerMask prepassLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public LayerMask opaqueLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public LayerMask transparentLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public StencilStateData defaultStencilState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool shadowTransparentReceive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RenderingMode renderingMode
		{
			get
			{
				return default(RenderingMode);
			}
			set
			{
			}
		}

		public DepthPrimingMode depthPrimingMode
		{
			get
			{
				return default(DepthPrimingMode);
			}
			set
			{
			}
		}

		public CopyDepthMode copyDepthMode
		{
			get
			{
				return default(CopyDepthMode);
			}
			set
			{
			}
		}

		public DepthFormat depthAttachmentFormat
		{
			get
			{
				return default(DepthFormat);
			}
			set
			{
			}
		}

		public DepthFormat depthTextureFormat
		{
			get
			{
				return default(DepthFormat);
			}
			set
			{
			}
		}

		public bool accurateGbufferNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IntermediateTextureMode intermediateTextureMode
		{
			get
			{
				return default(IntermediateTextureMode);
			}
			set
			{
			}
		}

		public bool usesDeferredLighting => false;

		public bool usesClusterLightLoop => false;

		internal override bool stripShadowsOffVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override bool stripAdditionalLightOffVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override ScriptableRenderer Create()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		private void ReloadAllNullProperties()
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
