using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class EventBase : IDisposable
	{
		[Flags]
		internal enum EventPropagation
		{
			None = 0,
			Bubbles = 1,
			TricklesDown = 2,
			SkipDisabledElements = 4,
			BubblesOrTricklesDown = 3
		}

		[Flags]
		private enum LifeCycleStatus
		{
			None = 0,
			PropagationStopped = 1,
			ImmediatePropagationStopped = 2,
			Dispatching = 4,
			Pooled = 8,
			IMGUIEventIsValid = 0x10,
			PropagateToIMGUI = 0x20,
			Dispatched = 0x40,
			Processed = 0x80,
			ProcessedByFocusController = 0x100
		}

		private static long s_LastTypeId;

		private static ulong s_NextEventId;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ulong _003CtriggerEventId_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PropagationPhase _003CpropagationPhase_003Ek__BackingField;

		private IEventHandler m_CurrentTarget;

		private Event m_ImguiEvent;

		public virtual long eventTypeId => 0L;

		internal int eventCategories { get; }

		public long timestamp { get; private set; }

		internal ulong eventId { get; private set; }

		private ulong triggerEventId
		{
			[CompilerGenerated]
			set
			{
				_003CtriggerEventId_003Ek__BackingField = value;
			}
		}

		internal EventPropagation propagation { get; set; }

		private LifeCycleStatus lifeCycleStatus { get; set; }

		public bool bubbles
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public bool tricklesDown
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		internal bool skipDisabledElements
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool bubblesOrTricklesDown => false;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal VisualElement elementTarget { get; set; }

		public IEventHandler target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isPropagationStopped
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool isImmediatePropagationStopped
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		internal PropagationPhase propagationPhase
		{
			[CompilerGenerated]
			set
			{
				_003CpropagationPhase_003Ek__BackingField = value;
			}
		}

		public virtual IEventHandler currentTarget
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool dispatch
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		private bool dispatched
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool processed
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		internal bool processedByFocusController
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool propagateToIMGUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool imguiEventIsValid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Event imguiEvent
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Vector2 originalMousePosition { get; private set; }

		protected bool pooled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected static long RegisterEventType()
		{
			return 0L;
		}

		internal void SetTriggerEventId(ulong id)
		{
		}

		[Obsolete("Override PreDispatch(IPanel panel) instead.")]
		protected virtual void PreDispatch()
		{
		}

		protected internal virtual void PreDispatch(IPanel panel)
		{
		}

		[Obsolete("Override PostDispatch(IPanel panel) instead.")]
		protected virtual void PostDispatch()
		{
		}

		protected internal virtual void PostDispatch(IPanel panel)
		{
		}

		internal virtual void Dispatch([JetBrains.Annotations.NotNull] BaseVisualElementPanel panel)
		{
		}

		public void StopPropagation()
		{
		}

		public void StopImmediatePropagation()
		{
		}

		internal void MarkReceivedByDispatcher()
		{
		}

		protected virtual void Init()
		{
		}

		private void LocalInit()
		{
		}

		protected EventBase()
		{
		}

		internal EventBase(EventCategory category)
		{
		}

		internal abstract void Acquire();

		public abstract void Dispose();

		internal void AssignTimeStamp(long time)
		{
		}
	}
	[EventCategory(EventCategory.Default)]
	public abstract class EventBase<T> : EventBase where T : EventBase<T>, new()
	{
		private static readonly long s_TypeId;

		private static readonly ObjectPool<T> s_Pool;

		private int m_RefCount;

		internal static readonly EventCategory EventCategory;

		public override long eventTypeId => 0L;

		protected internal static void SetCreateFunction(Func<T> createMethod)
		{
		}

		public static long TypeId()
		{
			return 0L;
		}

		protected override void Init()
		{
		}

		public static T GetPooled()
		{
			return null;
		}

		internal static T GetPooled(EventBase e)
		{
			return null;
		}

		private static void ReleasePooled(T evt)
		{
		}

		internal override void Acquire()
		{
		}

		public sealed override void Dispose()
		{
		}
	}
}
