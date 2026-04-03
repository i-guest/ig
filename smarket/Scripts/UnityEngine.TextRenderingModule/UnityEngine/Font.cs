using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
	[NativeClass("TextRendering::Font")]
	[NativeHeader("Modules/TextRendering/Public/Font.h")]
	public sealed class Font : Object
	{
		public delegate void FontTextureRebuildCallback();

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FontTextureRebuildCallback m_FontTextureRebuildCallback;

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool dynamic => false;

		public int fontSize => 0;

		public static event Action<Font> textureRebuilt
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

		public Font()
		{
		}

		public Font(string name)
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeTextureRebuilt_Internal(Font font)
		{
		}

		public bool HasCharacter(char c)
		{
			return false;
		}

		private bool HasCharacter(int c)
		{
			return false;
		}

		public static string[] GetPathsToOSFonts()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static string[] GetOSFallbacks()
		{
			return null;
		}

		private static void Internal_CreateFont([Writable] Font self, string name)
		{
		}

		private static void Internal_CreateFontFromPath([Writable] Font self, string fontPath)
		{
		}

		private static IntPtr get_material_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_material_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static bool get_dynamic_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int get_fontSize_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static bool HasCharacter_Injected(IntPtr _unity_self, int c)
		{
			return false;
		}

		private static void Internal_CreateFont_Injected([Writable] Font self, ref ManagedSpanWrapper name)
		{
		}

		private static void Internal_CreateFontFromPath_Injected([Writable] Font self, ref ManagedSpanWrapper fontPath)
		{
		}
	}
}
