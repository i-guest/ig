namespace UnityEngine.Animations.Rigging
{
	public struct Vector3IntProperty : IAnimatableProperty<Vector3Int>
	{
		public PropertyStreamHandle x;

		public PropertyStreamHandle y;

		public PropertyStreamHandle z;

		public static Vector3IntProperty Bind(Animator animator, Component component, string name)
		{
			return default(Vector3IntProperty);
		}

		public static Vector3IntProperty BindCustom(Animator animator, string name)
		{
			return default(Vector3IntProperty);
		}

		public Vector3Int Get(AnimationStream stream)
		{
			return default(Vector3Int);
		}

		public void Set(AnimationStream stream, Vector3Int value)
		{
		}
	}
}
