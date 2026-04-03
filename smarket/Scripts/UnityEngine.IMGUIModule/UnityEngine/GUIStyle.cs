using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.TextCore.Text;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("IMGUIScriptingClasses.h")]
	public sealed class GUIStyle
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(GUIStyle guiStyle)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		[NonSerialized]
		private GUIStyleState m_Normal;

		[NonSerialized]
		private GUIStyleState m_Hover;

		[NonSerialized]
		private GUIStyleState m_Active;

		[NonSerialized]
		private GUIStyleState m_Focused;

		[NonSerialized]
		private GUIStyleState m_OnNormal;

		[NonSerialized]
		private GUIStyleState m_OnHover;

		[NonSerialized]
		private GUIStyleState m_OnActive;

		[NonSerialized]
		private GUIStyleState m_OnFocused;

		[NonSerialized]
		private RectOffset m_Border;

		[NonSerialized]
		private RectOffset m_Padding;

		[NonSerialized]
		private RectOffset m_Margin;

		[NonSerialized]
		private RectOffset m_Overflow;

		[NonSerialized]
		private string m_Name;

		internal static bool showKeyboardFocus;

		private static GUIStyle s_None;

		[NativeProperty("Name", false, TargetType.Function)]
		internal string rawName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("Font", false, TargetType.Function)]
		public Font font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("m_ImagePosition", false, TargetType.Field)]
		public ImagePosition imagePosition
		{
			get
			{
				return default(ImagePosition);
			}
			set
			{
			}
		}

		[NativeProperty("m_Alignment", false, TargetType.Field)]
		public TextAnchor alignment
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		[NativeProperty("m_WordWrap", false, TargetType.Field)]
		public bool wordWrap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_Clipping", false, TargetType.Field)]
		public TextClipping clipping
		{
			get
			{
				return default(TextClipping);
			}
			set
			{
			}
		}

		[NativeProperty("m_ContentOffset", false, TargetType.Field)]
		public Vector2 contentOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[NativeProperty("m_FixedWidth", false, TargetType.Field)]
		public float fixedWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("m_FixedHeight", false, TargetType.Field)]
		public float fixedHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("m_StretchWidth", false, TargetType.Field)]
		public bool stretchWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_StretchHeight", false, TargetType.Field)]
		public bool stretchHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_FontSize", false, TargetType.Field)]
		public int fontSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[NativeProperty("m_FontStyle", false, TargetType.Field)]
		public FontStyle fontStyle
		{
			get
			{
				return default(FontStyle);
			}
			set
			{
			}
		}

		[NativeProperty("m_RichText", false, TargetType.Field)]
		public bool richText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("m_ClipOffset", false, TargetType.Field)]
		internal Vector2 Internal_clipOffset => default(Vector2);

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState normal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState hover
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState active
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState onNormal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState onHover
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState onActive
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState focused
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GUIStyleState onFocused
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectOffset border
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectOffset margin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectOffset padding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectOffset overflow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float lineHeight => 0f;

		public static GUIStyle none => null;

		public bool isHeightDependantOnWidth => false;

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create([UnityMarshalAs(NativeType.ScriptingObjectPtr)] GUIStyle self)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr self)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
		private IntPtr GetStyleStatePtr(int idx)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::AssignStyleState", HasExplicitThis = true)]
		private void AssignStyleState(int idx, IntPtr srcStyleState)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
		private IntPtr GetRectOffsetPtr(int idx)
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = true)]
		private void AssignRectOffset(int idx, IntPtr srcRectOffset)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSize(GUIContent content)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
		private float Internal_CalcHeight(GUIContent content, float width)
		{
			return 0f;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = true)]
		internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize)
		{
			return default(Vector2);
		}

		[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
		internal static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
		}

		[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
		internal static bool IsTooltipActive(string tooltip)
		{
			return false;
		}

		[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
		internal static void SetDefaultFont(Font font)
		{
		}

		[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
		internal static Font GetDefaultFont()
		{
			return null;
		}

		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
		internal static void Internal_DestroyTextGenerator(int meshInfoId)
		{
		}

		~GUIStyle()
		{
		}

		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID)
		{
		}

		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
		}

		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return default(Vector2);
		}

		public Vector2 CalcSize(GUIContent content)
		{
			return default(Vector2);
		}

		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			return default(Vector2);
		}

		public float CalcHeight(GUIContent content, float width)
		{
			return 0f;
		}

		internal Vector2 GetPreferredSize(string content, Rect rect)
		{
			return default(Vector2);
		}

		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			minWidth = default(float);
			maxWidth = default(float);
		}

		public override string ToString()
		{
			return null;
		}

		[RequiredByNativeCode]
		internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId)
		{
		}

		[RequiredByNativeCode]
		internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions)
		{
		}

		[RequiredByNativeCode]
		internal static void GetLineHeight(GUIStyle style, ref float lineHeight)
		{
		}

		[RequiredByNativeCode]
		internal static void EmptyManagedCache()
		{
		}

		private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static IntPtr get_font_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_font_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self)
		{
			return default(ImagePosition);
		}

		private static void set_imagePosition_Injected(IntPtr _unity_self, ImagePosition value)
		{
		}

		private static TextAnchor get_alignment_Injected(IntPtr _unity_self)
		{
			return default(TextAnchor);
		}

		private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value)
		{
		}

		private static bool get_wordWrap_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_wordWrap_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static TextClipping get_clipping_Injected(IntPtr _unity_self)
		{
			return default(TextClipping);
		}

		private static void set_clipping_Injected(IntPtr _unity_self, TextClipping value)
		{
		}

		private static void get_contentOffset_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_contentOffset_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static float get_fixedWidth_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_fixedWidth_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_fixedHeight_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_fixedHeight_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_stretchWidth_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_stretchWidth_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_stretchHeight_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static int get_fontSize_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_fontSize_Injected(IntPtr _unity_self, int value)
		{
		}

		private static FontStyle get_fontStyle_Injected(IntPtr _unity_self)
		{
			return default(FontStyle);
		}

		private static void set_fontStyle_Injected(IntPtr _unity_self, FontStyle value)
		{
		}

		private static bool get_richText_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_richText_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx)
		{
			return (IntPtr)0;
		}

		private static void AssignStyleState_Injected(IntPtr _unity_self, int idx, IntPtr srcStyleState)
		{
		}

		private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx)
		{
			return (IntPtr)0;
		}

		private static void AssignRectOffset_Injected(IntPtr _unity_self, int idx, IntPtr srcRectOffset)
		{
		}

		private static void Internal_Draw_Injected(IntPtr _unity_self, [In] ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		private static void Internal_Draw2_Injected(IntPtr _unity_self, [In] ref Rect position, GUIContent content, int controlID, bool on)
		{
		}

		private static void Internal_CalcSize_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, [In] ref Vector2 maxSize, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width)
		{
			return 0f;
		}

		private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, [In] ref Rect screenRect, GUIContent content, [In] ref Vector2 textSize, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, [In] ref Rect screenRect)
		{
		}

		private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip)
		{
			return false;
		}

		private static void SetDefaultFont_Injected(IntPtr font)
		{
		}

		private static IntPtr GetDefaultFont_Injected()
		{
			return (IntPtr)0;
		}
	}
}
