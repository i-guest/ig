namespace UnityEngine.Animations.Rigging
{
	public class MultiReferentialConstraintJobBinder<T> : AnimationJobBinder<MultiReferentialConstraintJob, T> where T : struct
	{
		public override MultiReferentialConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(MultiReferentialConstraintJob);
		}

		public override void Destroy(MultiReferentialConstraintJob job)
		{
		}
	}
}
