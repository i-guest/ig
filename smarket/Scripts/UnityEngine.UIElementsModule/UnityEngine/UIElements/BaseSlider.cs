using System;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public abstract class BaseSlider<TValueType> : BaseField<TValueType>, IValueField<TValueType> where TValueType : IComparable<TValueType>
	{
		[Obsolete("UxmlTraits<TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits<TValueUxmlAttributeType> : BaseFieldTraits<TValueType, TValueUxmlAttributeType> where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
		{
		}

		internal enum SliderKey
		{
			None = 0,
			Lowest = 1,
			LowerPage = 2,
			Lower = 3,
			Higher = 4,
			HigherPage = 5,
			Highest = 6
		}

		internal static readonly BindingId lowValueProperty;

		internal static readonly BindingId highValueProperty;

		internal static readonly BindingId rangeProperty;

		internal static readonly BindingId pageSizeProperty;

		internal static readonly BindingId showInputFieldProperty;

		internal static readonly BindingId directionProperty;

		internal static readonly BindingId invertedProperty;

		internal static readonly BindingId fillProperty;

		private float m_AdjustedPageSizeFromClick;

		private bool m_IsEditingTextField;

		private bool m_Fill;

		[SerializeField]
		[DontCreateProperty]
		private TValueType m_LowValue;

		[DontCreateProperty]
		[SerializeField]
		private TValueType m_HighValue;

		private float m_PageSize;

		private bool m_ShowInputField;

		private Rect m_DragElementStartPos;

		private SliderDirection m_Direction;

		private bool m_Inverted;

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		public static readonly string horizontalVariantUssClassName;

		public static readonly string verticalVariantUssClassName;

		public static readonly string dragContainerUssClassName;

		public static readonly string trackerUssClassName;

		public static readonly string draggerUssClassName;

		public static readonly string draggerBorderUssClassName;

		public static readonly string textFieldClassName;

		public static readonly string fillUssClassName;

		public static readonly string movableUssClassName;

		internal VisualElement dragContainer { get; private set; }

		internal VisualElement dragElement { get; private set; }

		internal VisualElement trackElement { get; private set; }

		internal VisualElement dragBorderElement { get; private set; }

		internal TextField inputTextField { get; private set; }

		internal VisualElement fillElement { get; private set; }

		private protected override bool canSwitchToMixedValue => false;

		[CreateProperty]
		public TValueType lowValue
		{
			get
			{
				return default(TValueType);
			}
			set
			{
			}
		}

		[CreateProperty]
		public TValueType highValue
		{
			get
			{
				return default(TValueType);
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public TValueType range => default(TValueType);

		[CreateProperty]
		public virtual float pageSize
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
		public virtual bool showInputField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool fill
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool clamped { get; set; }

		internal ClampedDragger<TValueType> clampedDragger { get; private set; }

		public override TValueType value
		{
			get
			{
				return default(TValueType);
			}
			set
			{
			}
		}

		[CreateProperty]
		public SliderDirection direction
		{
			get
			{
				return default(SliderDirection);
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool inverted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal event Action<TValueType> onSetValueWithoutNotify
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

		internal void SetHighValueWithoutNotify(TValueType newHighValue)
		{
		}

		private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound)
		{
			return default(TValueType);
		}

		private TValueType GetClampedValue(TValueType newValue)
		{
			return default(TValueType);
		}

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue)
		{
		}

		void IValueField<TValueType>.StartDragging()
		{
		}

		void IValueField<TValueType>.StopDragging()
		{
		}

		public override void SetValueWithoutNotify(TValueType newValue)
		{
		}

		internal BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
			: base((string)null)
		{
		}

		protected internal static float GetClosestPowerOfTen(float positiveNumber)
		{
			return 0f;
		}

		protected internal static float RoundToMultipleOf(float value, float roundingValue)
		{
			return 0f;
		}

		private void ClampValue()
		{
		}

		internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);

		internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);

		internal abstract TValueType SliderRange();

		internal abstract TValueType ParseStringToValue(string previousValue, string newValue);

		internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift);

		private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant)
		{
			return default(TValueType);
		}

		private void SetSliderValueFromDrag()
		{
		}

		private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos)
		{
		}

		private void SetSliderValueFromClick()
		{
		}

		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		private void OnNavigationMove(NavigationMoveEvent evt)
		{
		}

		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
		}

		public void AdjustDragElement(float factor)
		{
		}

		private void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		private bool SameValues(float a, float b, float epsilon)
		{
			return false;
		}

		private void UpdateDragElementPosition()
		{
		}

		private void UpdateFill(float normalizedValue)
		{
		}

		[EventInterest(new Type[] { typeof(GeometryChangedEvent) })]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", false)]
		[EventInterest(EventInterestOptions.Inherit)]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		private void UpdateTextFieldVisibility()
		{
		}

		private void UpdateTextFieldValue()
		{
		}

		private void OnFocusIn(FocusInEvent evt)
		{
		}

		private void OnFocusOut(FocusOutEvent evt)
		{
		}

		private void OnTextFieldFocusIn(FocusInEvent evt)
		{
		}

		private void OnTextFieldFocusOut(FocusOutEvent evt)
		{
		}

		private void OnTextFieldValueChange(ChangeEvent<string> evt)
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
