using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/TextCoreTextEngine/Native/TextLib.h")]
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests" })]
	internal class TextLib
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(TextLib textLib)
			{
				return (IntPtr)0;
			}
		}

		public const int k_unconstrainedScreenSize = -1;

		private readonly IntPtr m_Ptr;

		public static Func<UnityEngine.TextAsset> GetICUAssetEditorDelegate;

		public TextLib(byte[] icuData)
		{
		}

		private static IntPtr GetInstance(byte[] icuData)
		{
			return (IntPtr)0;
		}

		public NativeTextInfo GenerateText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo, ref bool wasCached)
		{
			return default(NativeTextInfo);
		}

		public bool HasMissingGlyphs(NativeTextInfo textInfo, ref Dictionary<int, HashSet<uint>> missingGlyphsPerFontAsset)
		{
			return false;
		}

		public void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings, ref List<List<List<int>>> textElementIndicesByMesh, ref List<bool> hasMultipleColorsByMesh, bool uvsAreGenerated)
		{
		}

		[NativeMethod(IsThreadSafe = true)]
		public void ShapeText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo)
		{
		}

		[NativeMethod(Name = "TextLib::GenerateTextMesh", IsThreadSafe = true)]
		private NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, IntPtr textGenerationInfo, ref bool uvsAreGenerated)
		{
			return default(NativeTextInfo);
		}

		[NativeMethod(Name = "TextLib::MeasureText")]
		public Vector2 MeasureText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo)
		{
			return default(Vector2);
		}

		[NativeMethod(Name = "TextLib::FindIntersectingLink")]
		public static int FindIntersectingLink(Vector2 point, IntPtr textGenerationInfo)
		{
			return 0;
		}

		[NativeMethod(Name = "TextLib::GetCharacterCount")]
		public static int GetCharacterCount(IntPtr textGenerationInfo)
		{
			return 0;
		}

		private static IntPtr GetInstance_Injected(ref ManagedSpanWrapper icuData)
		{
			return (IntPtr)0;
		}

		private static void ShapeText_Injected(IntPtr _unity_self, [In] ref NativeTextGenerationSettings settings, IntPtr textGenerationInfo)
		{
		}

		private static void GenerateTextInternal_Injected(IntPtr _unity_self, [In] ref NativeTextGenerationSettings settings, IntPtr textGenerationInfo, ref bool uvsAreGenerated, out NativeTextInfo ret)
		{
			ret = default(NativeTextInfo);
		}

		private static void MeasureText_Injected(IntPtr _unity_self, [In] ref NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static int FindIntersectingLink_Injected([In] ref Vector2 point, IntPtr textGenerationInfo)
		{
			return 0;
		}
	}
}
