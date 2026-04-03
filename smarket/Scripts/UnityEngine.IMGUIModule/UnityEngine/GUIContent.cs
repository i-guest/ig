using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/IMGUI/GUIContent.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public class GUIContent
	{
		[SerializeField]
		private string m_Text;

		[SerializeField]
		private Texture m_Image;

		[SerializeField]
		private string m_Tooltip;

		[SerializeField]
		private string m_TextWithWhitespace;

		private static readonly GUIContent s_Text;

		private static readonly GUIContent s_Image;

		private static readonly GUIContent s_TextImage;

		internal static string k_ZeroWidthSpace;

		public static GUIContent none;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string textWithWhitespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture image
		{
			set
			{
			}
		}

		public string tooltip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal event Action OnTextChanged
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

		internal void SetTextWithoutNotify(string value)
		{
		}

		public GUIContent()
		{
		}

		public GUIContent(string text)
		{
		}

		public GUIContent(string text, string tooltip)
		{
		}

		public GUIContent(string text, Texture image, string tooltip)
		{
		}

		public GUIContent(GUIContent src)
		{
		}

		internal static GUIContent Temp(string t)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void ClearStaticCache()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
