using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float>
	{
		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlFloatAttributeDescription m_LowValue;

			private UxmlFloatAttributeDescription m_HighValue;

			private UxmlFloatAttributeDescription m_Value;

			private UxmlStringAttributeDescription m_Title;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId titleProperty;

		internal static readonly BindingId lowValueProperty;

		internal static readonly BindingId highValueProperty;

		internal static readonly BindingId valueProperty;

		public static readonly string ussClassName;

		public static readonly string containerUssClassName;

		public static readonly string titleUssClassName;

		public static readonly string titleContainerUssClassName;

		public static readonly string progressUssClassName;

		public static readonly string backgroundUssClassName;

		private readonly VisualElement m_Background;

		private readonly VisualElement m_Progress;

		private readonly Label m_Title;

		private float m_LowValue;

		private float m_HighValue;

		private float m_Value;

		[CreateProperty]
		public string title
		{
			get
			{
				return null;
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
		public virtual float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AbstractProgressBar()
		{
		}

		private void OnGeometryChanged(GeometryChangedEvent e)
		{
		}

		public void SetValueWithoutNotify(float newValue)
		{
		}

		private void SetProgress(float p)
		{
		}

		private float CalculateOppositeProgressWidth(float width)
		{
			return 0f;
		}
	}
}
