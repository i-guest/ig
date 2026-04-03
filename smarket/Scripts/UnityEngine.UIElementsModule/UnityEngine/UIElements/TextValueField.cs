using System;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public abstract class TextValueField<TValueType> : TextInputBaseField<TValueType>, IValueField<TValueType>
	{
		protected abstract class TextValueInput : TextInputBase
		{
			private TextValueField<TValueType> textValueFieldParent => null;

			protected abstract string allowedCharacters { get; }

			public string formatString { get; set; }

			internal override bool AcceptCharacter(char c)
			{
				return false;
			}

			public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);

			public void StartDragging()
			{
			}

			public void StopDragging()
			{
			}

			protected abstract string ValueToString(TValueType value);

			protected override TValueType StringToValue(string str)
			{
				return default(TValueType);
			}
		}

		internal static readonly BindingId formatStringProperty;

		internal static readonly BindingId supportExpressionsProperty;

		private BaseFieldMouseDragger m_Dragger;

		private bool m_ForceUpdateDisplay;

		private bool m_SupportExpressions;

		private TextValueInput textValueInput => null;

		[CreateProperty]
		public bool supportExpressions
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
		public string formatString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected TextValueField(string label, int maxLength, TextValueInput textValueInput)
			: base((string)null, 0, '\0', (TextInputBase)null)
		{
		}

		public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);

		public void StartDragging()
		{
		}

		public void StopDragging()
		{
		}

		internal override void UpdateValueFromText()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal override void UpdateTextFromValue()
		{
		}

		private void OnIsReadOnlyChanged(bool newValue)
		{
		}

		internal virtual bool CanTryParse(string textString)
		{
			return false;
		}

		protected void AddLabelDragger<TDraggerType>()
		{
		}

		private void EnableLabelDragger(bool enable)
		{
		}

		public override void SetValueWithoutNotify(TValueType newValue)
		{
		}

		[EventInterest(new Type[]
		{
			typeof(BlurEvent),
			typeof(FocusEvent)
		})]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		internal override void RegisterEditingCallbacks()
		{
		}

		internal override void UnregisterEditingCallbacks()
		{
		}
	}
}
