using System;

namespace UnityEngine.LowLevelPhysics2D
{
	public readonly struct PhysicsBody : IEquatable<PhysicsBody>
	{
		public enum BodyType
		{
			Dynamic = 0,
			Kinematic = 1,
			Static = 2
		}

		[Flags]
		public enum BodyConstraints
		{
			None = 0,
			PositionX = 1,
			PositionY = 2,
			Rotation = 4,
			Position = 3,
			All = 7
		}

		public enum TransformWriteMode
		{
			Current = 0,
			Interpolate = 1,
			Extrapolate = 2,
			Off = 3
		}

		public struct TransformWriteTween
		{
			private PhysicsBody m_Body;

			private TransformWriteMode m_TransformWriteMode;

			private PhysicsTransform m_PhysicsTransform;

			private Vector2 m_LinearVelocity;

			private float m_AngularVelocity;

			private Vector3 m_PositionFrom;

			private Quaternion m_RotationFrom;

			public readonly PhysicsBody body => default(PhysicsBody);

			public readonly TransformWriteMode transformWriteMode => default(TransformWriteMode);

			public readonly PhysicsTransform physicsTransform => default(PhysicsTransform);

			public readonly Vector2 linearVelocity => default(Vector2);

			public readonly float angularVelocity => 0f;

			public Vector3 positionFrom
			{
				readonly get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Quaternion rotationFrom
			{
				readonly get
				{
					return default(Quaternion);
				}
				set
				{
				}
			}
		}

		private readonly int m_Index1;

		private readonly ushort m_World0;

		private readonly ushort m_Generation;

		public bool isValid => false;

		public BodyType type => default(BodyType);

		public object callbackTarget => null;

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(PhysicsBody other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
