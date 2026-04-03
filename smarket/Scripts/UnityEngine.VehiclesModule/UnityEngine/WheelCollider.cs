using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("PhysicsScriptingClasses.h")]
	[NativeHeader("Modules/Vehicles/WheelCollider.h")]
	public class WheelCollider : Collider
	{
		public Vector3 center => default(Vector3);

		public float radius => 0f;

		public float suspensionDistance => 0f;

		public WheelFrictionCurve forwardFriction
		{
			get
			{
				return default(WheelFrictionCurve);
			}
			set
			{
			}
		}

		public WheelFrictionCurve sidewaysFriction
		{
			get
			{
				return default(WheelFrictionCurve);
			}
			set
			{
			}
		}

		public float motorTorque
		{
			set
			{
			}
		}

		public float brakeTorque
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float steerAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isGrounded
		{
			[NativeName("IsGrounded")]
			get
			{
				return false;
			}
		}

		public float rpm => 0f;

		public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
		{
		}

		public void GetWorldPose(out Vector3 pos, out Quaternion quat)
		{
			pos = default(Vector3);
			quat = default(Quaternion);
		}

		public bool GetGroundHit(out WheelHit hit)
		{
			hit = default(WheelHit);
			return false;
		}

		private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static float get_radius_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static float get_suspensionDistance_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void get_forwardFriction_Injected(IntPtr _unity_self, out WheelFrictionCurve ret)
		{
			ret = default(WheelFrictionCurve);
		}

		private static void set_forwardFriction_Injected(IntPtr _unity_self, [In] ref WheelFrictionCurve value)
		{
		}

		private static void get_sidewaysFriction_Injected(IntPtr _unity_self, out WheelFrictionCurve ret)
		{
			ret = default(WheelFrictionCurve);
		}

		private static void set_sidewaysFriction_Injected(IntPtr _unity_self, [In] ref WheelFrictionCurve value)
		{
		}

		private static void set_motorTorque_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_brakeTorque_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_brakeTorque_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_steerAngle_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_steerAngle_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_isGrounded_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static float get_rpm_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void ConfigureVehicleSubsteps_Injected(IntPtr _unity_self, float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
		{
		}

		private static void GetWorldPose_Injected(IntPtr _unity_self, out Vector3 pos, out Quaternion quat)
		{
			pos = default(Vector3);
			quat = default(Quaternion);
		}

		private static bool GetGroundHit_Injected(IntPtr _unity_self, out WheelHit hit)
		{
			hit = default(WheelHit);
			return false;
		}
	}
}
