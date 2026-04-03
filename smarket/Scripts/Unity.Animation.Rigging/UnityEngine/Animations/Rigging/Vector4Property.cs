namespace UnityEngine.Animations.Rigging
{
	public struct Vector4Property : IAnimatableProperty<Vector4>
	{
		public PropertyStreamHandle x;

		public PropertyStreamHandle y;

		public PropertyStreamHandle z;

		public PropertyStreamHandle w;

		public static Vector4Property Bind(Animator animator, Component component, string name)
		{
			return default(Vector4Property);
		}

		public static Vector4Property BindCustom(Animator animator, string name)
		{
			return default(Vector4Property);
		}

		public Vector4 Get(AnimationStream stream)
		{
			return default(Vector4);
		}

		public void Set(AnimationStream stream, Vector4 value)
		{
		}
	}
}
