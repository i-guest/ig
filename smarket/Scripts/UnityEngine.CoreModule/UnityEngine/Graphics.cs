using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/CopyTexture.h")]
	[NativeHeader("Runtime/Graphics/ColorGamut.h")]
	[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public class Graphics
	{
		internal static readonly int kMaxDrawMeshInstanceCount;

		internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts;

		[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
		public static GraphicsTier activeTier => default(GraphicsTier);

		public static bool preserveFramebufferAlpha => false;

		public static OpenGLESVersion minOpenGLESVersion => default(OpenGLESVersion);

		[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = true)]
		private static int Internal_GetMaxDrawMeshInstanceCount()
		{
			return 0;
		}

		[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
		[NativeMethod(Name = "GetPreserveFramebufferAlpha")]
		internal static bool GetPreserveFramebufferAlpha()
		{
			return false;
		}

		[NativeMethod(Name = "GetMinOpenGLESVersion")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
		internal static OpenGLESVersion GetMinOpenGLESVersion()
		{
			return default(OpenGLESVersion);
		}

		[FreeFunction("GraphicsScripting::SetNullRT")]
		private static void Internal_SetNullRT()
		{
		}

		[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = true, ThrowsException = true)]
		private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
		}

		[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
		public static void ClearRandomWriteTargets()
		{
		}

		[FreeFunction("CopyTexture")]
		private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
		}

		[FreeFunction("CopyTextureRegion")]
		private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
		}

		[FreeFunction("GraphicsScripting::DrawMeshNow")]
		private static void Internal_DrawMeshNow2([NotNull] Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
		}

		[FreeFunction("GraphicsScripting::DrawTexture")]
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
		{
		}

		[FreeFunction("GraphicsScripting::RenderMeshIndirect")]
		private static void Internal_RenderMeshIndirect(RenderParams rparams, [NotNull] Mesh mesh, [NotNull] GraphicsBuffer argsBuffer, int commandCount, int startCommand)
		{
		}

		[FreeFunction("GraphicsScripting::DrawMesh")]
		private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
		}

		[FreeFunction("GraphicsScripting::DrawMeshInstanced")]
		private static void Internal_DrawMeshInstanced([NotNull] Mesh mesh, int submeshIndex, [NotNull] Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
		}

		[FreeFunction("GraphicsScripting::BlitMaterial")]
		private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull] Material mat, int pass, bool setRT)
		{
		}

		[FreeFunction("GraphicsScripting::Blit")]
		private static void Blit2(Texture source, RenderTexture dest)
		{
		}

		[FreeFunction("GraphicsScripting::Blit")]
		private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
		}

		[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = true, ThrowsException = true)]
		public static void ExecuteCommandBuffer([NotNull] CommandBuffer buffer)
		{
		}

		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		public static void SetRenderTarget(RenderTexture rt, [DefaultValue("0")] int mipLevel, [DefaultValue("CubemapFace.Unknown")] CubemapFace face, [DefaultValue("0")] int depthSlice)
		{
		}

		public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
		}

		public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
		}

		public static void RenderMeshIndirect(in RenderParams rparams, Mesh mesh, GraphicsBuffer argsBuffer, [DefaultValue("1")] int commandCount = 1, [DefaultValue("0")] int startCommand = 0)
		{
		}

		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
		}

		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
		}

		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, [DefaultValue("null")] LightProbeProxyVolume lightProbeProxyVolume)
		{
		}

		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, [DefaultValue("matrices.Length")] int count, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("ShadowCastingMode.On")] ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("0")] int layer, [DefaultValue("null")] Camera camera, [DefaultValue("LightProbeUsage.BlendProbes")] LightProbeUsage lightProbeUsage, [DefaultValue("null")] LightProbeProxyVolume lightProbeProxyVolume)
		{
		}

		public static void Blit(Texture source, RenderTexture dest)
		{
		}

		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
		}

		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
		{
		}

		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
		}

		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
		}

		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count)
		{
		}

		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
		}

		[ExcludeFromDocs]
		public static void SetRenderTarget(RenderTexture rt)
		{
		}

		[ExcludeFromDocs]
		public static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
		}

		private static void Internal_SetRTSimple_Injected([In] ref RenderBuffer color, [In] ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
		}

		private static void CopyTexture_Slice_Injected(IntPtr src, int srcElement, int srcMip, IntPtr dst, int dstElement, int dstMip)
		{
		}

		private static void CopyTexture_Region_Injected(IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, IntPtr dst, int dstElement, int dstMip, int dstX, int dstY)
		{
		}

		private static void Internal_DrawMeshNow2_Injected(IntPtr mesh, int subsetIndex, [In] ref Matrix4x4 matrix)
		{
		}

		private static void Internal_RenderMeshIndirect_Injected([In] ref RenderParams rparams, IntPtr mesh, IntPtr argsBuffer, int commandCount, int startCommand)
		{
		}

		private static void Internal_DrawMesh_Injected(IntPtr mesh, int submeshIndex, [In] ref Matrix4x4 matrix, IntPtr material, int layer, IntPtr camera, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, IntPtr probeAnchor, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume)
		{
		}

		private static void Internal_DrawMeshInstanced_Injected(IntPtr mesh, int submeshIndex, IntPtr material, ref ManagedSpanWrapper matrices, int count, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume)
		{
		}

		private static void Internal_BlitMaterial5_Injected(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT)
		{
		}

		private static void Blit2_Injected(IntPtr source, IntPtr dest)
		{
		}

		private static void Blit4_Injected(IntPtr source, IntPtr dest, [In] ref Vector2 scale, [In] ref Vector2 offset)
		{
		}

		private static void ExecuteCommandBuffer_Injected(IntPtr buffer)
		{
		}
	}
}
