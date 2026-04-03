namespace UnityEngine.Animations.Rigging
{
	public class TwoBoneIKConstraintJobBinder<T> : AnimationJobBinder<TwoBoneIKConstraintJob, T> where T : struct
	{
		public override TwoBoneIKConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(TwoBoneIKConstraintJob);
		}

		public override void Destroy(TwoBoneIKConstraintJob job)
		{
		}
	}
}
