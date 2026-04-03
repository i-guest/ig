using System;

namespace UnityEngine.UIElements
{
	[DisallowMultipleComponent]
	[AddComponentMenu("UI Toolkit/Panel Input Configuration", 1)]
	[HelpURL("UIE-get-started-with-runtime-ui")]
	[ExecuteAlways]
	public sealed class PanelInputConfiguration : MonoBehaviour
	{
		public enum PanelInputRedirection
		{
			[InspectorName("Auto-switch (redirect from EventSystem if present)")]
			AutoSwitch = 0,
			[InspectorName("No input redirection")]
			Never = 1,
			[InspectorName("Always redirect from EventSystem (wait if unavailable)")]
			Always = 2
		}

		[Serializable]
		internal struct Settings
		{
			private static Settings s_Default;

			[SerializeField]
			[Tooltip("Determines whether world space panels process input events. Disable this if you need UGUI support but do not require world space input to improve performance.")]
			internal bool m_ProcessWorldSpaceInput;

			[SerializeField]
			[Tooltip("Determines which layers can block input events on world space panels.")]
			internal LayerMask m_InteractionLayers;

			[Tooltip("Sets how far away interactions with world-space UI are possible. Defaults to unlimited (infinity), but you can customize it for XR or performance needs. The distance uses GameObject units, consistent with transform positions and Camera clipping planes.")]
			[SerializeField]
			internal float m_MaxInteractionDistance;

			[Tooltip("Defines whether the Main Camera is used as the Event Camera for world space panels. Disable to specify alternative Event Camera(s) for raycasting input.")]
			[SerializeField]
			internal bool m_DefaultEventCameraIsMainCamera;

			[Tooltip("Defines the Event Camera(s) used for world space raycasting input.")]
			[SerializeField]
			internal Camera[] m_EventCameras;

			[Tooltip("Determines which input event system is used for UI interactions when combining UI Toolkit and UGUI.")]
			[SerializeField]
			internal PanelInputRedirection m_PanelInputRedirection;

			[SerializeField]
			[Tooltip("Automatically adds UI Toolkit components under the EventSystem to handle input redirection between UI Toolkit and UGUI panels. Disable to manually assign these components through code.")]
			internal bool m_AutoCreatePanelComponents;

			public static Settings Default => default(Settings);

			public bool processWorldSpaceInput => false;

			public LayerMask interactionLayers => default(LayerMask);

			public float maxInteractionDistance => 0f;

			public bool defaultEventCameraIsMainCamera => false;

			public Camera[] eventCameras => null;

			public PanelInputRedirection panelInputRedirection => default(PanelInputRedirection);

			public bool autoCreatePanelComponents => false;
		}

		internal static int s_ActiveInstances;

		internal static Action<PanelInputConfiguration> onApply;

		[SerializeField]
		private Settings m_Settings;

		internal const string SettingsProperty = "m_Settings";

		internal static PanelInputConfiguration current { get; set; }

		internal Settings settings => default(Settings);

		public bool processWorldSpaceInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LayerMask interactionLayers
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public float maxInteractionDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool defaultEventCameraIsMainCamera
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Camera[] eventCameras
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PanelInputRedirection panelInputRedirection
		{
			get
			{
				return default(PanelInputRedirection);
			}
			set
			{
			}
		}

		public bool autoCreatePanelComponents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private static void Apply(PanelInputConfiguration input)
		{
		}
	}
}
