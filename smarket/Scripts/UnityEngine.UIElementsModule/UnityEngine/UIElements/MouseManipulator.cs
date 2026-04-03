using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public abstract class MouseManipulator : Manipulator
	{
		public List<ManipulatorActivationFilter> activators { get; private set; }
	}
}
