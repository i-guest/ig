using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/MeshCollider.h")]
	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[RequireComponent(typeof(Transform))]
	public class MeshCollider : Collider
	{
		public Mesh sharedMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool convex
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static bool get_convex_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_convex_Injected(IntPtr _unity_self, bool value)
		{
		}
	}
}
