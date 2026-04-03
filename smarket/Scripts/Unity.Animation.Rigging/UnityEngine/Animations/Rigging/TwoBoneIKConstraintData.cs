using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct TwoBoneIKConstraintData : IAnimationJobData, ITwoBoneIKConstraintData
	{
		[SerializeField]
		private Transform m_Root;

		[SerializeField]
		private Transform m_Mid;

		[SerializeField]
		private Transform m_Tip;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_Target;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_Hint;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_TargetPositionWeight;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_TargetRotationWeight;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_HintWeight;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetPositionOffset;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainTargetRotationOffset;

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

		public Transform mid
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

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform hint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float targetPositionWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float targetRotationWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float hintWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool maintainTargetPositionOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool maintainTargetRotationOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		string ITwoBoneIKConstraintData.targetPositionWeightFloatProperty => null;

		string ITwoBoneIKConstraintData.targetRotationWeightFloatProperty => null;

		string ITwoBoneIKConstraintData.hintWeightFloatProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
