using System;
using System.Collections.Generic;
using Unity.Profiling;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class IMGUIContainer : VisualElement, IDisposable
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}

		internal struct UITKScope : IDisposable
		{
			private bool wasUITK;

			public UITKScope()
			{
				wasUITK = false;
			}

			public void Dispose()
			{
			}
		}

		internal struct NotUITKScope : IDisposable
		{
			private bool wasUITK;

			public NotUITKScope()
			{
				wasUITK = false;
			}

			public void Dispose()
			{
			}
		}

		private struct GUIGlobals
		{
			public Matrix4x4 matrix;

			public Color color;

			public Color contentColor;

			public Color backgroundColor;

			public bool enabled;

			public bool changed;

			public int displayIndex;

			public float pixelsPerPoint;
		}

		internal static readonly BindingId cullingEnabledProperty;

		internal static readonly BindingId contextTypeProperty;

		private Action m_OnGUIHandler;

		private ObjectGUIState m_ObjectGUIState;

		internal bool useOwnerObjectGUIState;

		private bool m_CullingEnabled;

		private bool m_IsFocusDelegated;

		private bool m_RefreshCachedLayout;

		private GUILayoutUtility.LayoutCache m_Cache;

		private Rect m_CachedClippingRect;

		private Matrix4x4 m_CachedTransform;

		private ContextType m_ContextType;

		private bool lostFocus;

		private bool receivedFocus;

		private FocusChangeDirection focusChangeDirection;

		private bool hasFocusableControls;

		private int newKeyboardFocusControlID;

		public static readonly string ussClassName;

		internal static readonly string ussFoldoutChildDepthClassName;

		internal static readonly List<string> ussFoldoutChildDepthClassNames;

		private GUIGlobals m_GUIGlobals;

		private static readonly ProfilerMarker k_OnGUIMarker;

		private static readonly ProfilerMarker k_ImmediateCallbackMarker;

		private static Event s_DefaultMeasureEvent;

		private static Event s_MeasureEvent;

		private static Event s_CurrentEvent;

		public Action onGUIHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ObjectGUIState guiState => null;

		internal Rect lastWorldClip { get; set; }

		[CreateProperty]
		public bool cullingEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private GUILayoutUtility.LayoutCache cache => null;

		private float layoutMeasuredWidth => 0f;

		private float layoutMeasuredHeight => 0f;

		[CreateProperty]
		public ContextType contextType
		{
			get
			{
				return default(ContextType);
			}
			set
			{
			}
		}

		internal bool focusOnlyIfHasFocusableControls { get; }

		public override bool canGrabFocus => false;

		static IMGUIContainer()
		{
		}

		public IMGUIContainer()
		{
		}

		public IMGUIContainer(Action onGUIHandler)
		{
		}

		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		private void SaveGlobals()
		{
		}

		private void RestoreGlobals()
		{
		}

		private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true)
		{
		}

		public void MarkDirtyLayout()
		{
		}

		private void DoIMGUIRepaint()
		{
		}

		internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true)
		{
			return false;
		}

		private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds)
		{
			return false;
		}

		private bool VerifyBounds(EventBase evt)
		{
			return false;
		}

		private bool IsContainerCapturingTheMouse()
		{
			return false;
		}

		private bool IsLocalEvent(EventBase evt)
		{
			return false;
		}

		private bool IsEventInsideLocalWindow(EventBase evt)
		{
			return false;
		}

		private static bool IsDockAreaMouseUp(EventBase evt)
		{
			return false;
		}

		internal bool HandleIMGUIEvent(Event e, bool canAffectFocus)
		{
			return false;
		}

		internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus)
		{
			return false;
		}

		private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus)
		{
			return false;
		}

		[EventInterest(EventInterestOptionsInternal.TriggeredByOS)]
		[EventInterest(new Type[]
		{
			typeof(NavigationMoveEvent),
			typeof(NavigationSubmitEvent),
			typeof(NavigationCancelEvent),
			typeof(BlurEvent),
			typeof(FocusEvent),
			typeof(DetachFromPanelEvent),
			typeof(AttachToPanelEvent)
		})]
		internal override void HandleEventBubbleUpDisabled(EventBase evt)
		{
		}

		[EventInterest(new Type[]
		{
			typeof(NavigationMoveEvent),
			typeof(NavigationSubmitEvent),
			typeof(NavigationCancelEvent),
			typeof(BlurEvent),
			typeof(FocusEvent),
			typeof(DetachFromPanelEvent),
			typeof(AttachToPanelEvent)
		})]
		[EventInterest(EventInterestOptionsInternal.TriggeredByOS)]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		private void SetFoldoutDepthClass()
		{
		}

		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		private Rect GetCurrentClipRect()
		{
			return default(Rect);
		}

		private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect)
		{
			transform = default(Matrix4x4);
			clipRect = default(Rect);
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposeManaged)
		{
		}
	}
}
