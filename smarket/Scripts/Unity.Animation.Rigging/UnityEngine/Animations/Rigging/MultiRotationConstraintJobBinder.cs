namespace UnityEngine.Animations.Rigging
{
	public class MultiRotationConstraintJobBinder<T> : AnimationJobBinder<MultiRotationConstraintJob, T> where T : struct
	{
		public override MultiRotationConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(MultiRotationConstraintJob);
		}

		public override void Destroy(MultiRotationConstraintJob job)
		{
		}
	}
}
