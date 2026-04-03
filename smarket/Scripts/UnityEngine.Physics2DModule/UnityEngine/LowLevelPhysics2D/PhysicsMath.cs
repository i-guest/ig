using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public readonly struct PhysicsMath
	{
		public static float Atan2(float y, float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Swizzle(Vector3 position, PhysicsWorld.TransformPlane transformPlane = PhysicsWorld.TransformPlane.XY)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ToPosition3D(Vector2 position, Vector3 reference, PhysicsWorld.TransformPlane transformPlane = PhysicsWorld.TransformPlane.XY)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ToRotation2D(Quaternion quaternion, PhysicsWorld.TransformPlane transformPlane = PhysicsWorld.TransformPlane.XY)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion AngularVelocityToQuaternion(float angularVelocity, float deltaTime, PhysicsWorld.TransformPlane transformPlane)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion ToRotationFast3D(float angle, PhysicsWorld.TransformPlane transformPlane = PhysicsWorld.TransformPlane.XY)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion ToRotationSlow3D(float angle, Quaternion reference, PhysicsWorld.TransformPlane transformPlane = PhysicsWorld.TransformPlane.XY)
		{
			return default(Quaternion);
		}
	}
}
