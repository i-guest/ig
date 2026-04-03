using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsRelativeJointDefinition
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
		private Vector2 m_LinearVelocity;

		[SerializeField]
		private float m_AngularVelocity;

		[Min(0f)]
		[SerializeField]
		private float m_MaxForce;

		[SerializeField]
		[Min(0f)]
		private float m_MaxTorque;

		[SerializeField]
		[Min(0f)]
		private float m_SpringLinearFrequency;

		[SerializeField]
		[Min(0f)]
		private float m_SpringAngularFrequency;

		[SerializeField]
		[Min(0f)]
		private float m_SpringLinearDamping;

		[Min(0f)]
		[SerializeField]
		private float m_SpringAngularDamping;

		[Min(0f)]
		[SerializeField]
		private float m_SpringMaxForce;

		[Min(0f)]
		[SerializeField]
		private float m_SpringMaxTorque;

		[Min(0f)]
		[SerializeField]
		private float m_ForceThreshold;

		[Min(0f)]
		[SerializeField]
		private float m_TorqueThreshold;

		[Range(0f, 1000f)]
		[SerializeField]
		private float m_TuningFrequency;

		[SerializeField]
		[Range(0f, 10f)]
		private float m_TuningDamping;

		[SerializeField]
		[Range(0.001f, 10f)]
		private float m_DrawScale;

		[SerializeField]
		private bool m_CollideConnected;

		public static PhysicsRelativeJointDefinition defaultDefinition => default(PhysicsRelativeJointDefinition);

		public PhysicsRelativeJointDefinition()
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_LinearVelocity = default(Vector2);
			m_AngularVelocity = 0f;
			m_MaxForce = 0f;
			m_MaxTorque = 0f;
			m_SpringLinearFrequency = 0f;
			m_SpringAngularFrequency = 0f;
			m_SpringLinearDamping = 0f;
			m_SpringAngularDamping = 0f;
			m_SpringMaxForce = 0f;
			m_SpringMaxTorque = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}

		public PhysicsRelativeJointDefinition(bool useSettings)
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_LinearVelocity = default(Vector2);
			m_AngularVelocity = 0f;
			m_MaxForce = 0f;
			m_MaxTorque = 0f;
			m_SpringLinearFrequency = 0f;
			m_SpringAngularFrequency = 0f;
			m_SpringLinearDamping = 0f;
			m_SpringAngularDamping = 0f;
			m_SpringMaxForce = 0f;
			m_SpringMaxTorque = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}
	}
}
