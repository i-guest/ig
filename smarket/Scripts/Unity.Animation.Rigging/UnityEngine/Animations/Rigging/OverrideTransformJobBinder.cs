namespace UnityEngine.Animations.Rigging
{
	public class OverrideTransformJobBinder<T> : AnimationJobBinder<OverrideTransformJob, T> where T : struct
	{
		public override OverrideTransformJob Create(Animator animator, ref T data, Component component)
		{
			return default(OverrideTransformJob);
		}

		public override void Destroy(OverrideTransformJob job)
		{
		}

		public override void Update(OverrideTransformJob job, ref T data)
		{
		}
	}
}
