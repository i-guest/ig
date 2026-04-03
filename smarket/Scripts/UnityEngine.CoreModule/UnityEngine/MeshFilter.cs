using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
	public sealed class MeshFilter : Component
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

		public Mesh mesh
		{
			[NativeName("SetInstantiatedMesh")]
			set
			{
			}
		}

		[RequiredByNativeCode]
		private void DontStripMeshFilter()
		{
		}

		private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value)
		{
		}
	}
}
