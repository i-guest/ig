using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct OverrideTransformData : IAnimationJobData, IOverrideTransformData
	{
		[Serializable]
		public enum Space
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}

		[SerializeField]
		private Transform m_ConstrainedObject;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_OverrideSource;

		[SyncSceneToStream]
		[SerializeField]
		private Vector3 m_OverridePosition;

		[SyncSceneToStream]
		[SerializeField]
		private Vector3 m_OverrideRotation;

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
		private Space m_Space;

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

		public Transform sourceObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Space space
		{
			get
			{
				return default(Space);
			}
			set
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 rotation
		{
			get
			{
				return default(Vector3);
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

		int IOverrideTransformData.space => 0;

		string IOverrideTransformData.positionWeightFloatProperty => null;

		string IOverrideTransformData.rotationWeightFloatProperty => null;

		string IOverrideTransformData.positionVector3Property => null;

		string IOverrideTransformData.rotationVector3Property => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
