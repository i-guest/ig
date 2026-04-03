using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	public sealed class LensFlareCommonSRP
	{
		internal class LensFlareCompInfo
		{
			internal int index;

			internal LensFlareComponentSRP comp;

			internal LensFlareCompInfo(int idx, LensFlareComponentSRP cmp)
			{
			}
		}

		private static LensFlareCommonSRP m_Instance;

		private static readonly object m_Padlock;

		private static List<LensFlareCompInfo> m_Data;

		private static List<int> m_AvailableIndicies;

		public static int maxLensFlareWithOcclusion;

		public static int maxLensFlareWithOcclusionTemporalSample;

		public static int mergeNeeded;

		public static RTHandle occlusionRT;

		private static int frameIdx;

		internal static readonly int _FlareOcclusionPermutation;

		internal static readonly int _FlareOcclusionRemapTex;

		internal static readonly int _FlareOcclusionTex;

		internal static readonly int _FlareOcclusionIndex;

		internal static readonly int _FlareCloudOpacity;

		internal static readonly int _FlareSunOcclusionTex;

		internal static readonly int _FlareTex;

		internal static readonly int _FlareColorValue;

		internal static readonly int _FlareData0;

		internal static readonly int _FlareData1;

		internal static readonly int _FlareData2;

		internal static readonly int _FlareData3;

		internal static readonly int _FlareData4;

		internal static readonly int _FlareData5;

		internal static readonly int _FlareData6;

		internal static readonly int _FlareRadialTint;

		internal static readonly int _ViewId;

		internal static readonly int _LensFlareScreenSpaceBloomMipTexture;

		internal static readonly int _LensFlareScreenSpaceResultTexture;

		internal static readonly int _LensFlareScreenSpaceSpectralLut;

		internal static readonly int _LensFlareScreenSpaceStreakTex;

		internal static readonly int _LensFlareScreenSpaceMipLevel;

		internal static readonly int _LensFlareScreenSpaceTintColor;

		internal static readonly int _LensFlareScreenSpaceParams1;

		internal static readonly int _LensFlareScreenSpaceParams2;

		internal static readonly int _LensFlareScreenSpaceParams3;

		internal static readonly int _LensFlareScreenSpaceParams4;

		internal static readonly int _LensFlareScreenSpaceParams5;

		private static readonly bool s_SupportsLensFlare16bitsFormat;

		private static readonly bool s_SupportsLensFlare32bitsFormat;

		private static readonly bool s_SupportsLensFlare16bitsFormatWithLoadStore;

		private static readonly bool s_SupportsLensFlare32bitsFormatWithLoadStore;

		private static bool requireOcclusionRTRandomWrite => false;

		public static LensFlareCommonSRP Instance => null;

		private List<LensFlareCompInfo> Data => null;

		private LensFlareCommonSRP()
		{
		}

		private static bool CheckOcclusionBasedOnDeviceType()
		{
			return false;
		}

		public static bool IsOcclusionRTCompatible()
		{
			return false;
		}

		private static GraphicsFormat GetOcclusionRTFormat()
		{
			return default(GraphicsFormat);
		}

		public static void Initialize()
		{
		}

		public static void Dispose()
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		private int GetNextAvailableIndex()
		{
			return 0;
		}

		public void AddData(LensFlareComponentSRP newData)
		{
		}

		public void RemoveData(LensFlareComponentSRP data)
		{
		}

		public static float ShapeAttenuationPointLight()
		{
			return 0f;
		}

		public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo)
		{
			return 0f;
		}

		public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01)
		{
			return 0f;
		}

		public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo)
		{
			return 0f;
		}

		public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo)
		{
			return 0f;
		}

		public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam)
		{
			return 0f;
		}

		private static float ShapeAttenuateForwardLight(Vector3 forward, Vector3 wo)
		{
			return 0f;
		}

		public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo)
		{
			return 0f;
		}

		public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo)
		{
			return 0f;
		}

		private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data)
		{
			return false;
		}

		private static Vector4 InternalGetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate)
		{
			return default(Vector4);
		}

		[Obsolete("This is now deprecated as a public API. Call ComputeOcclusion() or DoLensFlareDataDrivenCommon() instead. #from(6000.3)")]
		public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate)
		{
			return default(Vector4);
		}

		private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0)
		{
			return default(Vector2);
		}

		private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS)
		{
			return default(Vector3);
		}

		private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS)
		{
			return default(Vector3);
		}

		private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS)
		{
			return default(Vector3);
		}

		public static bool IsCloudLayerOpacityNeeded(Camera cam)
		{
			return false;
		}

		public static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
		{
		}

		private static bool ForceSingleElement(LensFlareDataElementSRP element)
		{
			return false;
		}

		private static bool PreDrawSetup(bool occlusionOnly, bool clearRenderTarget, RenderTargetIdentifier rt, Camera cam, XRPass xr, int xrIndex, CommandBuffer cmd)
		{
			return false;
		}

		private static bool DoComponent(bool occlusionOnly, LensFlareCompInfo info, Camera cam, Vector3 cameraPositionWS, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Matrix4x4 viewProjMatrix, CommandBuffer cmd, out Vector3 flarePosWS, out Vector3 flarePosViewport, out Vector2 flarePosScreen, out Vector3 camToFlare, out Light light, out bool isDirLight, out float flareIntensity, out float distanceAttenuation)
		{
			flarePosWS = default(Vector3);
			flarePosViewport = default(Vector3);
			flarePosScreen = default(Vector2);
			camToFlare = default(Vector3);
			light = null;
			isDirLight = default(bool);
			flareIntensity = default(float);
			distanceAttenuation = default(float);
			return false;
		}

		public static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
		{
		}

		public static void ProcessLensFlareSRPElementsSingle(LensFlareDataElementSRP element, CommandBuffer cmd, Color globalColorModulation, Light light, float compIntensity, float scale, Material lensFlareShader, Vector2 screenPos, bool compAllowOffScreen, Vector2 vScreenRatio, Vector3 flareData1, bool preview, int depth)
		{
		}

		private static void ProcessLensFlareSRPElements(ref LensFlareDataElementSRP[] elements, CommandBuffer cmd, Color globalColorModulation, Light light, float compIntensity, float scale, Material lensFlareShader, Vector2 screenPos, bool compAllowOffScreen, float aspect, Vector4 flareData6, bool preview, int depth)
		{
		}

		public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, bool debugView)
		{
		}

		public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, bool debugView)
		{
		}

		public static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, UnsafeCommandBuffer cmd, RTHandle result, bool debugView)
		{
		}

		public static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, CommandBuffer cmd, RTHandle result, bool debugView)
		{
		}

		private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance)
		{
			return default(Vector2);
		}

		private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView)
		{
			return default(Vector2);
		}

		private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d)
		{
			return default(Vector2);
		}

		private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d)
		{
			return default(Vector2);
		}
	}
}
