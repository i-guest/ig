namespace UnityEngine.Animations.Rigging
{
	public class DampedTransformJobBinder<T> : AnimationJobBinder<DampedTransformJob, T> where T : struct
	{
		public override DampedTransformJob Create(Animator animator, ref T data, Component component)
		{
			return default(DampedTransformJob);
		}

		public override void Destroy(DampedTransformJob job)
		{
		}
	}
}
