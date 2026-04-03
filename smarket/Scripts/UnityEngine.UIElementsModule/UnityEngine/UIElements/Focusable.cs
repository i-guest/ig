using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class Focusable : CallbackEventHandler
	{
		internal static readonly BindingId focusableProperty;

		internal static readonly BindingId tabIndexProperty;

		internal static readonly BindingId delegatesFocusProperty;

		internal static readonly BindingId canGrabFocusProperty;

		private bool m_Focusable;

		private int m_TabIndex;

		private bool m_DelegatesFocus;

		private bool m_ExcludeFromFocusRing;

		public abstract FocusController focusController { get; }

		[CreateProperty]
		public virtual bool focusable
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
		public int tabIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool delegatesFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool excludeFromFocusRing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isEligibleToReceiveFocusFromDisabledChild { get; set; }

		[CreateProperty(ReadOnly = true)]
		public virtual bool canGrabFocus => false;

		public virtual void Focus()
		{
		}

		public virtual void Blur()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void BlurImmediately()
		{
		}

		internal Focusable GetFocusDelegate()
		{
			return null;
		}

		private static Focusable GetFirstFocusableChild(VisualElement ve)
		{
			return null;
		}
	}
}
