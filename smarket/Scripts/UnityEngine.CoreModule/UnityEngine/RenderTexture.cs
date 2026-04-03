using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public class RenderTexture : Texture
	{
		public override int width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override TextureDimension dimension
		{
			get
			{
				return default(TextureDimension);
			}
			set
			{
			}
		}

		public new GraphicsFormat graphicsFormat
		{
			get
			{
				return default(GraphicsFormat);
			}
			set
			{
			}
		}

		[NativeProperty("MipMap")]
		public bool useMipMap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("SRGBReadWrite")]
		public bool sRGB => false;

		[NativeProperty("VRUsage")]
		public VRTextureUsage vrUsage
		{
			set
			{
			}
		}

		[NativeProperty("Memoryless")]
		public RenderTextureMemoryless memorylessMode
		{
			set
			{
			}
		}

		public RenderTextureFormat format
		{
			get
			{
				return default(RenderTextureFormat);
			}
			set
			{
			}
		}

		public GraphicsFormat stencilFormat
		{
			set
			{
			}
		}

		public GraphicsFormat depthStencilFormat
		{
			get
			{
				return default(GraphicsFormat);
			}
			set
			{
			}
		}

		public bool autoGenerateMips
		{
			set
			{
			}
		}

		public int volumeDepth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int antiAliasing
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool bindTextureMS
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableRandomWrite
		{
			set
			{
			}
		}

		public bool useDynamicScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useDynamicScaleExplicit => false;

		public bool enableShadingRate => false;

		public bool isPowerOfTwo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static RenderTexture active
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RenderBuffer colorBuffer => default(RenderBuffer);

		public RenderBuffer depthBuffer => default(RenderBuffer);

		public int depth
		{
			[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = true)]
			set
			{
			}
		}

		public RenderTextureDescriptor descriptor
		{
			get
			{
				return default(RenderTextureDescriptor);
			}
			set
			{
			}
		}

		[NativeName("GetColorFormat")]
		private GraphicsFormat GetColorFormat(bool suppressWarnings)
		{
			return default(GraphicsFormat);
		}

		[NativeName("SetColorFormat")]
		private void SetColorFormat(GraphicsFormat format)
		{
		}

		public void ApplyDynamicScale()
		{
		}

		private bool GetIsPowerOfTwo()
		{
			return false;
		}

		[FreeFunction("RenderTexture::GetActiveAsRenderTexture")]
		private static RenderTexture GetActive()
		{
			return null;
		}

		[FreeFunction("RenderTextureScripting::SetActive")]
		private static void SetActive(RenderTexture rt)
		{
		}

		[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = true)]
		private RenderBuffer GetColorBuffer()
		{
			return default(RenderBuffer);
		}

		[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = true)]
		private RenderBuffer GetDepthBuffer()
		{
			return default(RenderBuffer);
		}

		private void SetMipMapCount(int count)
		{
		}

		internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode)
		{
		}

		public void DiscardContents(bool discardColor, bool discardDepth)
		{
		}

		public void DiscardContents()
		{
		}

		public bool Create()
		{
			return false;
		}

		public void Release()
		{
		}

		internal void SetSRGBReadWrite(bool srgb)
		{
		}

		[FreeFunction("RenderTextureScripting::Create")]
		private static void Internal_Create([Writable] RenderTexture rt)
		{
		}

		[NativeName("SetRenderTextureDescFromScript")]
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
		}

		[NativeName("GetRenderTextureDesc")]
		private RenderTextureDescriptor GetDescriptor()
		{
			return default(RenderTextureDescriptor);
		}

		[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
		private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			return null;
		}

		[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
		public static void ReleaseTemporary(RenderTexture temp)
		{
		}

		[RequiredByNativeCode]
		protected internal RenderTexture()
		{
		}

		public RenderTexture(RenderTextureDescriptor desc)
		{
		}

		public RenderTexture(RenderTexture textureToCopy)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, DefaultFormat format)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
		}

		public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth)
		{
		}

		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
		{
		}

		private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
		}

		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = false)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, ShadowSamplingMode shadowSamplingMode)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
		{
			return default(GraphicsFormat);
		}

		private static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc)
		{
		}

		internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth)
		{
			return default(GraphicsFormat);
		}

		internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format)
		{
			return default(ShadowSamplingMode);
		}

		internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format)
		{
			return default(ShadowSamplingMode);
		}

		internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format)
		{
		}

		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			return default(GraphicsFormat);
		}

		public static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			return null;
		}

		private static int get_width_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_width_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_height_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_height_Injected(IntPtr _unity_self, int value)
		{
		}

		private static TextureDimension get_dimension_Injected(IntPtr _unity_self)
		{
			return default(TextureDimension);
		}

		private static void set_dimension_Injected(IntPtr _unity_self, TextureDimension value)
		{
		}

		private static GraphicsFormat GetColorFormat_Injected(IntPtr _unity_self, bool suppressWarnings)
		{
			return default(GraphicsFormat);
		}

		private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format)
		{
		}

		private static bool get_useMipMap_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useMipMap_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_sRGB_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_vrUsage_Injected(IntPtr _unity_self, VRTextureUsage value)
		{
		}

		private static void set_memorylessMode_Injected(IntPtr _unity_self, RenderTextureMemoryless value)
		{
		}

		private static void set_stencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value)
		{
		}

		private static GraphicsFormat get_depthStencilFormat_Injected(IntPtr _unity_self)
		{
			return default(GraphicsFormat);
		}

		private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value)
		{
		}

		private static void set_autoGenerateMips_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static int get_volumeDepth_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_volumeDepth_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_antiAliasing_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_antiAliasing_Injected(IntPtr _unity_self, int value)
		{
		}

		private static bool get_bindTextureMS_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_bindTextureMS_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_enableRandomWrite_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_useDynamicScale_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useDynamicScale_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_useDynamicScaleExplicit_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_enableShadingRate_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void ApplyDynamicScale_Injected(IntPtr _unity_self)
		{
		}

		private static bool GetIsPowerOfTwo_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static IntPtr GetActive_Injected()
		{
			return (IntPtr)0;
		}

		private static void SetActive_Injected(IntPtr rt)
		{
		}

		private static void GetColorBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret)
		{
			ret = default(RenderBuffer);
		}

		private static void GetDepthBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret)
		{
			ret = default(RenderBuffer);
		}

		private static void SetMipMapCount_Injected(IntPtr _unity_self, int count)
		{
		}

		private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode)
		{
		}

		private static void DiscardContents_Injected(IntPtr _unity_self, bool discardColor, bool discardDepth)
		{
		}

		private static bool Create_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void Release_Injected(IntPtr _unity_self)
		{
		}

		private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb)
		{
		}

		private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, [In] ref RenderTextureDescriptor desc)
		{
		}

		private static void GetDescriptor_Injected(IntPtr _unity_self, out RenderTextureDescriptor ret)
		{
			ret = default(RenderTextureDescriptor);
		}

		private static IntPtr GetTemporary_Internal_Injected([In] ref RenderTextureDescriptor desc)
		{
			return (IntPtr)0;
		}

		private static void ReleaseTemporary_Injected(IntPtr temp)
		{
		}

		private static void set_depth_Injected(IntPtr _unity_self, int value)
		{
		}
	}
}
