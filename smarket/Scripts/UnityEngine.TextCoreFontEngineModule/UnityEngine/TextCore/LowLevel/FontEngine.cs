using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.LowLevel
{
	[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
	public sealed class FontEngine
	{
		private static Glyph[] s_Glyphs;

		private static uint[] s_GlyphIndexes_MarshallingArray_A;

		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;

		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;

		private static GlyphRect[] s_FreeGlyphRects;

		private static GlyphRect[] s_UsedGlyphRects;

		private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray;

		private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;

		private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray;

		private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray;

		private static Dictionary<uint, Glyph> s_GlyphLookupDictionary;

		public static FontEngineError LoadFontFace(string filePath)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_Internal(string filePath)
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex)
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(Font font, float pointSize, int faceIndex)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex)
		{
			return 0;
		}

		public static FontEngineError LoadFontFace(string familyName, string styleName, float pointSize)
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize)
		{
			return 0;
		}

		public static FontEngineError UnloadFontFace()
		{
			return default(FontEngineError);
		}

		[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = true)]
		private static int UnloadFontFace_Internal()
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static bool IsColorFontFace()
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
		{
			fontRef = default(FontReference);
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef)
		{
			fontRef = default(FontReference);
			return false;
		}

		public static FaceInfo GetFaceInfo()
		{
			return default(FaceInfo);
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = true, IsFreeFunction = true)]
		private static int GetFaceInfo_Internal(ref FaceInfo faceInfo)
		{
			return 0;
		}

		public static string[] GetFontFaces()
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = true, IsFreeFunction = true)]
		private static string[] GetFontFaces_Internal()
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = true, IsFreeFunction = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode)
		{
			return 0u;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = true, IsFreeFunction = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static uint GetGlyphIndex(uint unicode)
		{
			return 0u;
		}

		public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
		{
			glyph = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			return false;
		}

		public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
		{
			glyph = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = true, IsFreeFunction = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static void SetTextureUploadMode(bool shouldUploadImmediately)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
		{
			glyph = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph)
		{
			glyph = default(GlyphMarshallingStruct);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs)
		{
			glyphs = null;
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount)
		{
			return false;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = true, IsFreeFunction = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<uint> glyphIndexes)
		{
			return null;
		}

		private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes)
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = true)]
		private static int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static int GetLigatureSubstitutionRecordsFromMarshallingArray([Out] LigatureSubstitutionRecord[] ligatureSubstitutionRecords)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes)
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = true)]
		private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = true, IsFreeFunction = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<uint> glyphIndexes)
		{
			return null;
		}

		private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes)
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = true)]
		private static int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static int GetPairAdjustmentRecordsFromMarshallingArray(Span<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords)
		{
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = true, IsFreeFunction = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<uint> glyphIndexes)
		{
			return null;
		}

		private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes)
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = true)]
		private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(Span<MarkToBaseAdjustmentRecord> adjustmentRecords)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = true, IsFreeFunction = true)]
		internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<uint> glyphIndexes)
		{
			return null;
		}

		private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes)
		{
			return null;
		}

		[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = true)]
		private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(Span<MarkToMarkAdjustmentRecord> adjustmentRecords)
		{
			return 0;
		}

		private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray)
		{
		}

		private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray)
		{
		}

		private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = true)]
		internal static void ResetAtlasTexture(Texture2D texture)
		{
		}

		private static int LoadFontFace_Internal_Injected(ref ManagedSpanWrapper filePath)
		{
			return 0;
		}

		private static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize, int faceIndex)
		{
			return 0;
		}

		private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(IntPtr font, int pointSize, int faceIndex)
		{
			return 0;
		}

		private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, int pointSize)
		{
			return 0;
		}

		private static bool TryGetSystemFontReference_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, out FontReference fontRef)
		{
			fontRef = default(FontReference);
			return false;
		}

		private static bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out GlyphMarshallingStruct glyph)
		{
			freeGlyphRects = default(BlittableArrayWrapper);
			usedGlyphRects = default(BlittableArrayWrapper);
			glyph = default(GlyphMarshallingStruct);
			return false;
		}

		private static bool TryAddGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out BlittableArrayWrapper glyphs, ref int glyphCount)
		{
			freeGlyphRects = default(BlittableArrayWrapper);
			usedGlyphRects = default(BlittableArrayWrapper);
			glyphs = default(BlittableArrayWrapper);
			return false;
		}

		private static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		private static void GetAllPairAdjustmentRecords_Injected(out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		private static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper glyphPairAdjustmentRecords)
		{
			return 0;
		}

		private static void GetAllMarkToBaseAdjustmentRecords_Injected(out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords)
		{
			return 0;
		}

		private static void GetAllMarkToMarkAdjustmentRecords_Injected(out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
		{
			recordCount = default(int);
			return 0;
		}

		private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords)
		{
			return 0;
		}

		private static void ResetAtlasTexture_Injected(IntPtr texture)
		{
		}
	}
}
