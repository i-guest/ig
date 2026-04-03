using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
	public class MeshRenderer : Renderer
	{
		public Mesh additionalVertexStreams
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int subMeshStartIndex
		{
			[NativeName("GetSubMeshStartIndex")]
			get
			{
				return 0;
			}
		}

		[RequiredByNativeCode]
		private void DontStripMeshRenderer()
		{
		}

		private static IntPtr get_additionalVertexStreams_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_additionalVertexStreams_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static int get_subMeshStartIndex_Injected(IntPtr _unity_self)
		{
			return 0;
		}
	}
}
