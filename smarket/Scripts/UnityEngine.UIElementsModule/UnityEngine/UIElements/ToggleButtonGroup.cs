using System;
using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[UxmlElement(null, new Type[] { typeof(Button) })]
	public class ToggleButtonGroup : BaseField<ToggleButtonGroupState>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<ToggleButtonGroup, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseField<ToggleButtonGroupState>.UxmlTraits
		{
			private UxmlBoolAttributeDescription m_IsMultipleSelection;

			private UxmlBoolAttributeDescription m_AllowEmptySelection;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private class ButtonGroupContainer : VisualElement
		{
			private readonly ToggleButtonGroup m_Group;

			public ButtonGroupContainer(ToggleButtonGroup group)
			{
			}

			internal override void OnChildAdded(VisualElement ve)
			{
			}

			internal override void OnChildRemoved(VisualElement ve)
			{
			}
		}

		private static readonly string k_MaxToggleButtonGroupMessage;

		internal static readonly BindingId isMultipleSelectionProperty;

		internal static readonly BindingId allowEmptySelectionProperty;

		public new static readonly string ussClassName;

		public static readonly string containerUssClassName;

		public static readonly string buttonGroupClassName;

		public static readonly string buttonClassName;

		public static readonly string buttonLeftClassName;

		public static readonly string buttonMidClassName;

		public static readonly string buttonRightClassName;

		public static readonly string buttonStandaloneClassName;

		public static readonly string emptyStateLabelClassName;

		private VisualElement m_ButtonGroupContainer;

		private List<Button> m_Buttons;

		private VisualElement m_EmptyLabel;

		private bool m_IsMultipleSelection;

		private bool m_AllowEmptySelection;

		[CreateProperty]
		public bool isMultipleSelection
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
		public bool allowEmptySelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override VisualElement contentContainer => null;

		public ToggleButtonGroup()
			: base((string)null)
		{
		}

		public ToggleButtonGroup(string label)
			: base((string)null)
		{
		}

		public ToggleButtonGroup(string label, ToggleButtonGroupState toggleButtonGroupState)
			: base((string)null)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}

		public override void SetValueWithoutNotify(ToggleButtonGroupState newValue)
		{
		}

		private void OnButtonGroupContainerElementAdded(VisualElement ve)
		{
		}

		private void OnButtonGroupContainerElementRemoved(VisualElement ve)
		{
		}

		private void UpdateButtonStates(ToggleButtonGroupState options)
		{
		}

		private void OnOptionChange(EventBase evt)
		{
		}

		private void UpdateButtonsStyling()
		{
		}
	}
}
