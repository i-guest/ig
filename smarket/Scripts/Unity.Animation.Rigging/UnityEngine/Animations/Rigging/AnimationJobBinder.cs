using UnityEngine.Playables;

namespace UnityEngine.Animations.Rigging
{
	public abstract class AnimationJobBinder<TJob, TData> : IAnimationJobBinder where TJob : struct where TData : struct
	{
		public abstract TJob Create(Animator animator, ref TData data, Component component);

		public abstract void Destroy(TJob job);

		public virtual void Update(TJob job, ref TData data)
		{
		}

		IAnimationJob IAnimationJobBinder.Create(Animator animator, IAnimationJobData data, Component component)
		{
			return null;
		}

		void IAnimationJobBinder.Destroy(IAnimationJob job)
		{
		}

		void IAnimationJobBinder.Update(IAnimationJob job, IAnimationJobData data)
		{
		}

		AnimationScriptPlayable IAnimationJobBinder.CreatePlayable(PlayableGraph graph, IAnimationJob job)
		{
			return default(AnimationScriptPlayable);
		}
	}
}
