using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
	public sealed class PhysicsMaterial2D : Object
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

		public float friction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeMethod("Create_Binding")]
		private static void Create_Internal([Writable] PhysicsMaterial2D scriptMaterial, string name)
		{
		}

		private static void Create_Internal_Injected([Writable] PhysicsMaterial2D scriptMaterial, ref ManagedSpanWrapper name)
		{
		}

		private static float get_bounciness_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_bounciness_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_friction_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_friction_Injected(IntPtr _unity_self, float value)
		{
		}
	}
}
