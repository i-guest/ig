using System;

namespace UnityEngine.UIElements
{
	public class Toggle : BaseBoolField
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Toggle, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
			private UxmlStringAttributeDescription m_Text;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		[Obsolete]
		public static readonly string noTextVariantUssClassName;

		public static readonly string checkmarkUssClassName;

		public static readonly string textUssClassName;

		public static readonly string mixedValuesUssClassName;

		public Toggle()
			: base(null)
		{
		}

		public Toggle(string label)
			: base(null)
		{
		}

		protected override void InitLabel()
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}
	}
}
