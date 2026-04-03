using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(displayName = "Hinge Angle")]
	public class HingeAngle : Sensor
	{
		public AxisControl angle { get; protected set; }

		public static HingeAngle current { get; private set; }

		public override void MakeCurrent()
		{
		}

		protected override void OnRemoved()
		{
		}

		protected override void FinishSetup()
		{
		}
	}
}
