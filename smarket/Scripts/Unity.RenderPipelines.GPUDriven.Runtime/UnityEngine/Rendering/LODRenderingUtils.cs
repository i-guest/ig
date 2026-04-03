namespace UnityEngine.Rendering
{
	internal static class LODRenderingUtils
	{
		public static float CalculateFOVHalfAngle(float fieldOfView)
		{
			return 0f;
		}

		public static float CalculateScreenRelativeMetricNoBias(LODParameters lodParams)
		{
			return 0f;
		}

		public static float CalculateMeshLodConstant(LODParameters lodParams, float screenRelativeMetric, float meshLodThreshold)
		{
			return 0f;
		}

		public static float CalculatePerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric)
		{
			return 0f;
		}

		public static float CalculateSqrPerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric)
		{
			return 0f;
		}

		public static Vector3 GetWorldReferencePoint(this LODGroup lodGroup)
		{
			return default(Vector3);
		}

		public static float GetWorldSpaceScale(this LODGroup lodGroup)
		{
			return 0f;
		}

		public static float GetWorldSpaceSize(this LODGroup lodGroup)
		{
			return 0f;
		}

		public static float CalculateLODDistance(float relativeScreenHeight, float size)
		{
			return 0f;
		}
	}
}
