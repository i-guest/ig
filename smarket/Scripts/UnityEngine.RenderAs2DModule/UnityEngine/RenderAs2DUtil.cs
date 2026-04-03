using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[NativeHeader("Modules/RenderAs2D/Public/RenderAs2DUtil.h")]
	internal struct RenderAs2DUtil
	{
		[FreeFunction("RenderAs2DUtil::InitializeCanRenderAs2D")]
		internal static void InitializeCanRenderAs2D()
		{
		}

		[FreeFunction("RenderAs2DUtil::DisposeCanRenderAs2D")]
		internal static void DisposeCanRenderAs2D()
		{
		}
	}
}
