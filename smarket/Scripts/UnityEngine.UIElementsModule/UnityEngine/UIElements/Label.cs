using System;

namespace UnityEngine.UIElements
{
	public class Label : TextElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Label, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
		}

		public new static readonly string ussClassName;

		public Label()
		{
		}

		public Label(string text)
		{
		}
	}
}
