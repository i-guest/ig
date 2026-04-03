using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshObstacle.html")]
	[MovedFrom("UnityEngine")]
	public sealed class NavMeshObstacle : Behaviour
	{
		public bool carving
		{
			set
			{
			}
		}

		private static void set_carving_Injected(IntPtr _unity_self, bool value)
		{
		}
	}
}
