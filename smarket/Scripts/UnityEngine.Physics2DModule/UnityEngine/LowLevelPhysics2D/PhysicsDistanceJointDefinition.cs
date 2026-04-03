using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsDistanceJointDefinition
	{
		[SerializeField]
		private PhysicsBody m_BodyA;

		[SerializeField]
		private PhysicsBody m_BodyB;

		[SerializeField]
		private PhysicsTransform m_LocalAnchorA;

		[SerializeField]
		private PhysicsTransform m_LocalAnchorB;

		[Min(1E-45f)]
		[SerializeField]
		private float m_Distance;

		[SerializeField]
		private bool m_EnableSpring;

		[SerializeField]
		[Min(0f)]
		private float m_SpringFrequency;

		[Min(0f)]
		[SerializeField]
		private float m_SpringDamping;

		[SerializeField]
		private float m_SpringLowerForce;

		[SerializeField]
		private float m_SpringUpperForce;

		[SerializeField]
		private bool m_EnableMotor;

		[SerializeField]
		private float m_MotorSpeed;

		[SerializeField]
		private float m_MaxMotorForce;

		[SerializeField]
		private bool m_EnableLimit;

		[SerializeField]
		[Min(0f)]
		private float m_MinDistanceLimit;

		[Min(0f)]
		[SerializeField]
		private float m_MaxDistanceLimit;

		[Min(0f)]
		[SerializeField]
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

		[Range(0.001f, 10f)]
		[SerializeField]
		private float m_DrawScale;

		[SerializeField]
		private bool m_CollideConnected;

		public static PhysicsDistanceJointDefinition defaultDefinition => default(PhysicsDistanceJointDefinition);

		public PhysicsDistanceJointDefinition()
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_Distance = 0f;
			m_EnableSpring = false;
			m_SpringFrequency = 0f;
			m_SpringDamping = 0f;
			m_SpringLowerForce = 0f;
			m_SpringUpperForce = 0f;
			m_EnableMotor = false;
			m_MotorSpeed = 0f;
			m_MaxMotorForce = 0f;
			m_EnableLimit = false;
			m_MinDistanceLimit = 0f;
			m_MaxDistanceLimit = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}

		public PhysicsDistanceJointDefinition(bool useSettings)
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_Distance = 0f;
			m_EnableSpring = false;
			m_SpringFrequency = 0f;
			m_SpringDamping = 0f;
			m_SpringLowerForce = 0f;
			m_SpringUpperForce = 0f;
			m_EnableMotor = false;
			m_MotorSpeed = 0f;
			m_MaxMotorForce = 0f;
			m_EnableLimit = false;
			m_MinDistanceLimit = 0f;
			m_MaxDistanceLimit = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}
	}
}
