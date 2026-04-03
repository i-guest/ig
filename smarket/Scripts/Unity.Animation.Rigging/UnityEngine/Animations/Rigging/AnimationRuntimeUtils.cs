using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	public static class AnimationRuntimeUtils
	{
		private const float k_SqrEpsilon = 1E-08f;

		public static void SolveTwoBoneIK(AnimationStream stream, ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip, ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset)
		{
		}

		public static void InverseSolveTwoBoneIK(AnimationStream stream, ReadOnlyTransformHandle root, ReadOnlyTransformHandle mid, ReadOnlyTransformHandle tip, ReadWriteTransformHandle target, ReadWriteTransformHandle hint, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset)
		{
		}

		public static void InverseSolveTwoBoneIK(Vector3 rootPosition, Vector3 midPosition, Vector3 tipPosition, Quaternion tipRotation, ref Vector3 targetPosition, ref Quaternion targetRotation, ref Vector3 hintPosition, bool isHintValid, float posWeight, float rotWeight, float hintWeight, AffineTransform targetOffset)
		{
		}

		private static float TriangleAngle(float aLen, float aLen1, float aLen2)
		{
			return 0f;
		}

		public static bool SolveFABRIK(ref NativeArray<Vector3> linkPositions, ref NativeArray<float> linkLengths, Vector3 target, float tolerance, float maxReach, int maxIterations)
		{
			return false;
		}

		public static float SqrDistance(Vector3 lhs, Vector3 rhs)
		{
			return 0f;
		}

		public static float Square(float value)
		{
			return 0f;
		}

		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t)
		{
			return default(Vector3);
		}

		public static float Select(float a, float b, float c)
		{
			return 0f;
		}

		public static Vector3 Select(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		internal static float Sum(AnimationJobCache cache, CacheIndex index, int count)
		{
			return 0f;
		}

		public static float Sum(NativeArray<float> floatBuffer)
		{
			return 0f;
		}

		public static void PassThrough(AnimationStream stream, ReadWriteTransformHandle handle)
		{
		}
	}
}
