using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GetLODGroupManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/LOD/LODGroup.h")]
	[NativeHeader("Runtime/Graphics/LOD/LODUtility.h")]
	[NativeHeader("Runtime/Graphics/LOD/LODGroupManager.h")]
	public class LODGroup : Component
	{
		public Vector3 localReferencePoint => default(Vector3);

		public float size => 0f;

		[FreeFunction("GetLODs_Binding", HasExplicitThis = true)]
		public LOD[] GetLODs()
		{
			return null;
		}

		private static void get_localReferencePoint_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static float get_size_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static LOD[] GetLODs_Injected(IntPtr _unity_self)
		{
			return null;
		}
	}
}
