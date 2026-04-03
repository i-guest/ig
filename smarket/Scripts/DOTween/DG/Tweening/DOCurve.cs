using System.Collections.Generic;
using UnityEngine;

namespace DG.Tweening
{
	public static class DOCurve
	{
		public static class CubicBezier
		{
			public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor)
			{
				return default(Vector3);
			}

			public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10)
			{
				return null;
			}

			public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10)
			{
			}
		}
	}
}
