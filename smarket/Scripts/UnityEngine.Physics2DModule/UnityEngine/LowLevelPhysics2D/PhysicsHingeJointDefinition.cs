using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsHingeJointDefinition
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
		private bool m_EnableSpring;

		[SerializeField]
		private float m_SpringTargetAngle;

		[SerializeField]
		[Min(0f)]
		private float m_SpringFrequency;

		[SerializeField]
		[Min(0f)]
		private float m_SpringDamping;

		[SerializeField]
		private bool m_EnableMotor;

		[SerializeField]
		private float m_MotorSpeed;

		[Min(0f)]
		[SerializeField]
		private float m_MaxMotorTorque;

		[SerializeField]
		private bool m_EnableLimit;

		[Range(-178f, 178f)]
		[SerializeField]
		private float m_LowerAngleLimit;

		[SerializeField]
		[Range(-178f, 178f)]
		private float m_UpperAngleLimit;

		[SerializeField]
		[Min(0f)]
		private float m_ForceThreshold;

		[SerializeField]
		[Min(0f)]
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

		public static PhysicsHingeJointDefinition defaultDefinition => default(PhysicsHingeJointDefinition);

		public PhysicsHingeJointDefinition()
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_EnableSpring = false;
			m_SpringTargetAngle = 0f;
			m_SpringFrequency = 0f;
			m_SpringDamping = 0f;
			m_EnableMotor = false;
			m_MotorSpeed = 0f;
			m_MaxMotorTorque = 0f;
			m_EnableLimit = false;
			m_LowerAngleLimit = 0f;
			m_UpperAngleLimit = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}

		public PhysicsHingeJointDefinition(bool useSettings)
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_EnableSpring = false;
			m_SpringTargetAngle = 0f;
			m_SpringFrequency = 0f;
			m_SpringDamping = 0f;
			m_EnableMotor = false;
			m_MotorSpeed = 0f;
			m_MaxMotorTorque = 0f;
			m_EnableLimit = false;
			m_LowerAngleLimit = 0f;
			m_UpperAngleLimit = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}
	}
}
