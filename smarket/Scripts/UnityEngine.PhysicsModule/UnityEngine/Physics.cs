using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/Physics/PhysicsManager.h")]
	[NativeHeader("Modules/Physics/PhysicsQuery.h")]
	public class Physics
	{
		public delegate void ContactEventDelegate(PhysicsScene scene, NativeArray<ContactPairHeader>.ReadOnly headerArray);

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<PhysicsScene, IntPtr, int, bool> GenericContactModifyEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static ContactEventDelegate ContactEvent;

		private static readonly Collision s_ReusableCollision;

		public static Vector3 gravity
		{
			[ThreadSafe]
			get
			{
				return default(Vector3);
			}
		}

		public static bool queriesHitBackfaces
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool invokeCollisionCallbacks => false;

		public static PhysicsScene defaultPhysicsScene => default(PhysicsScene);

		public static bool reuseCollisionCallbacks => false;

		[RequiredByNativeCode]
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD)
		{
		}

		private static void PhysXOnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD)
		{
		}

		public static void IgnoreCollision([NotNull] Collider collider1, [NotNull] Collider collider2, [DefaultValue("true")] bool ignore)
		{
		}

		public static bool GetIgnoreLayerCollision(int layer1, int layer2)
		{
			return false;
		}

		public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction)
		{
			return false;
		}

		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray)
		{
			return false;
		}

		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static bool Linecast(Vector3 start, Vector3 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
		{
			return false;
		}

		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static bool SphereCast(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
		{
			return false;
		}

		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		[FreeFunction("Physics::RaycastAll")]
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction)
		{
			return null;
		}

		public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray)
		{
			return null;
		}

		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[RequiredByNativeCode]
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results)
		{
			return 0;
		}

		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results)
		{
			return 0;
		}

		[FreeFunction("Physics::OverlapSphere")]
		private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		public static Collider[] OverlapSphere(Vector3 position, float radius, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius)
		{
			return null;
		}

		public static void SyncTransforms()
		{
		}

		[FreeFunction("Physics::ComputePenetration")]
		private static bool Query_ComputePenetration([NotNull] Collider colliderA, Vector3 positionA, Quaternion rotationA, [NotNull] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return false;
		}

		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance)
		{
			direction = default(Vector3);
			distance = default(float);
			return false;
		}

		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results)
		{
			return 0;
		}

		[FreeFunction("Physics::SphereTest")]
		private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		public static bool CheckSphere(Vector3 position, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius, int layerMask)
		{
			return false;
		}

		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[FreeFunction("Physics::CapsuleTest")]
		private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		[FreeFunction("Physics::OverlapBox")]
		private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
		{
			return null;
		}

		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
		{
			return null;
		}

		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int mask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation)
		{
			return 0;
		}

		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results)
		{
			return 0;
		}

		[StaticAccessor("PhysicsManager", StaticAccessorType.DoubleColon)]
		internal static Collider GetColliderByInstanceID(EntityId entityId)
		{
			return null;
		}

		[StaticAccessor("PhysicsManager", StaticAccessorType.DoubleColon)]
		internal static Component GetBodyByInstanceID(EntityId entityId)
		{
			return null;
		}

		[StaticAccessor("PhysicsManager", StaticAccessorType.DoubleColon)]
		private static void SendOnCollisionEnter(Component component, Collision collision)
		{
		}

		[StaticAccessor("PhysicsManager", StaticAccessorType.DoubleColon)]
		private static void SendOnCollisionStay(Component component, Collision collision)
		{
		}

		[StaticAccessor("PhysicsManager", StaticAccessorType.DoubleColon)]
		private static void SendOnCollisionExit(Component component, Collision collision)
		{
		}

		[RequiredByNativeCode]
		private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count)
		{
		}

		private static void ReportContacts(NativeArray<ContactPairHeader>.ReadOnly array)
		{
		}

		private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped)
		{
			return null;
		}

		private static void get_gravity_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void IgnoreCollision_Injected(IntPtr collider1, IntPtr collider2, [DefaultValue("true")] bool ignore)
		{
		}

		private static void Internal_RaycastAll_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static Collider[] OverlapSphere_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		private static bool Query_ComputePenetration_Injected(IntPtr colliderA, [In] ref Vector3 positionA, [In] ref Quaternion rotationA, IntPtr colliderB, [In] ref Vector3 positionB, [In] ref Quaternion rotationB, ref Vector3 direction, ref float distance)
		{
			return false;
		}

		private static bool CheckSphere_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static bool CheckCapsule_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 start, [In] ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return false;
		}

		private static Collider[] OverlapBox_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, [In] ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			return null;
		}

		private static IntPtr GetColliderByInstanceID_Injected([In] ref EntityId entityId)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetBodyByInstanceID_Injected([In] ref EntityId entityId)
		{
			return (IntPtr)0;
		}

		private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision)
		{
		}

		private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision)
		{
		}

		private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision)
		{
		}
	}
}
