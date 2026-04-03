using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
	[RequireComponent(typeof(Rigidbody2D))]
	public sealed class CompositeCollider2D : Collider2D
	{
		public int pathCount => 0;

		public int pointCount => 0;

		public int GetPath(int index, Vector2[] points)
		{
			return 0;
		}

		[NativeMethod("GetPathArray_Binding")]
		private int GetPathArray_Internal(int index, [NotNull] Vector2[] points)
		{
			return 0;
		}

		private static int get_pathCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_pointCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetPathArray_Internal_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper points)
		{
			return 0;
		}
	}
}
