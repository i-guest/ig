using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	public sealed class GUIStyleState
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(GUIStyleState guiStyleState)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		private readonly GUIStyle m_SourceStyle;

		[NativeProperty("Background", false, TargetType.Function)]
		public Texture2D background
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("textColor", false, TargetType.Field)]
		public Color textColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
		private static IntPtr Init()
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		private void Cleanup()
		{
		}

		public GUIStyleState()
		{
		}

		private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
		}

		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			return null;
		}

		~GUIStyleState()
		{
		}

		private static IntPtr get_background_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_background_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void get_textColor_Injected(IntPtr _unity_self, out Color ret)
		{
			ret = default(Color);
		}

		private static void set_textColor_Injected(IntPtr _unity_self, [In] ref Color value)
		{
		}

		private static void Cleanup_Injected(IntPtr _unity_self)
		{
		}
	}
}
