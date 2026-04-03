using System;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class Scroller : VisualElement
	{
		private class ScrollerSlider : Slider
		{
			public ScrollerSlider(float start, float end, SliderDirection direction, float pageSize)
			{
			}

			internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
			{
				return 0f;
			}
		}

		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			private UxmlFloatAttributeDescription m_LowValue;

			private UxmlFloatAttributeDescription m_HighValue;

			private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

			private UxmlFloatAttributeDescription m_Value;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId valueProperty;

		internal static readonly BindingId lowValueProperty;

		internal static readonly BindingId highValueProperty;

		internal static readonly BindingId directionProperty;

		public static readonly string ussClassName;

		public static readonly string horizontalVariantUssClassName;

		public static readonly string verticalVariantUssClassName;

		public static readonly string sliderUssClassName;

		public static readonly string lowButtonUssClassName;

		public static readonly string highButtonUssClassName;

		public Slider slider { get; }

		public RepeatButton lowButton { get; }

		public RepeatButton highButton { get; }

		[CreateProperty]
		public float value
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
		public float lowValue
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
		public float highValue
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

		public event Action<float> valueChanged
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

		public Scroller()
		{
		}

		public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical)
		{
		}

		public void Adjust(float factor)
		{
		}

		private void OnSliderValueChange(ChangeEvent<float> evt)
		{
		}

		public void ScrollPageUp()
		{
		}

		public void ScrollPageDown()
		{
		}

		public void ScrollPageUp(float factor)
		{
		}

		public void ScrollPageDown(float factor)
		{
		}
	}
}
