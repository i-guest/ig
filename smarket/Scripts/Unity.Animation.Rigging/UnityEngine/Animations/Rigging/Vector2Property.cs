namespace UnityEngine.Animations.Rigging
{
	public struct Vector2Property : IAnimatableProperty<Vector2>
	{
		public PropertyStreamHandle x;

		public PropertyStreamHandle y;

		public static Vector2Property Bind(Animator animator, Component component, string name)
		{
			return default(Vector2Property);
		}

		public static Vector2Property BindCustom(Animator animator, string name)
		{
			return default(Vector2Property);
		}

		public Vector2 Get(AnimationStream stream)
		{
			return default(Vector2);
		}

		public void Set(AnimationStream stream, Vector2 value)
		{
		}
	}
}
