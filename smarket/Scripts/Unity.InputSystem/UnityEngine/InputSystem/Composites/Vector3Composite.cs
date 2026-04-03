using System.ComponentModel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
	[DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
	public class Vector3Composite : InputBindingComposite<Vector3>
	{
		public enum Mode
		{
			Analog = 0,
			DigitalNormalized = 1,
			Digital = 2
		}

		[InputControl(layout = "Axis")]
		public int up;

		[InputControl(layout = "Axis")]
		public int down;

		[InputControl(layout = "Axis")]
		public int left;

		[InputControl(layout = "Axis")]
		public int right;

		[InputControl(layout = "Axis")]
		public int forward;

		[InputControl(layout = "Axis")]
		public int backward;

		public Mode mode;

		public override Vector3 ReadValue(ref InputBindingCompositeContext context)
		{
			return default(Vector3);
		}

		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}
	}
}
