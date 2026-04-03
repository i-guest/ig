using System;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public abstract class BasePopupField<TValueType, TValueChoice> : BaseField<TValueType>
	{
		private class PopupTextElement : TextElement
		{
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
			{
				return default(Vector2);
			}
		}

		internal static readonly BindingId choicesProperty;

		internal static readonly BindingId textProperty;

		internal List<TValueChoice> m_Choices;

		private TextElement m_TextElement;

		private VisualElement m_ArrowElement;

		private IVisualElementScheduledItem m_ScheduledShowMenuItem;

		internal Func<TValueChoice, string> m_FormatSelectedValueCallback;

		internal Func<TValueChoice, string> m_FormatListItemCallback;

		internal Func<AbstractGenericMenu> createMenuCallback;

		internal AbstractGenericMenu m_GenericMenu;

		internal bool m_AutoCloseMenu;

		public new static readonly string ussClassName;

		public static readonly string textUssClassName;

		public static readonly string arrowUssClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		protected TextElement textElement => null;

		[CreateProperty]
		public virtual List<TValueChoice> choices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public string text => null;

		internal abstract string GetValueToDisplay();

		internal abstract string GetListItemToDisplay(TValueType item);

		internal abstract void AddMenuItems(AbstractGenericMenu menu);

		public override void SetValueWithoutNotify(TValueType newValue)
		{
		}

		internal BasePopupField(string label)
			: base((string)null)
		{
		}

		private void OnPointerDownEvent(PointerDownEvent evt)
		{
		}

		private void OnPointerUpEvent(PointerUpEvent evt)
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

		protected override void UpdateMixedValueContent()
		{
		}
	}
}
