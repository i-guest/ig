using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode]
	[NativeHeader("Modules/IMGUI/GUIStyle.h")]
	public class RectOffset : IFormattable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(RectOffset rectOffset)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		internal IntPtr m_Ptr;

		private readonly object m_SourceStyle;

		[NativeProperty("left", false, TargetType.Field)]
		public int left
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[NativeProperty("right", false, TargetType.Field)]
		public int right
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[NativeProperty("top", false, TargetType.Field)]
		public int top
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[NativeProperty("bottom", false, TargetType.Field)]
		public int bottom
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int horizontal => 0;

		public int vertical => 0;

		public RectOffset()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		internal RectOffset(object sourceStyle, IntPtr source)
		{
		}

		~RectOffset()
		{
		}

		public RectOffset(int left, int right, int top, int bottom)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		private void Destroy()
		{
		}

		[ThreadAndSerializationSafe]
		private static IntPtr InternalCreate()
		{
			return (IntPtr)0;
		}

		[ThreadAndSerializationSafe]
		private static void InternalDestroy(IntPtr ptr)
		{
		}

		public Rect Remove(Rect rect)
		{
			return default(Rect);
		}

		private static int get_left_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_left_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_right_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_right_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_top_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_top_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_bottom_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_bottom_Injected(IntPtr _unity_self, int value)
		{
		}

		private static int get_horizontal_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_vertical_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void Remove_Injected(IntPtr _unity_self, [In] ref Rect rect, out Rect ret)
		{
			ret = default(Rect);
		}
	}
}
