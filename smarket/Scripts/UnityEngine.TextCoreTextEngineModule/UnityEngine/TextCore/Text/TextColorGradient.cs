using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	[ExcludeFromPreset]
	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/TextCoreTextEngine/TextColorGradient.h")]
	public class TextColorGradient : ScriptableObject
	{
		public ColorGradientMode colorMode;

		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		private const ColorGradientMode k_DefaultColorMode = ColorGradientMode.FourCornersGradient;

		private static readonly Color k_DefaultColor;

		private IntPtr m_NativeInstance;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal IntPtr nativeInstance => (IntPtr)0;

		private void OnValidate()
		{
		}

		private void OnDisable()
		{
		}

		public TextColorGradient()
		{
		}

		public TextColorGradient(Color color)
		{
		}

		public TextColorGradient(Color color0, Color color1, Color color2, Color color3)
		{
		}

		internal void MarkNativeDirty()
		{
		}

		private static IntPtr CreateNative(Color32 tl, Color32 tr, Color32 bl, Color32 br, IntPtr managedObject)
		{
			return (IntPtr)0;
		}

		private static void DestroyNative(IntPtr nativeInstance, IntPtr managedObject)
		{
		}

		private static void UpdateNative(IntPtr instance, Color32 tl, Color32 tr, Color32 bl, Color32 br)
		{
		}

		private static IntPtr CreateNative_Injected([In] ref Color32 tl, [In] ref Color32 tr, [In] ref Color32 bl, [In] ref Color32 br, IntPtr managedObject)
		{
			return (IntPtr)0;
		}

		private static void UpdateNative_Injected(IntPtr instance, [In] ref Color32 tl, [In] ref Color32 tr, [In] ref Color32 bl, [In] ref Color32 br)
		{
		}
	}
}
