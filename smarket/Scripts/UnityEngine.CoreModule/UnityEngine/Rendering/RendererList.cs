using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[MovedFrom("UnityEngine.Rendering.RendererUtils")]
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/RendererList.h")]
	public struct RendererList
	{
		internal UIntPtr context;

		internal uint index;

		internal uint frame;

		internal uint type;

		internal uint contextID;

		public static readonly RendererList nullRendererList;

		public bool isValid => false;

		internal RendererList(UIntPtr ctx, uint indx)
		{
			context = (UIntPtr)0u;
			index = 0u;
			frame = 0u;
			type = 0u;
			contextID = 0u;
		}
	}
}
