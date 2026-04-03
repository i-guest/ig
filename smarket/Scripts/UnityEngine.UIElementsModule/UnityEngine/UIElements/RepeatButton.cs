using System;

namespace UnityEngine.UIElements
{
	public class RepeatButton : TextElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			private UxmlLongAttributeDescription m_Delay;

			private UxmlLongAttributeDescription m_Interval;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private Clickable m_Clickable;

		private bool m_AcceptClicksIfDisabled;

		public new static readonly string ussClassName;

		internal bool acceptClicksIfDisabled
		{
			set
			{
			}
		}

		public RepeatButton()
		{
		}

		public RepeatButton(Action clickEvent, long delay, long interval)
		{
		}

		public void SetAction(Action clickEvent, long delay, long interval)
		{
		}

		internal void AddAction(Action clickEvent)
		{
		}
	}
}
