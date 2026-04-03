using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	internal class UIToolkitInteroperabilityBridge
	{
		[Flags]
		public enum EventHandlerTypes
		{
			ScreenOverlay = 1,
			WorldSpace = 2
		}

		private EventSystem m_EventSystem;

		private bool m_OverrideUIToolkitEvents;

		private EventHandlerTypes m_HandlerTypes;

		private LayerMask m_WorldPickingLayers;

		private float m_WorldPickingMaxDistance;

		private bool m_CreateDefaultPanelComponents;

		private bool m_Started;

		private bool m_Enabled;

		private bool m_IsTrackingPanels;

		private GameObject m_WorldSpaceGo;

		private readonly HashSet<BaseRuntimePanel> trackedPanels;

		private readonly Dictionary<BaseRuntimePanel, Action> destroyedActions;

		private PanelInputConfiguration.Settings m_InputSettings;

		private bool m_OldOverrideUIToolkitEvents;

		private EventHandlerTypes m_OldHandlerTypes;

		private bool m_OldCreateDefaultPanelComponents;

		private bool m_OldDefaultEventCameraIsMainCamera;

		private long m_OldEventCamerasHash;

		private List<BaseRuntimePanel> m_PanelsToRemove;

		internal EventSystem eventSystem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool overrideUIToolkitEvents
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public EventHandlerTypes handlerTypes
		{
			get
			{
				return default(EventHandlerTypes);
			}
			internal set
			{
			}
		}

		public int worldPickingLayers
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public float worldPickingMaxDistance
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public bool createDefaultPanelComponents
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		private bool shouldTrackPanels => false;

		private void StartTrackingUIToolkitPanels()
		{
		}

		private void StartTrackingPanel(BaseRuntimePanel panel)
		{
		}

		private void StopTrackingUIToolkitPanels()
		{
		}

		private void UpdatePanelGameObject(BaseRuntimePanel panel)
		{
		}

		private void CreatePanelGameObject(BaseRuntimePanel panel)
		{
		}

		private void DestroyPanelGameObject(BaseRuntimePanel panel)
		{
		}

		private void CreateWorldSpacePanelGameObject()
		{
		}

		private void DestroyWorldSpacePanelGameObject()
		{
		}

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void Update()
		{
		}

		private void Apply(PanelInputConfiguration input)
		{
		}

		private void ApplyOverrideUIToolkitEvents()
		{
		}

		private void ApplyCameraProperties()
		{
		}

		private void ApplyOtherProperties()
		{
		}

		private void UpdatePanelTracking()
		{
		}

		private void UpdatePanelGameObjects()
		{
		}
	}
}
