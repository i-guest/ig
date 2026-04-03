using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsRotate : ISerializationCallbackReceiver
	{
		public Vector2 direction;

		private static readonly PhysicsRotate identityRotation;

		private static readonly PhysicsRotate leftRotation;

		private static readonly PhysicsRotate upRotation;

		private static readonly PhysicsRotate downRotation;

		public readonly float cos
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
		}

		public readonly float sin
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
		}

		public readonly bool isValid => false;

		public readonly float angle => 0f;

		public static PhysicsRotate identity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(PhysicsRotate);
			}
		}

		public PhysicsRotate()
		{
			direction = default(Vector2);
		}

		public PhysicsRotate(Vector2 direction)
		{
			this.direction = default(Vector2);
		}

		public PhysicsRotate(float angle)
		{
			direction = default(Vector2);
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public override readonly string ToString()
		{
			return null;
		}
	}
}
