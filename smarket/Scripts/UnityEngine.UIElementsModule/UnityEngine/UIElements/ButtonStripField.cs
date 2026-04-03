using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class ButtonStripField : BaseField<int>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseField<int>.UxmlTraits
		{
		}

		private readonly List<Button> m_Buttons;

		public ButtonStripField()
			: base((string)null)
		{
		}

		public override void SetValueWithoutNotify(int newValue)
		{
		}

		private void RefreshButtonsState()
		{
		}
	}
}
