using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/UI/UIStructs.h")]
	[NativeClass("UI::Canvas")]
	[RequireComponent(typeof(RectTransform))]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	public sealed class Canvas : Behaviour
	{
		public delegate void WillRenderCanvases();

		public RenderMode renderMode
		{
			get
			{
				return default(RenderMode);
			}
			set
			{
			}
		}

		public bool isRootCanvas => false;

		public Rect pixelRect => default(Rect);

		public float scaleFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float referencePixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool pixelPerfect => false;

		public float planeDistance
		{
			set
			{
			}
		}

		public int renderOrder => 0;

		public bool overrideSorting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int targetDisplay => 0;

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public AdditionalCanvasShaderChannels additionalShaderChannels
		{
			get
			{
				return default(AdditionalCanvasShaderChannels);
			}
			set
			{
			}
		}

		public Canvas rootCanvas => null;

		public Vector2 renderingDisplaySize => default(Vector2);

		internal static Action<int> externBeginRenderOverlays
		{
			get; [VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			set;
		}

		internal static Action<int, int> externRenderOverlaysBefore
		{
			get; [VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			set;
		}

		internal static Action<int> externEndRenderOverlays
		{
			get; [VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			set;
		}

		[NativeProperty("Camera", false, TargetType.Function)]
		public Camera worldCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event WillRenderCanvases preWillRenderCanvases
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event WillRenderCanvases willRenderCanvases
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
		internal static void SetExternalCanvasEnabled(bool enabled)
		{
		}

		[FreeFunction("UI::GetDefaultUIMaterial")]
		public static Material GetDefaultCanvasMaterial()
		{
			return null;
		}

		[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
		public static Material GetETC1SupportedCanvasMaterial()
		{
			return null;
		}

		public static void ForceUpdateCanvases()
		{
		}

		[RequiredByNativeCode]
		private static void SendPreWillRenderCanvases()
		{
		}

		[RequiredByNativeCode]
		private static void SendWillRenderCanvases()
		{
		}

		[RequiredByNativeCode]
		private static void BeginRenderExtraOverlays(int displayIndex)
		{
		}

		[RequiredByNativeCode]
		private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
		{
		}

		[RequiredByNativeCode]
		private static void EndRenderExtraOverlays(int displayIndex)
		{
		}

		private static RenderMode get_renderMode_Injected(IntPtr _unity_self)
		{
			return default(RenderMode);
		}

		private static void set_renderMode_Injected(IntPtr _unity_self, RenderMode value)
		{
		}

		private static bool get_isRootCanvas_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret)
		{
			ret = default(Rect);
		}

		private static float get_scaleFactor_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_scaleFactor_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_pixelPerfect_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_planeDistance_Injected(IntPtr _unity_self, float value)
		{
		}

		private static int get_renderOrder_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static bool get_overrideSorting_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static int get_sortingOrder_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_sortingOrder_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_targetDisplay_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_sortingLayerID_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value)
		{
		}

		private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self)
		{
			return default(AdditionalCanvasShaderChannels);
		}

		private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value)
		{
		}

		private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static IntPtr get_worldCamera_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_worldCamera_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static IntPtr GetDefaultCanvasMaterial_Injected()
		{
			return (IntPtr)0;
		}

		private static IntPtr GetETC1SupportedCanvasMaterial_Injected()
		{
			return (IntPtr)0;
		}
	}
}
