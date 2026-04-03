namespace UnityEngine.Animations.Rigging
{
	internal class RigSyncSceneToStreamJobBinder<T> : AnimationJobBinder<RigSyncSceneToStreamJob, T> where T : struct
	{
		public override RigSyncSceneToStreamJob Create(Animator animator, ref T data, Component component)
		{
			return default(RigSyncSceneToStreamJob);
		}

		public override void Destroy(RigSyncSceneToStreamJob job)
		{
		}

		public override void Update(RigSyncSceneToStreamJob job, ref T data)
		{
		}
	}
}
