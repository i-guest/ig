namespace UnityEngine.Animations.Rigging
{
	public struct BoolProperty : IAnimatableProperty<bool>
	{
		public PropertyStreamHandle value;

		public static BoolProperty Bind(Animator animator, Component component, string name)
		{
			return default(BoolProperty);
		}

		public static BoolProperty BindCustom(Animator animator, string property)
		{
			return default(BoolProperty);
		}

		public bool Get(AnimationStream stream)
		{
			return false;
		}

		public void Set(AnimationStream stream, bool v)
		{
		}
	}
}
