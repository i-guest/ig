using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/Avatar.h")]
	public class Avatar : Object
	{
		public HumanDescription humanDescription => default(HumanDescription);

		private Avatar()
		{
		}

		private static void get_humanDescription_Injected(IntPtr _unity_self, out HumanDescription ret)
		{
			ret = default(HumanDescription);
		}
	}
}
