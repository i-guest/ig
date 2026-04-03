using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct BlendConstraintData : IAnimationJobData, IBlendConstraintData
	{
		[SerializeField]
		private Transform m_ConstrainedObject;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_SourceA;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_SourceB;

		[SyncSceneToStream]
		[SerializeField]
		private bool m_BlendPosition;

		[SyncSceneToStream]
		[SerializeField]
		private bool m_BlendRotation;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_PositionWeight;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_RotationWeight;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainPositionOffsets;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainRotationOffsets;

		public Transform constrainedObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform sourceObjectA
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform sourceObjectB
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool blendPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool blendRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float positionWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotationWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool maintainPositionOffsets
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool maintainRotationOffsets
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		string IBlendConstraintData.blendPositionBoolProperty => null;

		string IBlendConstraintData.blendRotationBoolProperty => null;

		string IBlendConstraintData.positionWeightFloatProperty => null;

		string IBlendConstraintData.rotationWeightFloatProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
