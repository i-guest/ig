using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsBodyDefinition
	{
		[SerializeField]
		private PhysicsBody.BodyType m_BodyType;

		[SerializeField]
		private PhysicsBody.BodyConstraints m_BodyConstraints;

		[SerializeField]
		private PhysicsBody.TransformWriteMode m_TransformWriteMode;

		[SerializeField]
		private Vector2 m_Position;

		[SerializeField]
		private PhysicsRotate m_Rotation;

		[SerializeField]
		private Vector2 m_LinearVelocity;

		[SerializeField]
		private float m_AngularVelocity;

		[SerializeField]
		[Min(0f)]
		private float m_LinearDamping;

		[SerializeField]
		[Min(0f)]
		private float m_AngularDamping;

		[SerializeField]
		private float m_GravityScale;

		[SerializeField]
		[Min(0f)]
		private float m_SleepThreshold;

		[SerializeField]
		private bool m_FastRotationAllowed;

		[SerializeField]
		private bool m_FastCollisionsAllowed;

		[SerializeField]
		private bool m_SleepingAllowed;

		[SerializeField]
		private bool m_Awake;

		[SerializeField]
		private bool m_Enabled;

		public static PhysicsBodyDefinition defaultDefinition => default(PhysicsBodyDefinition);

		public PhysicsBodyDefinition()
		{
			m_BodyType = default(PhysicsBody.BodyType);
			m_BodyConstraints = default(PhysicsBody.BodyConstraints);
			m_TransformWriteMode = default(PhysicsBody.TransformWriteMode);
			m_Position = default(Vector2);
			m_Rotation = default(PhysicsRotate);
			m_LinearVelocity = default(Vector2);
			m_AngularVelocity = 0f;
			m_LinearDamping = 0f;
			m_AngularDamping = 0f;
			m_GravityScale = 0f;
			m_SleepThreshold = 0f;
			m_FastRotationAllowed = false;
			m_FastCollisionsAllowed = false;
			m_SleepingAllowed = false;
			m_Awake = false;
			m_Enabled = false;
		}

		public PhysicsBodyDefinition(bool useSettings)
		{
			m_BodyType = default(PhysicsBody.BodyType);
			m_BodyConstraints = default(PhysicsBody.BodyConstraints);
			m_TransformWriteMode = default(PhysicsBody.TransformWriteMode);
			m_Position = default(Vector2);
			m_Rotation = default(PhysicsRotate);
			m_LinearVelocity = default(Vector2);
			m_AngularVelocity = 0f;
			m_LinearDamping = 0f;
			m_AngularDamping = 0f;
			m_GravityScale = 0f;
			m_SleepThreshold = 0f;
			m_FastRotationAllowed = false;
			m_FastCollisionsAllowed = false;
			m_SleepingAllowed = false;
			m_Awake = false;
			m_Enabled = false;
		}
	}
}
