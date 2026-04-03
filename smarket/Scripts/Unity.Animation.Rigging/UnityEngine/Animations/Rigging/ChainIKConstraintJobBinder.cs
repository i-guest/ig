namespace UnityEngine.Animations.Rigging
{
	public class ChainIKConstraintJobBinder<T> : AnimationJobBinder<ChainIKConstraintJob, T> where T : struct
	{
		public override ChainIKConstraintJob Create(Animator animator, ref T data, Component component)
		{
			return default(ChainIKConstraintJob);
		}

		public override void Destroy(ChainIKConstraintJob job)
		{
		}

		public override void Update(ChainIKConstraintJob job, ref T data)
		{
		}
	}
}
