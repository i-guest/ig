using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsTransform
	{
		public Vector2 position;

		public PhysicsRotate rotation;

		private static readonly PhysicsTransform identityTransform;

		public PhysicsTransform()
		{
			position = default(Vector2);
			rotation = default(PhysicsRotate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void GetPositionAndRotation(out Vector2 position, out PhysicsRotate rotation)
		{
			position = default(Vector2);
			rotation = default(PhysicsRotate);
		}

		public override readonly string ToString()
		{
			return null;
		}
	}
}
