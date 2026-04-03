using System;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering
{
	public static class XRSystem
	{
		private static XRLayoutStack s_Layout;

		private static Func<XRPassCreateInfo, XRPass> s_PassAllocator;

		private static List<XRDisplaySubsystem> s_DisplayList;

		private static XRDisplaySubsystem s_Display;

		private static MSAASamples s_MSAASamples;

		private static float s_OcclusionMeshScaling;

		private static bool s_UseVisibilityMesh;

		private static Material s_OcclusionMeshMaterial;

		private static Material s_MirrorViewMaterial;

		private static Action<XRLayout, Camera> s_LayoutOverride;

		public static readonly XRPass emptyPass;

		public static bool displayActive => false;

		public static bool isHDRDisplayOutputActive => false;

		public static bool singlePassAllowed { get; set; }

		public static FoveatedRenderingCaps foveatedRenderingCaps { get; set; }

		public static bool dumpDebugInfo { get; set; }

		public static XRDisplaySubsystem GetActiveDisplay()
		{
			return null;
		}

		public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS)
		{
		}

		public static void SetDisplayMSAASamples(MSAASamples msaaSamples)
		{
		}

		public static MSAASamples GetDisplayMSAASamples()
		{
			return default(MSAASamples);
		}

		internal static void SetOcclusionMeshScale(float occlusionMeshScale)
		{
		}

		internal static float GetOcclusionMeshScale()
		{
			return 0f;
		}

		internal static void SetUseVisibilityMesh(bool useVisibilityMesh)
		{
		}

		internal static bool GetUseVisibilityMesh()
		{
			return false;
		}

		internal static void SetMirrorViewMode(int mirrorBlitMode)
		{
		}

		internal static int GetMirrorViewMode()
		{
			return 0;
		}

		public static void SetRenderScale(float renderScale)
		{
		}

		public static float GetRenderViewportScale()
		{
			return 0f;
		}

		public static float GetDynamicResolutionScale()
		{
			return 0f;
		}

		public static int ScaleTextureWidthForXR(RenderTexture texture)
		{
			return 0;
		}

		public static int ScaleTextureHeightForXR(RenderTexture texture)
		{
			return 0;
		}

		public static XRLayout NewLayout()
		{
			return null;
		}

		public static void EndLayout()
		{
		}

		public static void RenderMirrorView(CommandBuffer cmd, Camera camera)
		{
		}

		public static void Dispose()
		{
		}

		internal static void SetDisplayZRange(float zNear, float zFar)
		{
		}

		private static void SetLayoutOverride(Action<XRLayout, Camera> action)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void XRSystemInit()
		{
		}

		private static void RefreshDeviceInfo()
		{
		}

		internal static void CreateDefaultLayout(Camera camera, XRLayout layout)
		{
		}

		internal static void ReconfigurePass(XRPass xrPass, Camera camera)
		{
		}

		private static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass)
		{
			return false;
		}

		private static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter)
		{
			return default(XRView);
		}

		private static RenderTextureDescriptor XrRenderTextureDescToUnityRenderTextureDesc(RenderTextureDescriptor xrDesc)
		{
			return default(RenderTextureDescriptor);
		}

		private static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters, XRLayout layout, bool isLastPass)
		{
			return default(XRPassCreateInfo);
		}
	}
}
