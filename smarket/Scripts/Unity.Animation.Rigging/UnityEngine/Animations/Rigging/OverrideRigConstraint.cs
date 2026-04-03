namespace UnityEngine.Animations.Rigging
{
	public class OverrideRigConstraint<TConstraint, TJob, TData, TBinder> : IRigConstraint where TJob : struct where TData : struct where TBinder : new()
	{
		[SerializeField]
		protected TConstraint m_Constraint;

		private static readonly TBinder s_Binder;

		IAnimationJobBinder IRigConstraint.binder => null;

		IAnimationJobData IRigConstraint.data => null;

		Component IRigConstraint.component => null;

		public float weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public OverrideRigConstraint(TConstraint baseConstraint)
		{
		}

		public IAnimationJob CreateJob(Animator animator)
		{
			return null;
		}

		public void DestroyJob(IAnimationJob job)
		{
		}

		public void UpdateJob(IAnimationJob job)
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
