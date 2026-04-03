namespace UnityEngine.Animations.Rigging
{
	public class RigConstraint<TJob, TData, TBinder> : MonoBehaviour, IRigConstraint where TJob : struct where TData : struct where TBinder : new()
	{
		[SerializeField]
		[Range(0f, 1f)]
		protected float m_Weight;

		[SerializeField]
		[ExpandChildren]
		protected TData m_Data;

		private static readonly TBinder s_Binder;

		public ref TData data
		{
			get
			{
				throw null;
			}
		}

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

		IAnimationJobBinder IRigConstraint.binder => null;

		IAnimationJobData IRigConstraint.data => null;

		Component IRigConstraint.component => null;

		public void Reset()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		protected virtual void OnValidate()
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
	}
}
