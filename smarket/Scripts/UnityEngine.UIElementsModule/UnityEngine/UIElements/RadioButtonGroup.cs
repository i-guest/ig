using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	public class RadioButtonGroup : BaseField<int>, IGroupBox
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
			private UxmlStringAttributeDescription m_Choices;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_choices_003Ed__17 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public RadioButtonGroup _003C_003E4__this;

			private PooledObject<List<RadioButton>> _003C__003E5__1;

			private List<RadioButton> _003CradioButtons_003E5__2;

			private List<RadioButton>.Enumerator _003C_003Es__3;

			private RadioButton _003Cbutton_003E5__4;

			string IEnumerator<string>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_choices_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal static readonly BindingId choicesProperty;

		public new static readonly string ussClassName;

		public static readonly string containerUssClassName;

		internal static readonly string containerName;

		internal static readonly string choicesContainerName;

		private VisualElement m_ChoiceRadioButtonContainer;

		private VisualElement m_ContentContainer;

		private UQueryBuilder<RadioButton> m_GetAllRadioButtonsQuery;

		private readonly List<RadioButton> m_RegisteredRadioButtons;

		private RadioButton m_SelectedRadioButton;

		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

		private bool m_UpdatingButtons;

		private List<string> m_Choices;

		[CreateProperty]
		public IEnumerable<string> choices
		{
			[IteratorStateMachine(typeof(_003Cget_choices_003Ed__17))]
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<string> choicesList
		{
			set
			{
			}
		}

		public override VisualElement contentContainer => null;

		private void RebuildRadioButtonsFromChoices()
		{
		}

		public RadioButtonGroup()
			: base((string)null)
		{
		}

		public RadioButtonGroup(string label, List<string> radioButtonChoices = null)
			: base((string)null)
		{
		}

		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
		{
		}

		public override void SetValueWithoutNotify(int newValue)
		{
		}

		private void GetAllRadioButtons(List<RadioButton> radioButtons)
		{
		}

		private void UpdateRadioButtons(bool notify)
		{
		}

		private void ScheduleRadioButtons()
		{
		}

		private void RegisterRadioButton(RadioButton radioButton)
		{
		}

		private void UnregisterRadioButton(RadioButton radioButton)
		{
		}

		void IGroupBox.OnOptionAdded(IGroupBoxOption option)
		{
		}

		void IGroupBox.OnOptionRemoved(IGroupBoxOption option)
		{
		}
	}
}
