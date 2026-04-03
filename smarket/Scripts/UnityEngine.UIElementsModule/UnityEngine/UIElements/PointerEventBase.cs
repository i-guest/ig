using System.Runtime.CompilerServices;
using UnityEngine.InputForUI;

namespace UnityEngine.UIElements
{
	[EventCategory(EventCategory.Pointer)]
	public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal, IPointerOrMouseEvent where T : PointerEventBase<T>, new()
	{
		private const float k_DefaultButtonPressure = 0.5f;

		private bool m_AltitudeNeedsConversion;

		private bool m_AzimuthNeedsConversion;

		private float m_AltitudeAngle;

		private float m_AzimuthAngle;

		private bool m_TiltNeeded;

		private Vector2 m_Tilt;

		public int pointerId { get; protected set; }

		public string pointerType { get; protected set; }

		public bool isPrimary { get; protected set; }

		public int button { get; protected set; }

		public int pressedButtons { get; protected set; }

		public Vector3 position { get; protected set; }

		public Vector3 localPosition { get; protected set; }

		public Vector3 deltaPosition { get; protected set; }

		public float deltaTime { get; protected set; }

		public int clickCount { get; protected set; }

		public float pressure { get; protected set; }

		public float tangentialPressure { get; protected set; }

		public float altitudeAngle
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public float azimuthAngle
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public float twist { get; protected set; }

		public Vector2 tilt
		{
			get
			{
				return default(Vector2);
			}
			protected set
			{
			}
		}

		public PenStatus penStatus { get; protected set; }

		public Vector2 radius { get; protected set; }

		public Vector2 radiusVariance { get; protected set; }

		public EventModifiers modifiers { get; protected set; }

		public bool shiftKey => false;

		public bool ctrlKey => false;

		public bool commandKey => false;

		public bool altKey => false;

		public bool actionKey => false;

		internal IMouseEvent compatibilityMouseEvent { get; set; }

		internal int displayIndex
		{
			[CompilerGenerated]
			set
			{
				_003CdisplayIndex_003Ek__BackingField = value;
			}
		}

		internal bool recomputeTopElementUnderPointer { get; set; }

		IMouseEvent IPointerEventInternal.compatibilityMouseEvent => null;

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

		private static bool IsMouse(Event systemEvent)
		{
			return false;
		}

		private static bool IsTouch(Event systemEvent)
		{
			return false;
		}

		private static float TiltToAzimuth(Vector2 tilt)
		{
			return 0f;
		}

		private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth)
		{
			return default(Vector2);
		}

		private static float TiltToAltitude(Vector2 tilt)
		{
			return 0f;
		}

		public static T GetPooled(Event systemEvent)
		{
			return null;
		}

		internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers, int displayIndex)
		{
			return null;
		}

		internal static T GetPooled(Touch touch, int pointerId, EventModifiers modifiers, int displayIndex)
		{
			return null;
		}

		internal static T GetPooled(PenData pen, EventModifiers modifiers, int displayIndex)
		{
			return null;
		}

		internal static T GetPooled(PointerEvent pointerEvent, Vector3 position, int pointerId, float deltaTime)
		{
			return null;
		}

		internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			return null;
		}

		public static T GetPooled(IPointerEvent triggerEvent)
		{
			return null;
		}

		internal virtual IMouseEvent GetPooledCompatibilityMouseEvent()
		{
			return null;
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
	}
}
