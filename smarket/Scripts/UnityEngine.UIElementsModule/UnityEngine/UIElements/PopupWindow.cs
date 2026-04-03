using System;

namespace UnityEngine.UIElements
{
	public class PopupWindow : TextElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
		}

		private VisualElement m_ContentContainer;

		public new static readonly string ussClassName;

		public static readonly string contentUssClassName;

		public override VisualElement contentContainer => null;
	}
}
