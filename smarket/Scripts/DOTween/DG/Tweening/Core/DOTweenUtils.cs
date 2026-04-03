using System;
using System.Reflection;
using UnityEngine;

namespace DG.Tweening.Core
{
	public static class DOTweenUtils
	{
		private static Assembly[] _loadedAssemblies;

		private static readonly string[] _defAssembliesToQuery;

		internal static Vector3 Vector3FromAngle(float degrees, float magnitude)
		{
			return default(Vector3);
		}

		internal static float Angle2D(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation)
		{
			return default(Vector3);
		}

		public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees)
		{
			return default(Vector2);
		}

		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b)
		{
			return false;
		}

		internal static Type GetLooseScriptType(string typeName)
		{
			return null;
		}
	}
}
