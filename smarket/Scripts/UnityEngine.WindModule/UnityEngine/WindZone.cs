using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Wind/Public/Wind.h")]
	public class WindZone : Component
	{
		public float radius => 0f;

		public float windMain => 0f;

		private static float get_radius_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static float get_windMain_Injected(IntPtr _unity_self)
		{
			return 0f;
		}
	}
}
