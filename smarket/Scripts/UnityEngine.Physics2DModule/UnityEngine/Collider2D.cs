using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode(Optional = true)]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	[RequireComponent(typeof(Transform))]
	public class Collider2D : Behaviour
	{
		public float density
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isTrigger
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool usedByEffector
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 offset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Rigidbody2D attachedRigidbody
		{
			[NativeMethod("GetAttachedRigidbody_Binding")]
			get
			{
				return null;
			}
		}

		public int shapeCount => 0;

		public Bounds bounds => default(Bounds);

		public PhysicsMaterial2D sharedMaterial
		{
			[NativeMethod("GetMaterial")]
			get
			{
				return null;
			}
			[NativeMethod("SetMaterial")]
			set
			{
			}
		}

		[NativeMethod("GetShapeHash_Binding")]
		public uint GetShapeHash()
		{
			return 0u;
		}

		public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup)
		{
			return 0;
		}

		[NativeMethod("GetShapes_Binding")]
		private int GetShapes_Internal(ref PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount)
		{
			return 0;
		}

		[NativeMethod("GetShapeBounds_Binding")]
		public Bounds GetShapeBounds(List<Bounds> bounds, bool useRadii, bool useWorldSpace)
		{
			return default(Bounds);
		}

		public bool OverlapPoint(Vector2 point)
		{
			return false;
		}

		private static float get_density_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_density_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_isTrigger_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_isTrigger_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_usedByEffector_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_usedByEffector_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void get_offset_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_offset_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static int get_shapeCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static uint GetShapeHash_Injected(IntPtr _unity_self)
		{
			return 0u;
		}

		private static int GetShapes_Internal_Injected(IntPtr _unity_self, ref PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount)
		{
			return 0;
		}

		private static void GetShapeBounds_Injected(IntPtr _unity_self, ref BlittableListWrapper bounds, bool useRadii, bool useWorldSpace, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static IntPtr get_sharedMaterial_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_sharedMaterial_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static bool OverlapPoint_Injected(IntPtr _unity_self, [In] ref Vector2 point)
		{
			return false;
		}
	}
}
