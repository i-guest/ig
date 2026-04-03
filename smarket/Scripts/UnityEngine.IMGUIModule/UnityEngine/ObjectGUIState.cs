using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/IMGUI/GUIState.h")]
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal class ObjectGUIState : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(ObjectGUIState objectGUIState)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		public void Dispose()
		{
		}

		~ObjectGUIState()
		{
		}

		private void Destroy()
		{
		}

		private static IntPtr Internal_Create()
		{
			return (IntPtr)0;
		}

		[NativeMethod(IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
		}
	}
}
