using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	[ExecuteAlways]
	public class UniversalAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
	{
		private enum Version
		{
			Initial = 0,
			DepthAndOpaqueTextureOptions = 2,
			Count = 3
		}

		private const string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/";

		private const string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";

		private const string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";

		private const string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png";

		[FormerlySerializedAs("renderShadows")]
		[SerializeField]
		private bool m_RenderShadows;

		[SerializeField]
		private CameraOverrideOption m_RequiresDepthTextureOption;

		[SerializeField]
		private CameraOverrideOption m_RequiresOpaqueTextureOption;

		[SerializeField]
		private CameraRenderType m_CameraType;

		[SerializeField]
		private List<Camera> m_Cameras;

		[SerializeField]
		private int m_RendererIndex;

		[SerializeField]
		private LayerMask m_VolumeLayerMask;

		[SerializeField]
		private Transform m_VolumeTrigger;

		[SerializeField]
		private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption;

		[SerializeField]
		private bool m_RenderPostProcessing;

		[SerializeField]
		private AntialiasingMode m_Antialiasing;

		[SerializeField]
		private AntialiasingQuality m_AntialiasingQuality;

		[SerializeField]
		private bool m_StopNaN;

		[SerializeField]
		private bool m_Dithering;

		[SerializeField]
		private bool m_ClearDepth;

		[SerializeField]
		private bool m_AllowXRRendering;

		[SerializeField]
		private bool m_AllowHDROutput;

		[SerializeField]
		private bool m_UseScreenCoordOverride;

		[SerializeField]
		private Vector4 m_ScreenSizeOverride;

		[SerializeField]
		private Vector4 m_ScreenCoordScaleBias;

		[NonSerialized]
		private Camera m_Camera;

		[FormerlySerializedAs("requiresDepthTexture")]
		[SerializeField]
		private bool m_RequiresDepthTexture;

		[FormerlySerializedAs("requiresColorTexture")]
		[SerializeField]
		private bool m_RequiresColorTexture;

		[NonSerialized]
		private MotionVectorsPersistentData m_MotionVectorsPersistentData;

		[NonSerialized]
		internal UniversalCameraHistory m_History;

		[SerializeField]
		internal TemporalAA.Settings m_TaaSettings;

		private static UniversalAdditionalCameraData s_DefaultAdditionalCameraData;

		private static List<VolumeStack> s_CachedVolumeStacks;

		private VolumeStack m_VolumeStack;

		[SerializeField]
		private Version m_Version;

		internal static UniversalAdditionalCameraData defaultAdditionalCameraData => null;

		internal Camera camera => null;

		public bool renderShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CameraOverrideOption requiresDepthOption
		{
			get
			{
				return default(CameraOverrideOption);
			}
			set
			{
			}
		}

		public CameraOverrideOption requiresColorOption
		{
			get
			{
				return default(CameraOverrideOption);
			}
			set
			{
			}
		}

		public CameraRenderType renderType
		{
			get
			{
				return default(CameraRenderType);
			}
			set
			{
			}
		}

		public List<Camera> cameraStack => null;

		public bool clearDepth => false;

		public bool requiresDepthTexture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool requiresColorTexture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ScriptableRenderer scriptableRenderer => null;

		public LayerMask volumeLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public Transform volumeTrigger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
		{
			get
			{
				return default(VolumeFrameworkUpdateMode);
			}
			set
			{
			}
		}

		public bool requiresVolumeFrameworkUpdate => false;

		public VolumeStack volumeStack
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool renderPostProcessing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AntialiasingMode antialiasing
		{
			get
			{
				return default(AntialiasingMode);
			}
			set
			{
			}
		}

		public AntialiasingQuality antialiasingQuality
		{
			get
			{
				return default(AntialiasingQuality);
			}
			set
			{
			}
		}

		public ref TemporalAA.Settings taaSettings
		{
			get
			{
				throw null;
			}
		}

		public ICameraHistoryReadAccess history => null;

		internal UniversalCameraHistory historyManager => null;

		internal MotionVectorsPersistentData motionVectorsPersistentData => null;

		public bool resetHistory
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stopNaN
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool dithering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowXRRendering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useScreenCoordOverride
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector4 screenSizeOverride
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public Vector4 screenCoordScaleBias
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public bool allowHDROutput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("This field has been deprecated. #from(6000.2)")]
		public float version => 0f;

		private void Start()
		{
		}

		internal void UpdateCameraStack()
		{
		}

		public void SetRenderer(int index)
		{
		}

		internal void GetOrCreateVolumeStack()
		{
		}

		public void OnValidate()
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDestroy()
		{
		}

		private ScriptableRenderer GetRawRenderer()
		{
			return null;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
