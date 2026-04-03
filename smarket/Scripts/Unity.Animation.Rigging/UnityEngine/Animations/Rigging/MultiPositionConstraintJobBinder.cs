namespace UnityEngine.Animations.Rigging
{
	public class MultiPositionConstraintJobBinder<T> : AnimationJobBinder<MultiPositionConstraintJob, T> where T : struct
	{
		public override MultiPositionConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(MultiPositionConstraintJob);
		}

		public override void Destroy(MultiPositionConstraintJob job)
		{
		}
	}
}
