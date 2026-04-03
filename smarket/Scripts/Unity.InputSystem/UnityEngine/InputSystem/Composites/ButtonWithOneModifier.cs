using System;
using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	[DesignTimeVisible(false)]
	[DisplayStringFormat("{modifier}+{button}")]
	public class ButtonWithOneModifier : InputBindingComposite<float>
	{
		public enum ModifiersOrder
		{
			Default = 0,
			Ordered = 1,
			Unordered = 2
		}

		[InputControl(layout = "Button")]
		public int modifier;

		[InputControl(layout = "Button")]
		public int button;

		[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
		[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
		public bool overrideModifiersNeedToBePressedFirst;

		[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
		public ModifiersOrder modifiersOrder;

		public override float ReadValue(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		private bool ModifierIsPressed(ref InputBindingCompositeContext context)
		{
			return false;
		}

		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		protected override void FinishSetup(ref InputBindingCompositeContext context)
		{
		}
	}
}
