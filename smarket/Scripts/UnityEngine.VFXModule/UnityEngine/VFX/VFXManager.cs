using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/VFX/Public/VFXManager.h")]
	public static class VFXManager
	{
		private static readonly VFXCameraXRSettings kDefaultCameraXRSettings;

		public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
		{
		}

		private static void Internal_ProcessCameraCommand([NotNull] Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults, IntPtr customPassCullResults)
		{
		}

		public static VFXCameraBufferTypes IsCameraBufferNeeded([NotNull] Camera cam)
		{
			return default(VFXCameraBufferTypes);
		}

		public static void SetCameraBuffer([NotNull] Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height)
		{
		}

		private static void Internal_ProcessCameraCommand_Injected(IntPtr cam, IntPtr cmd, [In] ref VFXCameraXRSettings camXRSettings, IntPtr cullResults, IntPtr customPassCullResults)
		{
		}

		private static VFXCameraBufferTypes IsCameraBufferNeeded_Injected(IntPtr cam)
		{
			return default(VFXCameraBufferTypes);
		}

		private static void SetCameraBuffer_Injected(IntPtr cam, VFXCameraBufferTypes type, IntPtr buffer, int x, int y, int width, int height)
		{
		}
	}
}
