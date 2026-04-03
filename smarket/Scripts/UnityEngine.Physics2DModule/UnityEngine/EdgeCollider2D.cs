using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
	public sealed class EdgeCollider2D : Collider2D
	{
		public Vector2[] points
		{
			set
			{
			}
		}

		private static void set_points_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}
	}
}
