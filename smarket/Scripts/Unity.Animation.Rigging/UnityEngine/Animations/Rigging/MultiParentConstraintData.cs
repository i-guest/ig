using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct MultiParentConstraintData : IAnimationJobData, IMultiParentConstraintData
	{
		[SerializeField]
		private Transform m_ConstrainedObject;

		[SerializeField]
		[SyncSceneToStream]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects;

		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedPositionAxes;

		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedRotationAxes;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainPositionOffset;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainRotationOffset;

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

		public WeightedTransformArray sourceObjects
		{
			get
			{
				return default(WeightedTransformArray);
			}
			set
			{
			}
		}

		public bool maintainPositionOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool maintainRotationOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedPositionXAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedPositionYAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedPositionZAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedRotationXAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedRotationYAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedRotationZAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		string IMultiParentConstraintData.sourceObjectsProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
