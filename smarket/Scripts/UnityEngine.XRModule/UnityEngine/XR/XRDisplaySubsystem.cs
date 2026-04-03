using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[UsedByNativeCode]
	[NativeConditional("ENABLE_XR")]
	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
	{
		[Flags]
		public enum TextureLayout
		{
			Texture2DArray = 1,
			SingleTexture2D = 2,
			SeparateTexture2Ds = 4
		}

		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		public struct XRRenderParameter
		{
			public Matrix4x4 view;

			public Matrix4x4 projection;

			public Rect viewport;

			public Mesh occlusionMesh;

			public Mesh visibleMesh;

			public int textureArraySlice;

			public Matrix4x4 previousView;

			public bool isPreviousViewValid;
		}

		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
		[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
		public struct XRRenderPass
		{
			private IntPtr displaySubsystemInstance;

			public int renderPassIndex;

			public RenderTargetIdentifier renderTarget;

			public RenderTextureDescriptor renderTargetDesc;

			public int renderTargetScaledWidth;

			public int renderTargetScaledHeight;

			public bool hasMotionVectorPass;

			public RenderTargetIdentifier motionVectorRenderTarget;

			public RenderTextureDescriptor motionVectorRenderTargetDesc;

			public bool shouldFillOutDepth;

			public bool spaceWarpRightHandedNDC;

			public int cullingPassIndex;

			public IntPtr foveatedRenderingInfo;

			[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = true, HasExplicitThis = true, ThrowsException = true)]
			[NativeConditional("ENABLE_XR")]
			public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter)
			{
				renderParameter = default(XRRenderParameter);
			}

			[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = true, HasExplicitThis = true)]
			[NativeConditional("ENABLE_XR")]
			public int GetRenderParameterCount()
			{
				return 0;
			}

			private static void GetRenderParameter_Injected(ref XRRenderPass _unity_self, IntPtr camera, int renderParameterIndex, out XRRenderParameter renderParameter)
			{
				renderParameter = default(XRRenderParameter);
			}
		}

		[NativeHeader("Runtime/Graphics/RenderTexture.h")]
		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		public struct XRBlitParams
		{
			public RenderTexture srcTex;

			public int srcTexArraySlice;

			public Rect srcRect;

			public Rect destRect;

			public IntPtr foveatedRenderingInfo;

			public bool srcHdrEncoded;

			public ColorGamut srcHdrColorGamut;

			public int srcHdrMaxLuminance;
		}

		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		public struct XRMirrorViewBlitDesc
		{
			private IntPtr displaySubsystemInstance;

			public bool nativeBlitAvailable;

			public bool nativeBlitInvalidStates;

			public int blitParamsCount;

			[NativeConditional("ENABLE_XR")]
			[NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = true, HasExplicitThis = true)]
			public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter)
			{
				blitParameter = default(XRBlitParams);
			}
		}

		internal new static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(XRDisplaySubsystem xrDisplaySubsystem)
			{
				return (IntPtr)0;
			}
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<bool> displayFocusChanged;

		private HDROutputSettings m_HDROutputSettings;

		public float appliedViewportScale => 0f;

		public float scaleOfAllRenderTargets
		{
			set
			{
			}
		}

		public float globalDynamicScale => 0f;

		public float zNear
		{
			set
			{
			}
		}

		public float zFar
		{
			set
			{
			}
		}

		public bool sRGB
		{
			set
			{
			}
		}

		public TextureLayout textureLayout
		{
			set
			{
			}
		}

		public bool disableLegacyRenderer
		{
			set
			{
			}
		}

		public HDROutputSettings hdrOutputSettings => null;

		[RequiredByNativeCode]
		private void InvokeDisplayFocusChanged(bool focus)
		{
		}

		public int ScaledTextureWidth(RenderTexture renderTexture)
		{
			return 0;
		}

		public int ScaledTextureHeight(RenderTexture renderTexture)
		{
			return 0;
		}

		public void SetMSAALevel(int level)
		{
		}

		public int GetRenderPassCount()
		{
			return 0;
		}

		public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
		{
			renderPass = default(XRRenderPass);
		}

		[NativeMethod("TryGetRenderPass")]
		private bool Internal_TryGetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
		{
			renderPass = default(XRRenderPass);
			return false;
		}

		public void EndRecordingIfLateLatched(Camera camera)
		{
		}

		[NativeMethod("TryEndRecordingIfLateLatched")]
		private bool Internal_TryEndRecordingIfLateLatched(Camera camera)
		{
			return false;
		}

		public void BeginRecordingIfLateLatched(Camera camera)
		{
		}

		[NativeMethod("TryBeginRecordingIfLateLatched")]
		private bool Internal_TryBeginRecordingIfLateLatched(Camera camera)
		{
			return false;
		}

		public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
		{
			scriptableCullingParameters = default(ScriptableCullingParameters);
		}

		[NativeMethod("TryGetCullingParams")]
		[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
		private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
		{
			scriptableCullingParameters = default(ScriptableCullingParameters);
			return false;
		}

		[NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = false)]
		[NativeConditional("ENABLE_XR")]
		public int GetPreferredMirrorBlitMode()
		{
			return 0;
		}

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "SetPreferredMirrorViewBlitMode", IsThreadSafe = false)]
		public void SetPreferredMirrorBlitMode(int blitMode)
		{
		}

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = false)]
		public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode)
		{
			outDesc = default(XRMirrorViewBlitDesc);
			return false;
		}

		[NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = false)]
		[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
		[NativeConditional("ENABLE_XR")]
		public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode)
		{
			return false;
		}

		private static float get_appliedViewportScale_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_scaleOfAllRenderTargets_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_globalDynamicScale_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_zNear_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_zFar_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_sRGB_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_textureLayout_Injected(IntPtr _unity_self, TextureLayout value)
		{
		}

		private static int ScaledTextureWidth_Injected(IntPtr _unity_self, IntPtr renderTexture)
		{
			return 0;
		}

		private static int ScaledTextureHeight_Injected(IntPtr _unity_self, IntPtr renderTexture)
		{
			return 0;
		}

		private static void SetMSAALevel_Injected(IntPtr _unity_self, int level)
		{
		}

		private static void set_disableLegacyRenderer_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static int GetRenderPassCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static bool Internal_TryGetRenderPass_Injected(IntPtr _unity_self, int renderPassIndex, out XRRenderPass renderPass)
		{
			renderPass = default(XRRenderPass);
			return false;
		}

		private static bool Internal_TryEndRecordingIfLateLatched_Injected(IntPtr _unity_self, IntPtr camera)
		{
			return false;
		}

		private static bool Internal_TryBeginRecordingIfLateLatched_Injected(IntPtr _unity_self, IntPtr camera)
		{
			return false;
		}

		private static bool Internal_TryGetCullingParams_Injected(IntPtr _unity_self, IntPtr camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
		{
			scriptableCullingParameters = default(ScriptableCullingParameters);
			return false;
		}

		private static int GetPreferredMirrorBlitMode_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void SetPreferredMirrorBlitMode_Injected(IntPtr _unity_self, int blitMode)
		{
		}

		private static bool GetMirrorViewBlitDesc_Injected(IntPtr _unity_self, IntPtr mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode)
		{
			outDesc = default(XRMirrorViewBlitDesc);
			return false;
		}

		private static bool AddGraphicsThreadMirrorViewBlit_Injected(IntPtr _unity_self, IntPtr cmd, bool allowGraphicsStateInvalidate, int mode)
		{
			return false;
		}
	}
}
