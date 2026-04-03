namespace UnityEngine.Rendering
{
	internal static class ProbeVolumePositioning
	{
		internal static Vector3[] m_Axes;

		internal static Vector3[] m_AABBCorners;

		public static bool OBBIntersect(in ProbeReferenceVolume.Volume a, in ProbeReferenceVolume.Volume b)
		{
			return false;
		}

		public static bool OBBContains(in ProbeReferenceVolume.Volume obb, Vector3 point)
		{
			return false;
		}

		public static bool OBBAABBIntersect(in ProbeReferenceVolume.Volume a, in Bounds b, in Bounds aAABB)
		{
			return false;
		}

		private static Vector2 ProjectOBB(in ProbeReferenceVolume.Volume a, Vector3 axis)
		{
			return default(Vector2);
		}

		private static Vector2 ProjectAABB(in Vector3[] corners, Vector3 axis)
		{
			return default(Vector2);
		}
	}
}
