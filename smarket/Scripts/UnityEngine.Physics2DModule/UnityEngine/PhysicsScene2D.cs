using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
	public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
	{
		private int m_Handle;

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(PhysicsScene2D other)
		{
			return false;
		}

		public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("Linecast_Binding")]
		private static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return default(RaycastHit2D);
		}

		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
		{
			return 0;
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("Raycast_Binding")]
		private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("RaycastArray_Binding")]
		private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull] RaycastHit2D[] results)
		{
			return 0;
		}

		[NativeMethod("RaycastList_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull] List<RaycastHit2D> results)
		{
			return 0;
		}

		public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("CircleCast_Binding")]
		private static RaycastHit2D CircleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return default(RaycastHit2D);
		}

		public RaycastHit2D GetRayIntersection(Ray ray, float distance, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return default(RaycastHit2D);
		}

		public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, [DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5)
		{
			return 0;
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("GetRayIntersection_Binding")]
		private static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			return default(RaycastHit2D);
		}

		[NativeMethod("GetRayIntersectionArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, [NotNull] RaycastHit2D[] results)
		{
			return 0;
		}

		public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		[NativeMethod("OverlapPointArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int OverlapPointArray_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, [UnityMarshalAs(NativeType.ScriptingObjectPtr)][NotNull] Collider2D[] results)
		{
			return 0;
		}

		public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		[NativeMethod("OverlapCircleArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, [NotNull][UnityMarshalAs(NativeType.ScriptingObjectPtr)] Collider2D[] results)
		{
			return 0;
		}

		private static void Linecast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 start, [In] ref Vector2 end, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			ret = default(RaycastHit2D);
		}

		private static void Raycast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			ret = default(RaycastHit2D);
		}

		private static int RaycastArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
		{
			return 0;
		}

		private static int RaycastList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
		{
			return 0;
		}

		private static void CircleCast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, float radius, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
		{
			ret = default(RaycastHit2D);
		}

		private static void GetRayIntersection_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret)
		{
			ret = default(RaycastHit2D);
		}

		private static int GetRayIntersectionArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results)
		{
			return 0;
		}

		private static int OverlapPointArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		private static int OverlapCircleArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, float radius, [In] ref ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}
	}
}
