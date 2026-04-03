namespace UnityEngine.Animations.Rigging
{
	public struct IntProperty : IAnimatableProperty<int>
	{
		public PropertyStreamHandle value;

		public static IntProperty Bind(Animator animator, Component component, string name)
		{
			return default(IntProperty);
		}

		public static IntProperty BindCustom(Animator animator, string property)
		{
			return default(IntProperty);
		}

		public int Get(AnimationStream stream)
		{
			return 0;
		}

		public void Set(AnimationStream stream, int v)
		{
		}
	}
}
