using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct DampedTransformData : IAnimationJobData, IDampedTransformData
	{
		[SerializeField]
		private Transform m_ConstrainedObject;

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_Source;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_DampPosition;

		[SyncSceneToStream]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_DampRotation;

		[NotKeyable]
		[SerializeField]
		private bool m_MaintainAim;

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

		public float dampPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dampRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool maintainAim
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		string IDampedTransformData.dampPositionFloatProperty => null;

		string IDampedTransformData.dampRotationFloatProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
