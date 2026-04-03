namespace UnityEngine.Animations.Rigging
{
	public class TwistChainConstraintJobBinder<T> : AnimationJobBinder<TwistChainConstraintJob, T> where T : struct
	{
		public override TwistChainConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(TwistChainConstraintJob);
		}

		public override void Destroy(TwistChainConstraintJob job)
		{
		}
	}
}
