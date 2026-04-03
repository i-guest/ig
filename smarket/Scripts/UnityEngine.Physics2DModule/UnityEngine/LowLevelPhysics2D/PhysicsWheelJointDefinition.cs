using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsWheelJointDefinition
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

		[Min(0f)]
		[SerializeField]
		private float m_SpringFrequency;

		[SerializeField]
		[Min(0f)]
		private float m_SpringDamping;

		[SerializeField]
		private bool m_EnableMotor;

		[SerializeField]
		private float m_MotorSpeed;

		[SerializeField]
		[Min(0f)]
		private float m_MaxMotorTorque;

		[SerializeField]
		private bool m_EnableLimit;

		[SerializeField]
		private float m_LowerTranslationLimit;

		[SerializeField]
		private float m_UpperTranslationLimit;

		[Min(0f)]
		[SerializeField]
		private float m_ForceThreshold;

		[SerializeField]
		[Min(0f)]
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

		public static PhysicsWheelJointDefinition defaultDefinition => default(PhysicsWheelJointDefinition);

		public PhysicsWheelJointDefinition()
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_EnableSpring = false;
			m_SpringFrequency = 0f;
			m_SpringDamping = 0f;
			m_EnableMotor = false;
			m_MotorSpeed = 0f;
			m_MaxMotorTorque = 0f;
			m_EnableLimit = false;
			m_LowerTranslationLimit = 0f;
			m_UpperTranslationLimit = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}

		public PhysicsWheelJointDefinition(bool useSettings)
		{
			m_BodyA = default(PhysicsBody);
			m_BodyB = default(PhysicsBody);
			m_LocalAnchorA = default(PhysicsTransform);
			m_LocalAnchorB = default(PhysicsTransform);
			m_EnableSpring = false;
			m_SpringFrequency = 0f;
			m_SpringDamping = 0f;
			m_EnableMotor = false;
			m_MotorSpeed = 0f;
			m_MaxMotorTorque = 0f;
			m_EnableLimit = false;
			m_LowerTranslationLimit = 0f;
			m_UpperTranslationLimit = 0f;
			m_ForceThreshold = 0f;
			m_TorqueThreshold = 0f;
			m_TuningFrequency = 0f;
			m_TuningDamping = 0f;
			m_DrawScale = 0f;
			m_CollideConnected = false;
		}
	}
}
