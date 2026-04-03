using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider
	{
		public Vector3 velocity => default(Vector3);

		public bool isGrounded
		{
			[NativeName("IsGrounded")]
			get
			{
				return false;
			}
		}

		public float radius => 0f;

		public float height => 0f;

		public bool SimpleMove(Vector3 speed)
		{
			return false;
		}

		public CollisionFlags Move(Vector3 motion)
		{
			return default(CollisionFlags);
		}

		private static bool SimpleMove_Injected(IntPtr _unity_self, [In] ref Vector3 speed)
		{
			return false;
		}

		private static CollisionFlags Move_Injected(IntPtr _unity_self, [In] ref Vector3 motion)
		{
			return default(CollisionFlags);
		}

		private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static bool get_isGrounded_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static float get_radius_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static float get_height_Injected(IntPtr _unity_self)
		{
			return 0f;
		}
	}
}
