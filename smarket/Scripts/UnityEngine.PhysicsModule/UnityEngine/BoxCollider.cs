using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/BoxCollider.h")]
	[RequireComponent(typeof(Transform))]
	public class BoxCollider : Collider
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

		public Vector3 size
		{
			get
			{
				return default(Vector3);
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

		private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_size_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}
	}
}
