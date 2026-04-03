using UnityEngine.Bindings;

namespace UnityEngine.XR
{
	[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
	[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
	[NativeHeader("Modules/VR/VRModule.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeConditional("ENABLE_VR")]
	public static class XRSettings
	{
		public static bool enabled
		{
			[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
			get
			{
				return false;
			}
		}

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[NativeName("Active")]
		public static bool isDeviceActive => false;

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureWidth => 0;

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureHeight => 0;

		[NativeName("IntermediateEyeTextureDesc")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
		public static RenderTextureDescriptor eyeTextureDesc => default(RenderTextureDescriptor);

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[NativeName("DeviceName")]
		public static string loadedDeviceName => null;

		public static string[] supportedDevices => null;

		private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
		{
			ret = default(RenderTextureDescriptor);
		}

		private static void get_loadedDeviceName_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
