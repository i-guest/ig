using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.UIElements.Layout;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule", "UnityEngine.VectorGraphicsModule" })]
	internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
	{
		private UIElementsBridge m_UIElementsBridge;

		private float m_Scale;

		internal LayoutConfig layoutConfig;

		private float m_PixelsPerPoint;

		internal IPanelRenderer panelRenderer;

		private TimerEventScheduler m_Scheduler;

		private TimeFunction m_TimeSinceStartupFunc;

		internal ElementUnderPointer m_TopElementUnderPointers;

		private bool m_IsFlat;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IPanel> beforeUpdate;

		internal static readonly Vector2 s_OutsidePanelCoordinates;

		public readonly Lazy<HashSet<TextElement>> textElementRegistry;

		internal Func<AbstractGenericMenu> CreateMenuFunctor;

		public abstract EventInterests IMGUIEventInterests { get; set; }

		public abstract ScriptableObject ownerObject { get; protected set; }

		public abstract SavePersistentViewData saveViewData { get; }

		public abstract GetViewDataDictionary getViewDataDictionary { get; }

		public abstract int IMGUIContainersCount { get; set; }

		public abstract FocusController focusController { get; set; }

		public abstract IMGUIContainer rootIMGUIContainer { get; }

		internal UIElementsBridge uiElementsBridge => null;

		internal float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scaledPixelsPerPoint => 0f;

		public float referenceSpritePixelsPerUnit { get; set; }

		internal PanelClearSettings clearSettings { get; set; }

		internal bool duringLayoutPhase { get; set; }

		public bool isDirty => false;

		internal abstract uint version { get; }

		internal abstract uint repaintVersion { get; }

		internal abstract uint hierarchyVersion { get; }

		internal virtual RepaintData repaintData { get; set; }

		internal virtual ICursorManager cursorManager { get; set; }

		public ContextualMenuManager contextualMenuManager { get; internal set; }

		internal virtual DataBindingManager dataBindingManager { get; set; }

		public abstract VisualElement visualTree { get; }

		public abstract EventDispatcher dispatcher { get; set; }

		internal TimerEventScheduler scheduler => null;

		internal abstract IStylePropertyAnimationSystem styleAnimationSystem
		{
			get; [VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			set;
		}

		public abstract ContextType contextType { get; }

		internal TimeFunction TimeSinceStartupFunc => null;

		internal bool disposed { get; private set; }

		public bool isFlat
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public abstract AtlasBase atlas { get; set; }

		internal event Action<BaseVisualElementPanel> panelDisposed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal event Action isFlatChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal event Action atlasChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal event HierarchyEvent hierarchyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public abstract void Repaint(Event e);

		public abstract void ValidateLayout();

		public abstract void TickSchedulingUpdaters();

		public abstract void UpdateForRepaint();

		public abstract void UpdateAnimations();

		public abstract void UpdateBindings();

		public abstract void UpdateDataBinding();

		public abstract void ApplyStyles();

		internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

		internal abstract void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase);

		internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default)
		{
		}

		public long TimeSinceStartupMs()
		{
			return 0L;
		}

		public double TimeSinceStartupSeconds()
		{
			return 0.0;
		}

		internal static double DefaultTimeSinceStartup()
		{
			return 0.0;
		}

		public VisualElement Pick(Vector2 point)
		{
			return null;
		}

		public abstract VisualElement Pick(Vector2 point, int pointerId);

		public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);

		internal VisualElement GetTopElementUnderPointer(int pointerId)
		{
			return null;
		}

		internal void RemoveElementFromPointerCache(VisualElement e)
		{
		}

		internal void SetTopElementUnderPointer(int pointerId, VisualElement element, EventBase triggerEvent)
		{
		}

		internal void SetTopElementUnderPointer(int pointerId, VisualElement element, Vector2 position)
		{
		}

		internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent)
		{
			return null;
		}

		internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent)
		{
		}

		internal bool CommitElementUnderPointers()
		{
			return false;
		}

		internal void SetSpecializedHierarchyFlagsUpdater()
		{
		}

		protected void InvokeAtlasChanged()
		{
		}

		internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null)
		{
		}

		internal void InvokeBeforeUpdate()
		{
		}

		internal bool UpdateElementUnderPointers()
		{
			return false;
		}

		void IGroupBox.OnOptionAdded(IGroupBoxOption option)
		{
		}

		void IGroupBox.OnOptionRemoved(IGroupBoxOption option)
		{
		}

		public virtual void Render()
		{
		}

		internal AbstractGenericMenu CreateMenu()
		{
			return null;
		}
	}
}
