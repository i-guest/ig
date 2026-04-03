namespace UnityEngine.Animations.Rigging
{
	public class TwistCorrectionJobBinder<T> : AnimationJobBinder<TwistCorrectionJob, T> where T : struct
	{
		public override TwistCorrectionJob Create(Animator animator, ref T data, Component component)
		{
			return default(TwistCorrectionJob);
		}

		public override void Destroy(TwistCorrectionJob job)
		{
		}
	}
}
