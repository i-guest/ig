using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct TwistChainConstraintData : IAnimationJobData, ITwistChainConstraintData
	{
		[SerializeField]
		private Transform m_Root;

		[SerializeField]
		private Transform m_Tip;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_RootTarget;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_TipTarget;

		[SerializeField]
		private AnimationCurve m_Curve;

		public Transform root
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform tip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform rootTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform tipTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AnimationCurve curve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
