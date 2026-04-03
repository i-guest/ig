using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/PhysicsMaterial.h")]
	public class PhysicsMaterial : Object
	{
		public float bounciness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dynamicFriction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float staticFriction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public PhysicsMaterialCombine frictionCombine
		{
			get
			{
				return default(PhysicsMaterialCombine);
			}
			set
			{
			}
		}

		public PhysicsMaterialCombine bounceCombine
		{
			get
			{
				return default(PhysicsMaterialCombine);
			}
			set
			{
			}
		}

		private static void Internal_CreateDynamicsMaterial([Writable] PhysicsMaterial mat, string name)
		{
		}

		private static void Internal_CreateDynamicsMaterial_Injected([Writable] PhysicsMaterial mat, ref ManagedSpanWrapper name)
		{
		}

		private static float get_bounciness_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_bounciness_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_dynamicFriction_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_dynamicFriction_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_staticFriction_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_staticFriction_Injected(IntPtr _unity_self, float value)
		{
		}

		private static PhysicsMaterialCombine get_frictionCombine_Injected(IntPtr _unity_self)
		{
			return default(PhysicsMaterialCombine);
		}

		private static void set_frictionCombine_Injected(IntPtr _unity_self, PhysicsMaterialCombine value)
		{
		}

		private static PhysicsMaterialCombine get_bounceCombine_Injected(IntPtr _unity_self)
		{
			return default(PhysicsMaterialCombine);
		}

		private static void set_bounceCombine_Injected(IntPtr _unity_self, PhysicsMaterialCombine value)
		{
		}
	}
}
