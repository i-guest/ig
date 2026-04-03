using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/Rigidbody.h")]
	[RequireComponent(typeof(Transform))]
	public class Rigidbody : Component
	{
		public Vector3 linearVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 angularVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float linearDamping
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angularDamping
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxDepenetrationVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isKinematic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool freezeRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RigidbodyConstraints constraints
		{
			get
			{
				return default(RigidbodyConstraints);
			}
			set
			{
			}
		}

		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return default(CollisionDetectionMode);
			}
			set
			{
			}
		}

		public Vector3 centerOfMass
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 worldCenterOfMass => default(Vector3);

		public Quaternion inertiaTensorRotation
		{
			set
			{
			}
		}

		public Vector3 inertiaTensor
		{
			set
			{
			}
		}

		public bool detectCollisions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public RigidbodyInterpolation interpolation
		{
			get
			{
				return default(RigidbodyInterpolation);
			}
			set
			{
			}
		}

		public int solverIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float sleepThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxAngularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int solverVelocityIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void MovePosition(Vector3 position)
		{
		}

		public void MoveRotation(Quaternion rotation)
		{
		}

		public void Sleep()
		{
		}

		public bool IsSleeping()
		{
			return false;
		}

		public void WakeUp()
		{
		}

		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			return default(Vector3);
		}

		public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		[ExcludeFromDocs]
		public void AddForce(Vector3 force)
		{
		}

		public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque)
		{
		}

		public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque)
		{
		}

		public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
		}

		private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_linearVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_angularVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static float get_linearDamping_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_linearDamping_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_angularDamping_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_angularDamping_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_mass_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_mass_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_useGravity_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useGravity_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_maxDepenetrationVelocity_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_maxDepenetrationVelocity_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_isKinematic_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_isKinematic_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static RigidbodyConstraints get_constraints_Injected(IntPtr _unity_self)
		{
			return default(RigidbodyConstraints);
		}

		private static void set_constraints_Injected(IntPtr _unity_self, RigidbodyConstraints value)
		{
		}

		private static CollisionDetectionMode get_collisionDetectionMode_Injected(IntPtr _unity_self)
		{
			return default(CollisionDetectionMode);
		}

		private static void set_collisionDetectionMode_Injected(IntPtr _unity_self, CollisionDetectionMode value)
		{
		}

		private static void get_centerOfMass_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_centerOfMass_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void get_worldCenterOfMass_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_inertiaTensorRotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
		{
		}

		private static void set_inertiaTensor_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static bool get_detectCollisions_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_detectCollisions_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_position_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void set_rotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
		{
		}

		private static RigidbodyInterpolation get_interpolation_Injected(IntPtr _unity_self)
		{
			return default(RigidbodyInterpolation);
		}

		private static void set_interpolation_Injected(IntPtr _unity_self, RigidbodyInterpolation value)
		{
		}

		private static int get_solverIterations_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_solverIterations_Injected(IntPtr _unity_self, int value)
		{
		}

		private static float get_sleepThreshold_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_sleepThreshold_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_maxAngularVelocity_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_maxAngularVelocity_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void MovePosition_Injected(IntPtr _unity_self, [In] ref Vector3 position)
		{
		}

		private static void MoveRotation_Injected(IntPtr _unity_self, [In] ref Quaternion rotation)
		{
		}

		private static void Sleep_Injected(IntPtr _unity_self)
		{
		}

		private static bool IsSleeping_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void WakeUp_Injected(IntPtr _unity_self)
		{
		}

		private static void GetPointVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 worldPoint, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static int get_solverVelocityIterations_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_solverVelocityIterations_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void AddForce_Injected(IntPtr _unity_self, [In] ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private static void AddTorque_Injected(IntPtr _unity_self, [In] ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private static void AddRelativeTorque_Injected(IntPtr _unity_self, [In] ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private static void AddForceAtPosition_Injected(IntPtr _unity_self, [In] ref Vector3 force, [In] ref Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}
	}
}
