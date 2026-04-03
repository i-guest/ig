using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class MinMaxSlider : BaseField<Vector2>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
			private UxmlFloatAttributeDescription m_MinValue;

			private UxmlFloatAttributeDescription m_MaxValue;

			private UxmlFloatAttributeDescription m_LowLimit;

			private UxmlFloatAttributeDescription m_HighLimit;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private enum DragState
		{
			MinThumb = 0,
			MaxThumb = 1,
			MiddleThumb = 2,
			NoThumb = 3
		}

		internal static readonly BindingId minValueProperty;

		internal static readonly BindingId maxValueProperty;

		internal static readonly BindingId rangeProperty;

		internal static readonly BindingId lowLimitProperty;

		internal static readonly BindingId highLimitProperty;

		private Vector2 m_DragElementStartPos;

		private Vector2 m_ValueStartPos;

		private DragState m_DragState;

		private float m_MinLimit;

		private float m_MaxLimit;

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		public static readonly string trackerUssClassName;

		public static readonly string draggerUssClassName;

		public static readonly string minThumbUssClassName;

		public static readonly string maxThumbUssClassName;

		public static readonly string movableUssClassName;

		internal VisualElement dragElement { get; private set; }

		internal VisualElement dragMinThumb { get; private set; }

		internal VisualElement dragMaxThumb { get; private set; }

		internal ClampedDragger<float> clampedDragger { get; private set; }

		[CreateProperty]
		public float minValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreateProperty]
		public float maxValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override Vector2 value
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public float range => 0f;

		[CreateProperty]
		public float lowLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreateProperty]
		public float highLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void SetValueWithoutNotify(Vector2 newValue)
		{
		}

		public MinMaxSlider()
			: base((string)null)
		{
		}

		public MinMaxSlider(string label, float minValue = 0f, float maxValue = 10f, float minLimit = -3.4028235E+38f, float maxLimit = 3.4028235E+38f)
			: base((string)null)
		{
		}

		private Vector2 ClampValues(Vector2 valueToClamp)
		{
			return default(Vector2);
		}

		private void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
		}

		private void UpdateDragElementPosition()
		{
		}

		internal float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return 0f;
		}

		internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return 0f;
		}

		private float ComputeValueFromPosition(float positionToConvert)
		{
			return 0f;
		}

		[EventInterest(new Type[] { typeof(GeometryChangedEvent) })]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		private DragState GetNavigationState()
		{
			return default(DragState);
		}

		private void SetNavigationState(DragState newState)
		{
		}

		private void OnFocusIn(FocusInEvent evt)
		{
		}

		private void OnBlur(BlurEvent evt)
		{
		}

		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		private void OnNavigationMove(NavigationMoveEvent evt)
		{
		}

		private void ComputeValueFromKey(bool leftDirection, bool isShift, DragState moveState)
		{
		}

		private void SetSliderValueFromDrag()
		{
		}

		private void SetSliderValueFromClick()
		{
		}

		private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}

		internal override void RegisterEditingCallbacks()
		{
		}

		internal override void UnregisterEditingCallbacks()
		{
		}
	}
}
