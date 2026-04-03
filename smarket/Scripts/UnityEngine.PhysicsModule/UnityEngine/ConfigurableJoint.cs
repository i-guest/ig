using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Rigidbody))]
	[NativeHeader("Modules/Physics/ConfigurableJoint.h")]
	[NativeClass("Unity::ConfigurableJoint")]
	public class ConfigurableJoint : Joint
	{
		public ConfigurableJointMotion xMotion
		{
			set
			{
			}
		}

		public ConfigurableJointMotion yMotion
		{
			set
			{
			}
		}

		public ConfigurableJointMotion zMotion
		{
			set
			{
			}
		}

		public ConfigurableJointMotion angularXMotion
		{
			set
			{
			}
		}

		public ConfigurableJointMotion angularYMotion
		{
			set
			{
			}
		}

		public ConfigurableJointMotion angularZMotion
		{
			set
			{
			}
		}

		public SoftJointLimitSpring linearLimitSpring
		{
			set
			{
			}
		}

		public SoftJointLimit linearLimit
		{
			get
			{
				return default(SoftJointLimit);
			}
			set
			{
			}
		}

		public SoftJointLimit lowAngularXLimit
		{
			set
			{
			}
		}

		public SoftJointLimit highAngularXLimit
		{
			set
			{
			}
		}

		public SoftJointLimit angularYLimit
		{
			set
			{
			}
		}

		public SoftJointLimit angularZLimit
		{
			set
			{
			}
		}

		public bool configuredInWorldSpace
		{
			set
			{
			}
		}

		private static void set_xMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
		{
		}

		private static void set_yMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
		{
		}

		private static void set_zMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
		{
		}

		private static void set_angularXMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
		{
		}

		private static void set_angularYMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
		{
		}

		private static void set_angularZMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
		{
		}

		private static void set_linearLimitSpring_Injected(IntPtr _unity_self, [In] ref SoftJointLimitSpring value)
		{
		}

		private static void get_linearLimit_Injected(IntPtr _unity_self, out SoftJointLimit ret)
		{
			ret = default(SoftJointLimit);
		}

		private static void set_linearLimit_Injected(IntPtr _unity_self, [In] ref SoftJointLimit value)
		{
		}

		private static void set_lowAngularXLimit_Injected(IntPtr _unity_self, [In] ref SoftJointLimit value)
		{
		}

		private static void set_highAngularXLimit_Injected(IntPtr _unity_self, [In] ref SoftJointLimit value)
		{
		}

		private static void set_angularYLimit_Injected(IntPtr _unity_self, [In] ref SoftJointLimit value)
		{
		}

		private static void set_angularZLimit_Injected(IntPtr _unity_self, [In] ref SoftJointLimit value)
		{
		}

		private static void set_configuredInWorldSpace_Injected(IntPtr _unity_self, bool value)
		{
		}
	}
}
