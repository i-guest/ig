using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace UnityEngine.UIElements
{
	public static class VisualElementExtensions
	{
		public static void StretchToParentSize(this VisualElement elem)
		{
		}

		public static void AddManipulator(this VisualElement ele, IManipulator manipulator)
		{
		}

		public static void RemoveManipulator(this VisualElement ele, IManipulator manipulator)
		{
		}

		public static Vector2 WorldToLocal(this VisualElement ele, Vector2 p)
		{
			return default(Vector2);
		}

		internal static Vector3 WorldToLocal3D(this VisualElement ele, Vector3 p)
		{
			return default(Vector3);
		}

		public static Vector2 LocalToWorld(this VisualElement ele, Vector2 p)
		{
			return default(Vector2);
		}

		public static Rect WorldToLocal(this VisualElement ele, Rect r)
		{
			return default(Rect);
		}

		internal static Ray LocalToWorld([NotNull] this VisualElement ele, Ray r)
		{
			return default(Ray);
		}

		internal static Ray WorldToLocal([NotNull] this VisualElement ele, Ray r)
		{
			return default(Ray);
		}

		public static Vector2 ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Vector2 point)
		{
			return default(Vector2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 ChangeCoordinatesTo_2D([NotNull] this VisualElement src, [NotNull] VisualElement dest, Vector2 point)
		{
			return default(Vector2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 ChangeCoordinatesTo_3D([NotNull] this VisualElement src, [NotNull] VisualElement dest, Vector2 point)
		{
			return default(Vector2);
		}

		public static Rect ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Rect rect)
		{
			return default(Rect);
		}

		internal static Ray ChangeCoordinatesTo([NotNull] this VisualElement src, [NotNull] VisualElement dest, Ray ray)
		{
			return default(Ray);
		}

		internal static bool IntersectWorldRay([NotNull] this VisualElement ve, Ray worldRay, out float distance, out Vector3 localPoint)
		{
			distance = default(float);
			localPoint = default(Vector3);
			return false;
		}

		internal static bool IntersectLocalRay([NotNull] this VisualElement ve, Ray localRay, out Vector3 localPoint)
		{
			localPoint = default(Vector3);
			return false;
		}

		internal static Ray TransformRay(this Matrix4x4 m, Ray ray)
		{
			return default(Ray);
		}
	}
}
