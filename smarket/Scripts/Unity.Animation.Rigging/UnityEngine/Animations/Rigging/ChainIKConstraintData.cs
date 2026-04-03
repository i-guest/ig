using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct ChainIKConstraintData : IAnimationJobData, IChainIKConstraintData
	{
		internal const int k_MinIterations = 1;

		internal const int k_MaxIterations = 50;

		internal const float k_MinTolerance = 0f;

		internal const float k_MaxTolerance = 0.01f;

		[SerializeField]
		private Transform m_Root;

		[SerializeField]
		private Transform m_Tip;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_Target;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_ChainRotationWeight;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_TipRotationWeight;

		[NotKeyable]
		[SerializeField]
		[Range(1f, 50f)]
		private int m_MaxIterations;

		[NotKeyable]
		[SerializeField]
		[Range(0f, 0.01f)]
		private float m_Tolerance;

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

		public float chainRotationWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float tipRotationWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int maxIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float tolerance
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

		string IChainIKConstraintData.chainRotationWeightFloatProperty => null;

		string IChainIKConstraintData.tipRotationWeightFloatProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
