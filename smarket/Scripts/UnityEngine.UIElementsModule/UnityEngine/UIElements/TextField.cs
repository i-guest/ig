using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class TextField : TextInputBaseField<string>
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : TextInputBaseField<string>.UxmlTraits
		{
			private static readonly UxmlStringAttributeDescription k_Value;

			private UxmlBoolAttributeDescription m_Multiline;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private class TextInput : TextInputBase
		{
			private TextField parentTextField => null;

			public bool multiline
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			protected override string StringToValue(string str)
			{
				return null;
			}
		}

		internal static readonly BindingId multilineProperty;

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		private TextInput textInput => null;

		[CreateProperty]
		public bool multiline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextField()
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public TextField(string label)
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar)
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public override void SetValueWithoutNotify(string newValue)
		{
		}

		internal override void UpdateTextFromValue()
		{
		}

		[EventInterest(new Type[] { typeof(FocusOutEvent) })]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		protected override string ValueToString(string value)
		{
			return null;
		}

		protected override string StringToValue(string str)
		{
			return null;
		}
	}
}
