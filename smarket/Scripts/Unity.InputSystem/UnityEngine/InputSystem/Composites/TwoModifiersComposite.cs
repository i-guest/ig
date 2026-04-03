using System;
using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
	[DisplayName("Binding With Two Modifiers")]
	public class TwoModifiersComposite : InputBindingComposite
	{
		public enum ModifiersOrder
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}

		[InputControl(layout = "Button")]
		public int modifier1;

		[InputControl(layout = "Button")]
		public int modifier2;

		[InputControl]
		public int binding;

		[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
		[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
		public bool overrideModifiersNeedToBePressedFirst;

		[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
		public ModifiersOrder modifiersOrder;

		private int m_ValueSizeInBytes;

		private Type m_ValueType;

		private bool m_BindingIsButton;

		public override Type valueType => null;

		public override int valueSizeInBytes => 0;

		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
		{
		}

		private bool ModifiersArePressed(ref InputBindingCompositeContext context)
		{
			return false;
		}

		protected override void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		public override object ReadValueAsObject(ref InputBindingCompositeContext context)
		{
			return null;
		}
	}
}
