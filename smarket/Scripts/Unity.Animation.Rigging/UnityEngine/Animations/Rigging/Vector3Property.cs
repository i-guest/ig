namespace UnityEngine.Animations.Rigging
{
	public struct Vector3Property : IAnimatableProperty<Vector3>
	{
		public PropertyStreamHandle x;

		public PropertyStreamHandle y;

		public PropertyStreamHandle z;

		public static Vector3Property Bind(Animator animator, Component component, string name)
		{
			return default(Vector3Property);
		}

		public static Vector3Property BindCustom(Animator animator, string name)
		{
			return default(Vector3Property);
		}

		public Vector3 Get(AnimationStream stream)
		{
			return default(Vector3);
		}

		public void Set(AnimationStream stream, Vector3 value)
		{
		}
	}
}
