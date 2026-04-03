namespace UnityEngine.Animations.Rigging
{
	public class BlendConstraintJobBinder<T> : AnimationJobBinder<BlendConstraintJob, T> where T : struct
	{
		public override BlendConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(BlendConstraintJob);
		}

		public override void Destroy(BlendConstraintJob job)
		{
		}
	}
}
