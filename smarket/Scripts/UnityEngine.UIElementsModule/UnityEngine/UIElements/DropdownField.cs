using System;

namespace UnityEngine.UIElements
{
	public class DropdownField : PopupField<string>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseField<string>.UxmlTraits
		{
			private UxmlIntAttributeDescription m_Index;

			private UxmlStringAttributeDescription m_Choices;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		public DropdownField()
			: base((string)null)
		{
		}

		public DropdownField(string label)
			: base((string)null)
		{
		}
	}
}
