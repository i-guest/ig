namespace UnityEngine.Animations.Rigging
{
	public struct FloatProperty : IAnimatableProperty<float>
	{
		public PropertyStreamHandle value;

		public static FloatProperty Bind(Animator animator, Component component, string name)
		{
			return default(FloatProperty);
		}

		public static FloatProperty BindCustom(Animator animator, string property)
		{
			return default(FloatProperty);
		}

		public float Get(AnimationStream stream)
		{
			return 0f;
		}

		public void Set(AnimationStream stream, float v)
		{
		}
	}
}
