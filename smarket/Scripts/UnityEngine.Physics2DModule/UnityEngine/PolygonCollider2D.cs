using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
	public sealed class PolygonCollider2D : Collider2D
	{
		public Vector2[] points
		{
			[NativeMethod("GetPoints_Binding")]
			get
			{
				return null;
			}
			[NativeMethod("SetPoints_Binding")]
			set
			{
			}
		}

		public int pathCount => 0;

		[NativeMethod("GetPointCount")]
		public int GetTotalPointCount()
		{
			return 0;
		}

		public Vector2[] GetPath(int index)
		{
			return null;
		}

		[NativeMethod("GetPath_Binding")]
		private Vector2[] GetPath_Internal(int index)
		{
			return null;
		}

		public void SetPath(int index, Vector2[] points)
		{
		}

		[NativeMethod("SetPath_Binding")]
		private void SetPath_Internal(int index, [NotNull] Vector2[] points)
		{
		}

		private static int GetTotalPointCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void get_points_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void set_points_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static int get_pathCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void GetPath_Internal_Injected(IntPtr _unity_self, int index, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void SetPath_Internal_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper points)
		{
		}
	}
}
