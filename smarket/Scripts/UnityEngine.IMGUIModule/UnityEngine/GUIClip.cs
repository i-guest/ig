using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule" })]
	[NativeHeader("Modules/IMGUI/GUIState.h")]
	[NativeHeader("Modules/IMGUI/GUIClip.h")]
	internal sealed class GUIClip
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule" })]
		internal struct ParentClipScope : IDisposable
		{
			private bool m_Disposed;

			public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
			{
				m_Disposed = false;
			}

			public void Dispose()
			{
			}
		}

		internal static Rect visibleRect
		{
			[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
			get
			{
				return default(Rect);
			}
		}

		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void Internal_Pop()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
		internal static int Internal_GetCount()
		{
			return 0;
		}

		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
		internal static Matrix4x4 GetMatrix()
		{
			return default(Matrix4x4);
		}

		internal static void SetMatrix(Matrix4x4 m)
		{
		}

		internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
		{
		}

		internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect)
		{
		}

		internal static void Internal_PopParentClip()
		{
		}

		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
		}

		private static void get_visibleRect_Injected(out Rect ret)
		{
			ret = default(Rect);
		}

		private static void Internal_Push_Injected([In] ref Rect screenRect, [In] ref Vector2 scrollOffset, [In] ref Vector2 renderOffset, bool resetOffset)
		{
		}

		private static void GetMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void SetMatrix_Injected([In] ref Matrix4x4 m)
		{
		}

		private static void Internal_PushParentClip_Injected([In] ref Matrix4x4 renderTransform, [In] ref Matrix4x4 inputTransform, [In] ref Rect clipRect)
		{
		}
	}
}
