using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
	public class Physics2D
	{
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D;

		public static PhysicsScene2D defaultPhysicsScene => default(PhysicsScene2D);

		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool queriesHitTriggers => false;

		public static void SyncTransforms()
		{
		}

		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask)
		{
			return null;
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("LinecastAll_Binding")]
		private static RaycastHit2D[] LinecastAll_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			return default(RaycastHit2D);
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			return default(RaycastHit2D);
		}

		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results)
		{
			return 0;
		}

		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance)
		{
			return 0;
		}

		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance = 1f / 0f)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			return null;
		}

		[NativeMethod("RaycastAll_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D[] RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			return default(RaycastHit2D);
		}

		public static RaycastHit2D GetRayIntersection(Ray ray, float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5)
		{
			return default(RaycastHit2D);
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance)
		{
			return null;
		}

		[RequiredByNativeCode]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5)
		{
			return null;
		}

		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		[NativeMethod("GetRayIntersectionAll_Binding")]
		private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5)
		{
			return 0;
		}

		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, [UnityMarshalAs(NativeType.ScriptingObjectPtr)] Collider2D[] results)
		{
			return 0;
		}

		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results)
		{
			return 0;
		}

		[ExcludeFromDocs]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("GetRayIntersectionNonAlloc is deprecated. Please use GetRayIntersection.", false)]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results)
		{
			return 0;
		}

		[ExcludeFromDocs]
		[Obsolete("GetRayIntersectionNonAlloc is deprecated. Please use GetRayIntersection.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance)
		{
			return 0;
		}

		private static void LinecastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 start, [In] ref Vector2 end, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void RaycastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void GetRayIntersectionAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}
	}
}
