using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct MultiPositionConstraintData : IAnimationJobData, IMultiPositionConstraintData
	{
		[SerializeField]
		private Transform m_ConstrainedObject;

		[SyncSceneToStream]
		[SerializeField]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects;

		[SyncSceneToStream]
		[SerializeField]
		private Vector3 m_Offset;

		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset;

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

		public bool maintainOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 offset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool constrainedXAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedYAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool constrainedZAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		string IMultiPositionConstraintData.offsetVector3Property => null;

		string IMultiPositionConstraintData.sourceObjectsProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
