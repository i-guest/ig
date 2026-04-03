using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/Collider.h")]
	public class Collider : Component
	{
		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Rigidbody attachedRigidbody
		{
			[NativeMethod("GetRigidbody")]
			get
			{
				return null;
			}
		}

		public bool isTrigger
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float contactOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Bounds bounds => default(Bounds);

		[NativeMethod("Material")]
		public PhysicsMaterial sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PhysicsMaterial material
		{
			[NativeMethod("SetMaterial")]
			set
			{
			}
		}

		public Vector3 ClosestPoint(Vector3 position)
		{
			return default(Vector3);
		}

		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			return default(RaycastHit);
		}

		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		private static bool get_enabled_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_enabled_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static bool get_isTrigger_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_isTrigger_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_contactOffset_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_contactOffset_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void ClosestPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static IntPtr get_sharedMaterial_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_sharedMaterial_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void set_material_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void Raycast_Injected(IntPtr _unity_self, [In] ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
		{
			ret = default(RaycastHit);
		}
	}
}
