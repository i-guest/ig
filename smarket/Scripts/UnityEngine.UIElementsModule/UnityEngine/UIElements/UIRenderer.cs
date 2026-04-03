using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	[NativeType(Header = "Modules/UIElements/Core/Native/Renderer/UIRenderer.h")]
	public sealed class UIRenderer : Renderer
	{
		internal List<CommandList>[] commandLists;

		internal bool skipRendering;

		internal void AddDrawCallData(int safeFrameIndex, int cmdListIndex, Material mat, uint textureSlotCount, uint forceRenderType)
		{
		}

		internal void ResetDrawCallData()
		{
		}

		[RequiredByNativeCode]
		private static void OnRenderNodeExecute(UIRenderer renderer, int safeFrameIndex, int cmdListIndex)
		{
		}

		private static void AddDrawCallData_Injected(IntPtr _unity_self, int safeFrameIndex, int cmdListIndex, IntPtr mat, uint textureSlotCount, uint forceRenderType)
		{
		}

		private static void ResetDrawCallData_Injected(IntPtr _unity_self)
		{
		}
	}
}
