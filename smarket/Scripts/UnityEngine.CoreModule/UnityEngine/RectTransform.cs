using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("UI::RectTransform")]
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	public sealed class RectTransform : Transform
	{
		public enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		public delegate void ReapplyDrivenProperties(RectTransform driven);

		public Rect rect => default(Rect);

		public Vector2 anchorMin
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 anchorMax
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 anchoredPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 sizeDelta
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 pivot
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector3 anchoredPosition3D
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector2 offsetMin
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 offsetMax
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool sendChildDimensionsChange
		{
			set
			{
			}
		}

		public static event ReapplyDrivenProperties reapplyDrivenProperties
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

		[NativeMethod("UpdateIfTransformDispatchIsDirty")]
		public void ForceUpdateRectTransforms()
		{
		}

		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
		}

		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
		}

		public void SetSizeWithCurrentAnchors(Axis axis, float size)
		{
		}

		[RequiredByNativeCode]
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
		}

		private Vector2 GetParentSize()
		{
			return default(Vector2);
		}

		private static void get_rect_Injected(IntPtr _unity_self, out Rect ret)
		{
			ret = default(Rect);
		}

		private static void get_anchorMin_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_anchorMin_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void get_anchorMax_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_anchorMax_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void get_anchoredPosition_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_anchoredPosition_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void get_sizeDelta_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_sizeDelta_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_pivot_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static void set_sendChildDimensionsChange_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void ForceUpdateRectTransforms_Injected(IntPtr _unity_self)
		{
		}
	}
}
