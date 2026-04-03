using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/RenderManager.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
	[UsedByNativeCode]
	public sealed class Camera : Behaviour
	{
		public enum GateFitMode
		{
			Vertical = 1,
			Horizontal = 2,
			Fill = 3,
			Overscan = 4,
			None = 0
		}

		public enum StereoscopicEye
		{
			Left = 0,
			Right = 1
		}

		public enum MonoOrStereoscopicEye
		{
			Left = 0,
			Right = 1,
			Mono = 2
		}

		public enum SceneViewFilterMode
		{
			Off = 0,
			ShowFiltered = 1
		}

		public delegate void CameraCallback(Camera cam);

		public const float kMinAperture = 0.7f;

		public const float kMaxAperture = 32f;

		public const int kMinBladeCount = 3;

		public const int kMaxBladeCount = 11;

		internal uint m_NonSerializedVersion;

		public static CameraCallback onPreCull;

		public static CameraCallback onPreRender;

		public static CameraCallback onPostRender;

		[NativeProperty("Near")]
		public float nearClipPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("Far")]
		public float farClipPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("VerticalFieldOfView")]
		public float fieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RenderingPath renderingPath
		{
			get
			{
				return default(RenderingPath);
			}
			set
			{
			}
		}

		public RenderingPath actualRenderingPath
		{
			[NativeName("CalculateRenderingPath")]
			get
			{
				return default(RenderingPath);
			}
		}

		public bool allowHDR
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowMSAA => false;

		public bool allowDynamicResolution => false;

		[NativeProperty("ForceIntoRT")]
		public bool forceIntoRenderTexture
		{
			set
			{
			}
		}

		public float orthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OpaqueSortMode opaqueSortMode
		{
			get
			{
				return default(OpaqueSortMode);
			}
			set
			{
			}
		}

		public TransparencySortMode transparencySortMode
		{
			get
			{
				return default(TransparencySortMode);
			}
			set
			{
			}
		}

		public float depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aspect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int cullingMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int eventMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool layerCullSpherical
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("LayerCullSpherical")]
		internal bool layerCullSphericalInternal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CameraType cameraType
		{
			get
			{
				return default(CameraType);
			}
			set
			{
			}
		}

		public float[] layerCullDistances
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useOcclusionCulling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Matrix4x4 cullingMatrix => default(Matrix4x4);

		public Color backgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public CameraClearFlags clearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		public DepthTextureMode depthTextureMode
		{
			get
			{
				return default(DepthTextureMode);
			}
			set
			{
			}
		}

		public bool clearStencilAfterLightingPass
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool usePhysicalProperties
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float focusDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float focalLength
		{
			set
			{
			}
		}

		public Vector2 sensorSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 lensShift
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public GateFitMode gateFit
		{
			get
			{
				return default(GateFitMode);
			}
			set
			{
			}
		}

		[NativeProperty("NormalizedViewportRect")]
		public Rect rect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		[NativeProperty("ScreenViewportRect")]
		public Rect pixelRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public int pixelWidth
		{
			[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public int pixelHeight
		{
			[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public int scaledPixelWidth
		{
			[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public int scaledPixelHeight
		{
			[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RenderTexture activeTexture
		{
			[NativeName("GetCurrentTargetTexture")]
			get
			{
				return null;
			}
		}

		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Matrix4x4 cameraToWorldMatrix => default(Matrix4x4);

		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		public Matrix4x4 projectionMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		public Matrix4x4 nonJitteredProjectionMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
		public bool useJitteredProjectionMatrixForTransparentRendering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static Camera main
		{
			[FreeFunction("FindMainCamera")]
			get
			{
				return null;
			}
		}

		public static Camera current => null;

		private static Camera currentInternal
		{
			[FreeFunction("GetCurrentCameraPPtr")]
			get
			{
				return null;
			}
		}

		public float stereoSeparation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float stereoConvergence
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public StereoTargetEyeMask stereoTargetEye
		{
			get
			{
				return default(StereoTargetEyeMask);
			}
			set
			{
			}
		}

		[NativeProperty("StereoTargetEye")]
		internal StereoTargetEyeMask stereoTargetEyeInternal
		{
			get
			{
				return default(StereoTargetEyeMask);
			}
			set
			{
			}
		}

		public static int allCamerasCount => 0;

		public static Camera[] allCameras => null;

		[NativeConditional("UNITY_EDITOR")]
		public SceneViewFilterMode sceneViewFilterMode => default(SceneViewFilterMode);

		public bool isProcessingRenderRequest
		{
			[NativeMethod("IsProcessingRenderRequest")]
			get
			{
				return false;
			}
		}

		[FreeFunction("CameraScripting::GetLayerCullDistances", HasExplicitThis = true)]
		private float[] GetLayerCullDistances()
		{
			return null;
		}

		[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = true)]
		private void SetLayerCullDistances([NotNull] float[] d)
		{
		}

		public void ResetWorldToCameraMatrix()
		{
		}

		public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ViewportToScreenPoint(Vector3 position)
		{
			return default(Vector3);
		}

		private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ViewportPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ScreenPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		[NativeName("FieldOfViewToFocalLength_Safe")]
		public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
		{
			return 0f;
		}

		public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix)
		{
		}

		public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix)
		{
		}

		[FreeFunction("CameraScripting::GetAllCamerasCount")]
		private static int GetAllCamerasCount()
		{
			return 0;
		}

		[FreeFunction("CameraScripting::GetAllCameras")]
		private static int GetAllCamerasImpl([Out][NotNull] Camera[] cam)
		{
			return 0;
		}

		public static int GetAllCameras(Camera[] cameras)
		{
			return 0;
		}

		[NativeConditional("UNITY_EDITOR")]
		private int GetFilterMode()
		{
			return 0;
		}

		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		public void Render()
		{
		}

		[FreeFunction("CameraScripting::SetupCurrent")]
		public static void SetupCurrent(Camera cur)
		{
		}

		[NativeName("AddCommandBuffer")]
		private void AddCommandBufferImpl(CameraEvent evt, [NotNull] CommandBuffer buffer)
		{
		}

		[NativeName("RemoveCommandBuffer")]
		private void RemoveCommandBufferImpl(CameraEvent evt, [NotNull] CommandBuffer buffer)
		{
		}

		public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer)
		{
		}

		public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPreCull(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPreRender(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPostRender(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void BumpNonSerializedVersion(Camera cam)
		{
		}

		public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters)
		{
			cullingParameters = default(ScriptableCullingParameters);
			return false;
		}

		[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
		[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
		private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
		{
			cullingParameters = default(ScriptableCullingParameters);
			return false;
		}

		private static float get_nearClipPlane_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_farClipPlane_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_farClipPlane_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_fieldOfView_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_fieldOfView_Injected(IntPtr _unity_self, float value)
		{
		}

		private static RenderingPath get_renderingPath_Injected(IntPtr _unity_self)
		{
			return default(RenderingPath);
		}

		private static void set_renderingPath_Injected(IntPtr _unity_self, RenderingPath value)
		{
		}

		private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self)
		{
			return default(RenderingPath);
		}

		private static bool get_allowHDR_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_allowHDR_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_allowMSAA_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_forceIntoRenderTexture_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_orthographicSize_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_orthographicSize_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_orthographic_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_orthographic_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static OpaqueSortMode get_opaqueSortMode_Injected(IntPtr _unity_self)
		{
			return default(OpaqueSortMode);
		}

		private static void set_opaqueSortMode_Injected(IntPtr _unity_self, OpaqueSortMode value)
		{
		}

		private static TransparencySortMode get_transparencySortMode_Injected(IntPtr _unity_self)
		{
			return default(TransparencySortMode);
		}

		private static void set_transparencySortMode_Injected(IntPtr _unity_self, TransparencySortMode value)
		{
		}

		private static float get_depth_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_depth_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_aspect_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_aspect_Injected(IntPtr _unity_self, float value)
		{
		}

		private static int get_cullingMask_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_cullingMask_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_eventMask_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_eventMask_Injected(IntPtr _unity_self, int value)
		{
		}

		private static bool get_layerCullSphericalInternal_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_layerCullSphericalInternal_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static CameraType get_cameraType_Injected(IntPtr _unity_self)
		{
			return default(CameraType);
		}

		private static void set_cameraType_Injected(IntPtr _unity_self, CameraType value)
		{
		}

		private static void GetLayerCullDistances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void SetLayerCullDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper d)
		{
		}

		private static bool get_useOcclusionCulling_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useOcclusionCulling_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void get_cullingMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret)
		{
			ret = default(Color);
		}

		private static void set_backgroundColor_Injected(IntPtr _unity_self, [In] ref Color value)
		{
		}

		private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self)
		{
			return default(CameraClearFlags);
		}

		private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value)
		{
		}

		private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self)
		{
			return default(DepthTextureMode);
		}

		private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value)
		{
		}

		private static bool get_clearStencilAfterLightingPass_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_clearStencilAfterLightingPass_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_focusDistance_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_focusDistance_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_focalLength_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void get_sensorSize_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_sensorSize_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void get_lensShift_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_lensShift_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static GateFitMode get_gateFit_Injected(IntPtr _unity_self)
		{
			return default(GateFitMode);
		}

		private static void set_gateFit_Injected(IntPtr _unity_self, GateFitMode value)
		{
		}

		private static void get_rect_Injected(IntPtr _unity_self, out Rect ret)
		{
			ret = default(Rect);
		}

		private static void set_rect_Injected(IntPtr _unity_self, [In] ref Rect value)
		{
		}

		private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret)
		{
			ret = default(Rect);
		}

		private static void set_pixelRect_Injected(IntPtr _unity_self, [In] ref Rect value)
		{
		}

		private static int get_pixelWidth_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_pixelHeight_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_scaledPixelWidth_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_scaledPixelHeight_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static IntPtr get_targetTexture_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static IntPtr get_activeTexture_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static int get_targetDisplay_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_targetDisplay_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void get_cameraToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void set_worldToCameraMatrix_Injected(IntPtr _unity_self, [In] ref Matrix4x4 value)
		{
		}

		private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void set_projectionMatrix_Injected(IntPtr _unity_self, [In] ref Matrix4x4 value)
		{
		}

		private static void get_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, [In] ref Matrix4x4 value)
		{
		}

		private static bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void ResetWorldToCameraMatrix_Injected(IntPtr _unity_self)
		{
		}

		private static void WorldToScreenPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void WorldToViewportPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void ViewportToScreenPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void ViewportPointToRay_Injected(IntPtr _unity_self, [In] ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
		{
			ret = default(Ray);
		}

		private static void ScreenPointToRay_Injected(IntPtr _unity_self, [In] ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
		{
			ret = default(Ray);
		}

		private static IntPtr get_main_Injected()
		{
			return (IntPtr)0;
		}

		private static IntPtr get_currentInternal_Injected()
		{
			return (IntPtr)0;
		}

		private static float get_stereoSeparation_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_stereoSeparation_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_stereoConvergence_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_stereoConvergence_Injected(IntPtr _unity_self, float value)
		{
		}

		private static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(IntPtr _unity_self)
		{
			return default(StereoTargetEyeMask);
		}

		private static void set_stereoTargetEyeInternal_Injected(IntPtr _unity_self, StereoTargetEyeMask value)
		{
		}

		private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, [In] ref Matrix4x4 matrix)
		{
		}

		private static void SetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, [In] ref Matrix4x4 matrix)
		{
		}

		private static int GetAllCamerasImpl_Injected([Out] Camera[] cam)
		{
			return 0;
		}

		private static int GetFilterMode_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void Render_Injected(IntPtr _unity_self)
		{
		}

		private static bool get_isProcessingRenderRequest_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void SetupCurrent_Injected(IntPtr cur)
		{
		}

		private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer)
		{
		}

		private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer)
		{
		}

		private static bool GetCullingParameters_Internal_Injected(IntPtr camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
		{
			cullingParameters = default(ScriptableCullingParameters);
			return false;
		}
	}
}
