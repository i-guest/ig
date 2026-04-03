using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/Skybox.h")]
	public sealed class Skybox : Behaviour
	{
		public Material material => null;

		private static IntPtr get_material_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}
	}
}
