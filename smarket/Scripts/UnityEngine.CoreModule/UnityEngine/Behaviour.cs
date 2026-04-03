using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[UsedByNativeCode]
	public class Behaviour : Component
	{
		[NativeProperty]
		[RequiredByNativeCode]
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

		[NativeProperty]
		public bool isActiveAndEnabled
		{
			[NativeMethod("IsAddedToManager")]
			get
			{
				return false;
			}
		}

		private static bool get_enabled_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_enabled_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_isActiveAndEnabled_Injected(IntPtr _unity_self)
		{
			return false;
		}
	}
}
