using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.AI
{
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	public sealed class NavMeshData : Object
	{
		public Vector3 position
		{
			set
			{
			}
		}

		public Quaternion rotation
		{
			set
			{
			}
		}

		public NavMeshData()
		{
		}

		public NavMeshData(int agentTypeID)
		{
		}

		[StaticAccessor("NavMeshDataBindings", StaticAccessorType.DoubleColon)]
		private static void Internal_Create([Writable] NavMeshData mono, int agentTypeID)
		{
		}

		private static void set_position_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void set_rotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
		{
		}
	}
}
