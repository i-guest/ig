using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/Camera.h")]
	internal class CameraRaycastHelper
	{
		[FreeFunction("CameraScripting::RaycastTry")]
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			return null;
		}

		[FreeFunction("CameraScripting::RaycastTry2D")]
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			return null;
		}

		private static IntPtr RaycastTry_Injected(IntPtr cam, [In] ref Ray ray, float distance, int layerMask)
		{
			return (IntPtr)0;
		}

		private static IntPtr RaycastTry2D_Injected(IntPtr cam, [In] ref Ray ray, float distance, int layerMask)
		{
			return (IntPtr)0;
		}
	}
}
