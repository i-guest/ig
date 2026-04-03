namespace UnityEngine.Animations.Rigging
{
	public struct Vector3BoolProperty : IAnimatableProperty<Vector3Bool>
	{
		public PropertyStreamHandle x;

		public PropertyStreamHandle y;

		public PropertyStreamHandle z;

		public static Vector3BoolProperty Bind(Animator animator, Component component, string name)
		{
			return default(Vector3BoolProperty);
		}

		public static Vector3BoolProperty BindCustom(Animator animator, string name)
		{
			return default(Vector3BoolProperty);
		}

		public Vector3Bool Get(AnimationStream stream)
		{
			return default(Vector3Bool);
		}

		public void Set(AnimationStream stream, Vector3Bool value)
		{
		}
	}
}
