using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
	[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
	[NativeHeader("Runtime/Misc/SystemInfoAudio.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Misc/SystemInfoRendering.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	public sealed class SystemInfo
	{
		public static string operatingSystem => null;

		public static OperatingSystemFamily operatingSystemFamily => default(OperatingSystemFamily);

		public static int processorCount => 0;

		public static int systemMemorySize => 0;

		public static string deviceModel => null;

		public static bool supportsAccelerometer => false;

		public static DeviceType deviceType => default(DeviceType);

		public static string graphicsDeviceName => null;

		public static string graphicsDeviceVendor => null;

		public static int graphicsDeviceVendorID => 0;

		public static GraphicsDeviceType graphicsDeviceType => default(GraphicsDeviceType);

		public static bool graphicsUVStartsAtTop => false;

		public static int graphicsShaderLevel => 0;

		public static FoveatedRenderingCaps foveatedRenderingCaps => default(FoveatedRenderingCaps);

		public static bool hasHiddenSurfaceRemovalOnGPU => false;

		public static bool supportsShadows => false;

		public static CopyTextureSupport copyTextureSupport => default(CopyTextureSupport);

		public static bool supportsComputeShaders => false;

		public static bool supportsRenderTargetArrayIndexFromVertexShader => false;

		public static bool supportsInstancing => false;

		public static int supportedRenderTargetCount => 0;

		public static int supportsMultisampledTextures => 0;

		public static bool supportsMultisampledBackBuffer => false;

		public static bool supportsMemorylessTextures => false;

		public static bool supportsMultisampleAutoResolve => false;

		public static bool supportsMultisampledShaderResolve => false;

		public static bool usesReversedZBuffer => false;

		public static int maxTiledPixelStorageSize => 0;

		public static int maxTextureSize => 0;

		internal static int maxRenderTextureSize
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			get
			{
				return 0;
			}
		}

		public static bool supportsGraphicsFence => false;

		public static bool supportsRayTracing => false;

		public static long maxGraphicsBufferSize => 0L;

		public static bool usesLoadStoreActions => false;

		public static HDRDisplaySupportFlags hdrDisplaySupportFlags => default(HDRDisplaySupportFlags);

		public static bool supportsMultiview => false;

		public static bool supportsStoreAndResolveAction => false;

		public static bool supportsMultisampleResolveDepth => false;

		public static bool supportsMultisampleResolveStencil => false;

		public static bool supportsIndirectArgumentsBuffer => false;

		private static bool IsValidEnumValue(Enum value)
		{
			return false;
		}

		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return false;
		}

		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return false;
		}

		[FreeFunction("systeminfo::GetOperatingSystem")]
		private static string GetOperatingSystem()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetOperatingSystemFamily")]
		private static OperatingSystemFamily GetOperatingSystemFamily()
		{
			return default(OperatingSystemFamily);
		}

		[FreeFunction("systeminfo::GetProcessorCount")]
		private static int GetProcessorCount()
		{
			return 0;
		}

		[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
		private static int GetPhysicalMemoryMB()
		{
			return 0;
		}

		[FreeFunction("systeminfo::GetDeviceModel")]
		private static string GetDeviceModel()
		{
			return null;
		}

		[FreeFunction("systeminfo::SupportsAccelerometer")]
		private static bool SupportsAccelerometer()
		{
			return false;
		}

		[FreeFunction("systeminfo::GetDeviceType")]
		private static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
		private static string GetGraphicsDeviceName()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
		private static string GetGraphicsDeviceVendor()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendorID")]
		private static int GetGraphicsDeviceVendorID()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
		private static GraphicsDeviceType GetGraphicsDeviceType()
		{
			return default(GraphicsDeviceType);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
		private static bool GetGraphicsUVStartsAtTop()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
		private static int GetGraphicsShaderLevel()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetFoveatedRenderingCaps")]
		private static FoveatedRenderingCaps GetFoveatedRenderingCaps()
		{
			return default(FoveatedRenderingCaps);
		}

		[FreeFunction("ScriptingGraphicsCaps::HasHiddenSurfaceRemovalOnGPU")]
		private static bool HasHiddenSurfaceRemovalOnGPU()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsShadows")]
		private static bool SupportsShadows()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
		private static CopyTextureSupport GetCopyTextureSupport()
		{
			return default(CopyTextureSupport);
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
		private static bool SupportsComputeShaders()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsRenderTargetArrayIndexFromVertexShader")]
		private static bool SupportsRenderTargetArrayIndexFromVertexShader()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
		private static bool SupportsInstancing()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
		private static int SupportedRenderTargetCount()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledTextures")]
		private static int SupportsMultisampledTextures()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledBackBuffer")]
		private static bool SupportsMultisampledBackBuffer()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMemorylessTextures")]
		private static bool SupportsMemorylessTextures()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleAutoResolve")]
		private static bool SupportsMultisampleAutoResolve()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledShaderResolve")]
		private static bool SupportsMultisampledShaderResolve()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
		private static bool UsesReversedZBuffer()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
		private static bool HasRenderTextureNative(RenderTextureFormat format)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
		private static bool SupportsTextureFormatNative(TextureFormat format)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
		private static int GetMaxTextureSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
		private static int GetMaxRenderTextureSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsGPUFence")]
		private static bool SupportsGPUFence()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsRayTracing")]
		private static bool SupportsRayTracing()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
		private static long MaxGraphicsBufferSize()
		{
			return 0L;
		}

		[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
		public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetRenderTextureSupportedMSAASampleCount")]
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetTiledRenderTargetStorageSize")]
		public static int GetTiledRenderTargetStorageSize(GraphicsFormat format, int sampleCount)
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
		private static bool UsesLoadStoreActions()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetHDRDisplaySupportFlags")]
		private static HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
		{
			return default(HDRDisplaySupportFlags);
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultiview")]
		private static bool SupportsMultiview()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsStoreAndResolveAction")]
		private static bool SupportsStoreAndResolveAction()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveDepth")]
		private static bool SupportsMultisampleResolveDepth()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveStencil")]
		private static bool SupportsMultisampleResolveStencil()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsIndirectArgumentsBuffer")]
		private static bool SupportsIndirectArgumentsBuffer()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::MaxTiledPixelStorageSize")]
		private static int MaxTiledPixelStorageSize()
		{
			return 0;
		}

		private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetDeviceModel_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetGraphicsDeviceName_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetGraphicsDeviceVendor_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static int GetRenderTextureSupportedMSAASampleCount_Injected([In] ref RenderTextureDescriptor desc)
		{
			return 0;
		}
	}
}
