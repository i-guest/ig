namespace UnityEngine.Animations.Rigging
{
	public class MultiAimConstraintJobBinder<T> : AnimationJobBinder<MultiAimConstraintJob, T> where T : struct
	{
		public override MultiAimConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(MultiAimConstraintJob);
		}

		public override void Destroy(MultiAimConstraintJob job)
		{
		}
	}
}
