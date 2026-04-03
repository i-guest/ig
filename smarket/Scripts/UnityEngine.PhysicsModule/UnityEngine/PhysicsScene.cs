using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
	[NativeHeader("Modules/Physics/PhysicsQuery.h")]
	public struct PhysicsScene : IEquatable<PhysicsScene>
	{
		private int m_index;

		private int m_version;

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(PhysicsScene lhs, PhysicsScene rhs)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(PhysicsScene other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static PhysicsScene GetDefaultScene()
		{
			return default(PhysicsScene);
		}

		public bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance = 1f / 0f, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return false;
		}

		[FreeFunction("Physics::RaycastTest")]
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance = 1f / 0f, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[FreeFunction("Physics::Raycast")]
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [DefaultValue("Mathf.Infinity")] float maxDistance = 1f / 0f, [DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		[FreeFunction("Physics::RaycastNonAlloc")]
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[FreeFunction("Physics::SphereCast")]
		private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance = 1f / 0f, [DefaultValue("DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[FreeFunction("Physics::SphereCastNonAlloc")]
		private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance = 1f / 0f, [DefaultValue("DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		[FreeFunction("Physics::OverlapSphereNonAlloc")]
		private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [UnityMarshalAs(NativeType.ScriptingObjectPtr)] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		public int OverlapSphere(Vector3 position, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[FreeFunction("Physics::OverlapBoxNonAlloc")]
		private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [UnityMarshalAs(NativeType.ScriptingObjectPtr)] Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("DefaultRaycastLayers")] int layerMask = -5, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		private static bool Internal_RaycastTest_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static bool Internal_Raycast_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static int Internal_RaycastNonAlloc_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		private static bool Query_SphereCast_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 origin, float radius, [In] ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static int Internal_SphereCastNonAlloc_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 origin, float radius, [In] ref Vector3 direction, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		private static int OverlapSphereNonAlloc_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		private static int OverlapBoxNonAlloc_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, Collider[] results, [In] ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}
	}
}
