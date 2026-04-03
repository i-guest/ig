using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsFixedJointDefinition
	{
		[SerializeField]
		private PhysicsBody m_BodyA;

		[SerializeField]
		private PhysicsBody m_BodyB;

		[SerializeField]
		private PhysicsTransform m_LocalAnchorA;

		[SerializeField]
		private PhysicsTransform m_LocalAnchorB;

		[SerializeField]
		[Min(0f)]
		private float m_LinearFrequency;

		[SerializeField]
		[Min(0f)]
		private float m_LinearDamping;

		[SerializeField]
		[Min(0f)]
		private float m_AngularFrequency;

		[Min(0f)]
		[SerializeField]
		private float m_AngularDamping;

		[SerializeField]
		[Min(0f)]
		private float m_ForceThreshold;

		[Min(0f)]
		[SerializeField]
		private float m_TorqueThreshold;

		[SerializeField]
		[Range(0f, 1000f)]
		private float m_TuningFrequency;

		[Range(0f, 10f)]
		[SerializeField]
		private float m_TuningDamping;

		[SerializeField]
		[Range(0.001f, 10f)]
		private float m_DrawScale;

		[SerializeField]
		private bool m_CollideConnected;

		public static PhysicsFixedJointDefinition defaultDefinition => default(PhysicsFixedJointDefinition);

		public PhysicsFixedJointDefinition()
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_LinearFrequency = 0f;
			m_LinearDamping = 0f;
			m_AngularFrequency = 0f;
			m_AngularDamping = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}

		public PhysicsFixedJointDefinition(bool useSettings)
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_LinearFrequency = 0f;
			m_LinearDamping = 0f;
			m_AngularFrequency = 0f;
			m_AngularDamping = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}
	}
}
