using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct MultiAimConstraintData : IAnimationJobData, IMultiAimConstraintData
	{
		public enum Axis
		{
			X = 0,
			X_NEG = 1,
			Y = 2,
			Y_NEG = 3,
			Z = 4,
			Z_NEG = 5
		}

		public enum WorldUpType
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}

		internal const float k_MinAngularLimit = -180f;

		internal const float k_MaxAngularLimit = 180f;

		[SerializeField]
		private Transform m_ConstrainedObject;

		[SyncSceneToStream]
		[SerializeField]
		[WeightRange(0f, 1f)]
		private WeightedTransformArray m_SourceObjects;

		[SyncSceneToStream]
		[SerializeField]
		private Vector3 m_Offset;

		[SyncSceneToStream]
		[SerializeField]
		[Range(-180f, 180f)]
		private float m_MinLimit;

		[SyncSceneToStream]
		[SerializeField]
		[Range(-180f, 180f)]
		private float m_MaxLimit;

		[NotKeyable]
		[SerializeField]
		private Axis m_AimAxis;

		[NotKeyable]
		[SerializeField]
		private Axis m_UpAxis;

		[NotKeyable]
		[SerializeField]
		private WorldUpType m_WorldUpType;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_WorldUpObject;

		[NotKeyable]
		[SerializeField]
		private Axis m_WorldUpAxis;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainOffset;

		[NotKeyable]
		[SerializeField]
		private Vector3Bool m_ConstrainedAxes;

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

		public Vector2 limits
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Axis aimAxis
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

		public Axis upAxis
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

		public WorldUpType worldUpType
		{
			get
			{
				return default(WorldUpType);
			}
			set
			{
			}
		}

		public Axis worldUpAxis
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

		public Transform worldUpObject
		{
			get
			{
				return null;
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

		Vector3 IMultiAimConstraintData.aimAxis => default(Vector3);

		Vector3 IMultiAimConstraintData.upAxis => default(Vector3);

		int IMultiAimConstraintData.worldUpType => 0;

		Vector3 IMultiAimConstraintData.worldUpAxis => default(Vector3);

		string IMultiAimConstraintData.offsetVector3Property => null;

		string IMultiAimConstraintData.minLimitFloatProperty => null;

		string IMultiAimConstraintData.maxLimitFloatProperty => null;

		string IMultiAimConstraintData.sourceObjectsProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}

		private static Vector3 Convert(Axis axis)
		{
			return default(Vector3);
		}
	}
}
