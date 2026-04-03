using System;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public class EnumField : BaseField<Enum>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseField<Enum>.UxmlTraits
		{
			private UxmlTypeAttributeDescription<Enum> m_Type;

			private UxmlStringAttributeDescription m_Value;

			private UxmlBoolAttributeDescription m_IncludeObsoleteValues;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId textProperty;

		private Type m_EnumType;

		private bool m_IncludeObsoleteValues;

		private TextElement m_TextElement;

		private VisualElement m_ArrowElement;

		private EnumData m_EnumData;

		internal Func<AbstractGenericMenu> createMenuCallback;

		public new static readonly string ussClassName;

		public static readonly string textUssClassName;

		public static readonly string arrowUssClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool includeObsoleteValues => false;

		[CreateProperty(ReadOnly = true)]
		public string text => null;

		private void Initialize(Enum defaultValue)
		{
		}

		public EnumField()
			: base((string)null)
		{
		}

		public EnumField(string label, Enum defaultValue = null)
			: base((string)null)
		{
		}

		public void Init(Enum defaultValue)
		{
		}

		public void Init(Enum defaultValue, bool includeObsoleteValues)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void PopulateDataFromType(Type enumType)
		{
		}

		public override void SetValueWithoutNotify(Enum newValue)
		{
		}

		private void UpdateValueLabel(Enum value)
		{
		}

		private void OnPointerDownEvent(PointerDownEvent evt)
		{
		}

		private void OnPointerMoveEvent(PointerMoveEvent evt)
		{
		}

		private bool ContainsPointer(int pointerId)
		{
			return false;
		}

		private void ProcessPointerDown<T>(PointerEventBase<T> evt) where T : PointerEventBase<T>, new()
		{
		}

		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		internal void ShowMenu()
		{
		}

		private void ChangeValueFromMenu(object menuItem)
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}
	}
}
