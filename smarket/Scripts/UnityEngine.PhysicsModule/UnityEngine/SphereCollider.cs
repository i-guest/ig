using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics/SphereCollider.h")]
	public class SphereCollider : Collider
	{
		public Vector3 center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_center_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static float get_radius_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_radius_Injected(IntPtr _unity_self, float value)
		{
		}
	}
}
