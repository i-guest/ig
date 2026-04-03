using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
	public sealed class BoxCollider2D : Collider2D
	{
		public Vector2 size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_size_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}
	}
}
