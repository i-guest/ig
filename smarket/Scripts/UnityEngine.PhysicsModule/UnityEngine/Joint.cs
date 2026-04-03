using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/Joint.h")]
	[NativeClass("Unity::Joint")]
	public class Joint : Component
	{
		public Rigidbody connectedBody
		{
			[NativeName("SetConnectedRigidbody")]
			set
			{
			}
		}

		public Vector3 axis
		{
			set
			{
			}
		}

		public Vector3 anchor
		{
			set
			{
			}
		}

		public Vector3 connectedAnchor
		{
			set
			{
			}
		}

		public bool autoConfigureConnectedAnchor
		{
			set
			{
			}
		}

		public float breakForce
		{
			set
			{
			}
		}

		public float breakTorque
		{
			set
			{
			}
		}

		public bool enableCollision
		{
			set
			{
			}
		}

		public float massScale => 0f;

		public float connectedMassScale => 0f;

		private static void set_connectedBody_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void set_axis_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void set_anchor_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void set_connectedAnchor_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void set_autoConfigureConnectedAnchor_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_breakForce_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_breakTorque_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_enableCollision_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_massScale_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static float get_connectedMassScale_Injected(IntPtr _unity_self)
		{
			return 0f;
		}
	}
}
