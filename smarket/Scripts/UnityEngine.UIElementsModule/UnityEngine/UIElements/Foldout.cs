using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public class Foldout : BindableElement, INotifyValueChanged<bool>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Text;

			private UxmlBoolAttributeDescription m_Value;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId textProperty;

		internal static readonly BindingId toggleOnLabelClickProperty;

		internal static readonly BindingId valueProperty;

		private readonly Toggle m_Toggle;

		private VisualElement m_Container;

		[SerializeField]
		[DontCreateProperty]
		private bool m_Value;

		public static readonly string ussClassName;

		public static readonly string toggleUssClassName;

		public static readonly string contentUssClassName;

		public static readonly string inputUssClassName;

		public static readonly string checkmarkUssClassName;

		public static readonly string textUssClassName;

		internal static readonly string toggleInspectorUssClassName;

		internal static readonly string ussFoldoutDepthClassName;

		internal static readonly int ussFoldoutMaxDepth;

		private KeyboardNavigationManipulator m_NavigationManipulator;

		internal Toggle toggle
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		public override VisualElement contentContainer => null;

		public override bool focusable
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
		public bool toggleOnLabelClick
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
		public string text
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
		public bool value
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void SetValueWithoutNotify(bool newValue)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
		}

		private bool Apply(KeyboardNavigationOperation op)
		{
			return false;
		}

		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}
	}
}
