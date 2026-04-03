using System;
using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Serialization;

namespace UnityEngine.UIElements
{
	[HelpURL("UIE-Runtime-Panel-Settings")]
	public class PanelSettings : ScriptableObject
	{
		private class RuntimePanelAccess
		{
			private readonly PanelSettings m_Settings;

			private BaseRuntimePanel m_RuntimePanel;

			internal bool isInitialized => false;

			internal bool isTransient { get; set; }

			internal BaseRuntimePanel panel => null;

			internal RuntimePanelAccess(PanelSettings settings)
			{
			}

			internal void DisposePanel()
			{
			}

			internal void SetTargetTexture()
			{
			}

			internal void SetSortingPriority()
			{
			}

			internal void SetTargetDisplay()
			{
			}

			internal void SetPanelChangeReceiver()
			{
			}

			private BaseRuntimePanel CreateRelatedRuntimePanel()
			{
				return null;
			}

			private void DisposeRelatedPanel()
			{
			}

			internal void MarkPotentiallyEmpty()
			{
			}
		}

		private const int k_DefaultSortingOrder = 0;

		private const float k_DefaultScaleValue = 1f;

		internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";

		[SerializeField]
		private ThemeStyleSheet themeUss;

		[SerializeField]
		private bool m_DisableNoThemeWarning;

		[SerializeField]
		private RenderTexture m_TargetTexture;

		[SerializeField]
		private PanelRenderMode m_RenderMode;

		[FormerlySerializedAs("m_WorldInputMode")]
		[SerializeField]
		private ColliderUpdateMode m_ColliderUpdateMode;

		[SerializeField]
		private bool m_ColliderIsTrigger;

		[SerializeField]
		private PanelScaleMode m_ScaleMode;

		[SerializeField]
		private float m_ReferenceSpritePixelsPerUnit;

		[SerializeField]
		private float m_PixelsPerUnit;

		[SerializeField]
		private float m_Scale;

		private const float DefaultDpi = 96f;

		[SerializeField]
		private float m_ReferenceDpi;

		[SerializeField]
		private float m_FallbackDpi;

		[SerializeField]
		private Vector2Int m_ReferenceResolution;

		[SerializeField]
		private PanelScreenMatchMode m_ScreenMatchMode;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_Match;

		[SerializeField]
		private float m_SortingOrder;

		[SerializeField]
		private int m_TargetDisplay;

		[SerializeField]
		private BindingLogLevel m_BindingLogLevel;

		[SerializeField]
		private bool m_ClearDepthStencil;

		[SerializeField]
		private bool m_ClearColor;

		[SerializeField]
		private Color m_ColorClearValue;

		[SerializeField]
		private uint m_VertexBudget;

		[SerializeField]
		private TextureSlotCount m_TextureSlotCount;

		private RuntimePanelAccess m_PanelAccess;

		internal UIDocumentList m_AttachedUIDocumentsList;

		[HideInInspector]
		[SerializeField]
		private DynamicAtlasSettings m_DynamicAtlasSettings;

		[SerializeField]
		[HideInInspector]
		private Shader m_AtlasBlitShader;

		[HideInInspector]
		[SerializeField]
		private Shader m_DefaultShader;

		[HideInInspector]
		[SerializeField]
		private Shader m_RuntimeGaussianBlurShader;

		[SerializeField]
		[HideInInspector]
		private Shader m_RuntimeColorEffectShader;

		[SerializeField]
		[HideInInspector]
		private Shader m_SDFShader;

		[SerializeField]
		[HideInInspector]
		private Shader m_BitmapShader;

		[HideInInspector]
		[SerializeField]
		private Shader m_SpriteShader;

		[HideInInspector]
		[SerializeField]
		internal TextAsset m_ICUDataAsset;

		[SerializeField]
		public bool forceGammaRendering;

		[SerializeField]
		public PanelTextSettings textSettings;

		private Rect m_TargetRect;

		private float m_ResolvedScale;

		private StyleSheet m_OldThemeUss;

		private IDebugPanelChangeReceiver m_PanelChangeReceiver;

		private Func<Vector2, Vector3> m_AssignedScreenToPanel;

		public ThemeStyleSheet themeStyleSheet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool disableNoThemeWarning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal PanelRenderMode renderMode
		{
			get
			{
				return default(PanelRenderMode);
			}
			set
			{
			}
		}

		internal ColliderUpdateMode colliderUpdateMode
		{
			get
			{
				return default(ColliderUpdateMode);
			}
			set
			{
			}
		}

		internal bool colliderIsTrigger
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PanelScaleMode scaleMode
		{
			get
			{
				return default(PanelScaleMode);
			}
			set
			{
			}
		}

		public float referenceSpritePixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float pixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float referenceDpi
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fallbackDpi
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2Int referenceResolution
		{
			get
			{
				return default(Vector2Int);
			}
			set
			{
			}
		}

		public PanelScreenMatchMode screenMatchMode
		{
			get
			{
				return default(PanelScreenMatchMode);
			}
			set
			{
			}
		}

		public float match
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float sortingOrder
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public BindingLogLevel bindingLogLevel
		{
			get
			{
				return default(BindingLogLevel);
			}
			set
			{
			}
		}

		public bool clearDepthStencil
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float depthClearValue => 0f;

		public bool clearColor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color colorClearValue
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public uint vertexBudget
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public TextureSlotCount textureSlotCount
		{
			get
			{
				return default(TextureSlotCount);
			}
			set
			{
			}
		}

		internal BaseRuntimePanel panel
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule" })]
			get
			{
				return null;
			}
		}

		internal bool isInitialized => false;

		internal bool isTransient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal VisualElement visualTree => null;

		public DynamicAtlasSettings dynamicAtlasSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float ScreenDPI { get; set; }

		internal void ApplySortingOrder()
		{
		}

		private PanelSettings()
		{
		}

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		internal void DisposePanel()
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public void SetPanelChangeReceiver(IDebugPanelChangeReceiver value)
		{
		}

		internal IDebugPanelChangeReceiver GetPanelChangeReceiver()
		{
			return null;
		}

		internal void UpdateScreenDPI()
		{
		}

		private void ApplyThemeStyleSheet(VisualElement root = null)
		{
		}

		internal bool AssignICUData()
		{
			return false;
		}

		private void InitializeShaders()
		{
		}

		internal void ApplyPanelSettings()
		{
		}

		public void SetScreenToPanelSpaceFunction3D(Func<Vector2, Vector3> screenToPanelSpaceFunction)
		{
		}

		public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screenToPanelSpaceFunction)
		{
		}

		internal float ResolveScale(Rect targetRect, float screenDpi)
		{
			return 0f;
		}

		internal Rect GetDisplayRect()
		{
			return default(Rect);
		}

		internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument)
		{
		}

		internal void DetachUIDocument(UIDocument uiDocument)
		{
		}
	}
}
