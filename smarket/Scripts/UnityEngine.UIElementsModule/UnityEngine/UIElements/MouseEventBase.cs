namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.Pointer)]
	public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal, IPointerOrMouseEvent where T : MouseEventBase<T>, new()
	{
		public EventModifiers modifiers { get; protected set; }

		public Vector2 mousePosition { get; protected set; }

		public Vector2 localMousePosition { get; internal set; }

		public Vector2 mouseDelta { get; protected set; }

		public int clickCount { get; protected set; }

		public int button { get; protected set; }

		public int pressedButtons { get; protected set; }

		public bool ctrlKey => false;

		public bool commandKey => false;

		internal IPointerEvent sourcePointerEvent { get; set; }

		internal bool recomputeTopElementUnderMouse { get; set; }

		IPointerEvent IMouseEventInternal.sourcePointerEvent => null;

		Vector3 IPointerOrMouseEvent.position => default(Vector3);

		Vector3 IPointerOrMouseEvent.deltaPosition
		{
			set
			{
			}
		}

		public override IEventHandler currentTarget
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		protected override void Init()
		{
		}

		private void LocalInit()
		{
		}

		protected internal override void PreDispatch(IPanel panel)
		{
		}

		protected internal override void PostDispatch(IPanel panel)
		{
		}

		internal override void Dispatch(BaseVisualElementPanel panel)
		{
		}

		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition)
		{
			return null;
		}

		public static T GetPooled(IMouseEvent triggerEvent)
		{
			return null;
		}

		protected static T GetPooled(IPointerEvent pointerEvent)
		{
			return null;
		}
	}
}
