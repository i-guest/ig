using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	internal static class WorldSpaceInput
	{
		public struct PickResult
		{
			public static readonly PickResult Empty;

			public Collider collider;

			public UIDocument document;

			public VisualElement pickedElement;

			public float distance;

			public Vector3 normal;

			public Vector3 point;

			public Vector3 localPoint;

			internal void ComputeCollisionData(Ray ray)
			{
			}
		}

		public static VisualElement Pick3D(UIDocument document, Ray worldRay, out float distance)
		{
			distance = default(float);
			return null;
		}

		public static PickResult PickDocument3D(Ray worldRay, float maxDistance = 1f / 0f, int layerMask = -5)
		{
			return default(PickResult);
		}

		internal static VisualElement Pick_Internal(UIDocument document, Ray documentRay, List<VisualElement> outResults = null)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "Assembly-CSharp-testable" })]
		internal static VisualElement PerformPick(VisualElement root, Ray ray, List<VisualElement> outResults)
		{
			return null;
		}

		private static VisualElement PerformPick2D(VisualElement root, Ray ray, List<VisualElement> outResults)
		{
			return null;
		}

		private static VisualElement PerformPick3D(VisualElement root, Ray ray, List<VisualElement> outResults)
		{
			return null;
		}

		private static VisualElement PerformPick2D_LocalPoint(VisualElement root, Vector3 localPoint, List<VisualElement> picked = null)
		{
			return null;
		}

		internal static Bounds GetPicking3DWorldBounds(VisualElement ve)
		{
			return default(Bounds);
		}

		internal static Bounds GetPicking3DLocalBounds(VisualElement ve)
		{
			return default(Bounds);
		}
	}
}
