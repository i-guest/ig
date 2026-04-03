using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	[Obsolete("TextValueFieldTraits<TValueType, TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class TextValueFieldTraits<TValueType, TValueUxmlAttributeType> : BaseFieldTraits<TValueType, TValueUxmlAttributeType> where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		private UxmlStringAttributeDescription m_PlaceholderText;

		private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus;

		private UxmlBoolAttributeDescription m_IsReadOnly;

		private UxmlBoolAttributeDescription m_IsDelayed;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}
}
