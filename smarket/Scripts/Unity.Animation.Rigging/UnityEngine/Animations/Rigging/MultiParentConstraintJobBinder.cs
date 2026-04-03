namespace UnityEngine.Animations.Rigging
{
	public class MultiParentConstraintJobBinder<T> : AnimationJobBinder<MultiParentConstraintJob, T> where T : struct
	{
		public override MultiParentConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(MultiParentConstraintJob);
		}

		public override void Destroy(MultiParentConstraintJob job)
		{
		}
	}
}
