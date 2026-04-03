using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Serialization;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromPreset]
	[NativeHeader("Modules/TextCoreTextEngine/Native/FontAsset.h")]
	public class FontAsset : TextAsset
	{
		[SerializeField]
		internal string m_SourceFontFileGUID;

		[SerializeField]
		internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;

		[SerializeField]
		private Font m_SourceFontFile;

		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal string m_SourceFontFilePath;

		[SerializeField]
		private AtlasPopulationMode m_AtlasPopulationMode;

		[SerializeField]
		internal bool InternalDynamicOS;

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		[SerializeField]
		internal bool IsEditorFont;

		[SerializeField]
		internal FaceInfo m_FaceInfo;

		private int m_FamilyNameHashCode;

		private int m_StyleNameHashCode;

		[SerializeField]
		internal List<Glyph> m_GlyphTable;

		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

		[SerializeField]
		internal List<Character> m_CharacterTable;

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal Dictionary<uint, Character> m_CharacterLookupDictionary;

		internal Texture2D m_AtlasTexture;

		[SerializeField]
		internal Texture2D[] m_AtlasTextures;

		[SerializeField]
		internal int m_AtlasTextureIndex;

		[SerializeField]
		private bool m_IsMultiAtlasTexturesEnabled;

		[SerializeField]
		private bool m_GetFontFeatures;

		[SerializeField]
		private bool m_ClearDynamicDataOnBuild;

		[SerializeField]
		internal int m_AtlasWidth;

		[SerializeField]
		internal int m_AtlasHeight;

		[SerializeField]
		internal int m_AtlasPadding;

		[SerializeField]
		internal GlyphRenderMode m_AtlasRenderMode;

		[SerializeField]
		private List<GlyphRect> m_UsedGlyphRects;

		[SerializeField]
		private List<GlyphRect> m_FreeGlyphRects;

		[SerializeField]
		internal FontFeatureTable m_FontFeatureTable;

		[SerializeField]
		internal bool m_ShouldReimportFontFeatures;

		[SerializeField]
		internal List<FontAsset> m_FallbackFontAssetTable;

		[SerializeField]
		private FontWeightPair[] m_FontWeightTable;

		[SerializeField]
		[FormerlySerializedAs("normalStyle")]
		internal float m_RegularStyleWeight;

		[FormerlySerializedAs("normalSpacingOffset")]
		[SerializeField]
		internal float m_RegularStyleSpacing;

		[SerializeField]
		[FormerlySerializedAs("boldStyle")]
		internal float m_BoldStyleWeight;

		[SerializeField]
		[FormerlySerializedAs("boldSpacing")]
		internal float m_BoldStyleSpacing;

		[FormerlySerializedAs("italicStyle")]
		[SerializeField]
		internal byte m_ItalicStyleSlant;

		[FormerlySerializedAs("tabSize")]
		[SerializeField]
		internal byte m_TabMultiple;

		internal bool IsFontAssetLookupTablesDirty;

		private IntPtr m_NativeFontAsset;

		private List<Glyph> m_GlyphsToRender;

		private List<Glyph> m_GlyphsRendered;

		private List<uint> m_GlyphIndexList;

		private List<uint> m_GlyphIndexListNewlyAdded;

		internal List<uint> m_GlyphsToAdd;

		internal HashSet<uint> m_GlyphsToAddLookup;

		internal List<Character> m_CharactersToAdd;

		internal HashSet<uint> m_CharactersToAddLookup;

		internal List<uint> s_MissingCharacterList;

		internal HashSet<uint> m_MissingUnicodesFromFontFile;

		internal Dictionary<(uint, uint), uint> m_VariantGlyphIndexes;

		internal bool m_IsClone;

		private static readonly List<WeakReference<FontAsset>> s_CallbackInstances;

		private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

		private static ProfilerMarker k_AddSynthesizedCharactersMarker;

		private static ProfilerMarker k_TryAddGlyphMarker;

		private static ProfilerMarker k_TryAddCharacterMarker;

		private static ProfilerMarker k_TryAddCharactersMarker;

		private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker;

		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

		private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;

		private static ProfilerMarker k_ClearFontAssetDataMarker;

		private static ProfilerMarker k_UpdateFontAssetDataMarker;

		private static string s_DefaultMaterialSuffix;

		private static HashSet<int> k_SearchedFontAssetLookup;

		private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

		private static List<FontAsset> k_FontAssets_KerningUpdateQueue;

		private static HashSet<int> k_FontAssets_KerningUpdateQueueLookup;

		private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;

		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

		internal static uint[] k_GlyphIndexArray;

		private static HashSet<int> visitedFontAssets;

		public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
		{
			get
			{
				return default(FontAssetCreationEditorSettings);
			}
			set
			{
			}
		}

		public Font sourceFontFile
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public AtlasPopulationMode atlasPopulationMode
		{
			get
			{
				return default(AtlasPopulationMode);
			}
			set
			{
			}
		}

		public FaceInfo faceInfo
		{
			get
			{
				return default(FaceInfo);
			}
			set
			{
			}
		}

		internal int familyNameHashCode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int styleNameHashCode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Glyph> glyphTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Dictionary<uint, Glyph> glyphLookupTable => null;

		public List<Character> characterTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Dictionary<uint, Character> characterLookupTable => null;

		public Texture2D atlasTexture => null;

		public Texture2D[] atlasTextures
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int atlasTextureCount => 0;

		public bool isMultiAtlasTexturesEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool getFontFeatures
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool clearDynamicDataOnBuild
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int atlasWidth
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public int atlasHeight
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public int atlasPadding
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public GlyphRenderMode atlasRenderMode
		{
			get
			{
				return default(GlyphRenderMode);
			}
			internal set
			{
			}
		}

		internal List<GlyphRect> usedGlyphRects
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<GlyphRect> freeGlyphRects
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FontFeatureTable fontFeatureTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<FontAsset> fallbackFontAssetTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FontWeightPair[] fontWeightTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public float regularStyleWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float regularStyleSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float boldStyleWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float boldStyleSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public byte italicStyleSlant
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte tabMultiple
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal IntPtr nativeFontAsset
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			get
			{
				return (IntPtr)0;
			}
		}

		private static void EnsureAdditionalCapacity<T>(List<T> container, int additionalCapacity)
		{
		}

		private static void EnsureAdditionalCapacity<TKey, TValue>(Dictionary<TKey, TValue> container, int additionalCapacity)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal bool IsBitmap()
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal bool IsRaster()
		{
			return false;
		}

		internal bool IsColor()
		{
			return false;
		}

		public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
		{
			return null;
		}

		internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90)
		{
			return null;
		}

		public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode)
		{
			return null;
		}

		internal static List<FontAsset> CreateFontAssetOSFallbackList(string[] fallbacksFamilyNames, int pointSize = 90)
		{
			return null;
		}

		internal static FontAsset CreateFontAssetWithOSFallbackList(string[] fallbacksFamilyNames, int pointSize = 90)
		{
			return null;
		}

		private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90)
		{
			return null;
		}

		public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
		{
			return null;
		}

		private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		public static FontAsset CreateFontAsset(Font font)
		{
			return null;
		}

		public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
		{
			return null;
		}

		private void RegisterCallbackInstance(FontAsset instance)
		{
		}

		internal override void OnDestroy()
		{
		}

		public void ReadFontAssetDefinition()
		{
		}

		internal void InitializeDictionaryLookupTables()
		{
		}

		private static void InitializeLookup<T>(ICollection source, ref Dictionary<uint, T> lookup, int defaultCapacity = 16)
		{
		}

		private static void InitializeList<T>(ICollection source, ref List<T> list, int defaultCapacity = 16)
		{
		}

		internal void InitializeGlyphLookupDictionary()
		{
		}

		internal void InitializeCharacterLookupDictionary()
		{
		}

		internal void ClearFallbackCharacterTable()
		{
		}

		internal void InitializeLigatureSubstitutionLookupDictionary()
		{
		}

		internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary()
		{
		}

		internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
		{
		}

		internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
		{
		}

		internal void AddSynthesizedCharactersAndFaceMetrics()
		{
		}

		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
		}

		internal void AddCharacterToLookupCache(uint unicode, Character character)
		{
		}

		internal void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight)
		{
		}

		internal bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character)
		{
			character = null;
			return false;
		}

		internal void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight)
		{
		}

		internal bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight)
		{
			return false;
		}

		private uint CreateCompositeKey(uint unicode, FontStyles fontStyle = FontStyles.Normal, TextFontWeight fontWeight = TextFontWeight.Regular)
		{
			return 0u;
		}

		internal FontEngineError LoadFontFace()
		{
			return default(FontEngineError);
		}

		internal void SortCharacterTable()
		{
		}

		internal void SortGlyphTable()
		{
		}

		internal void SortFontFeatureTable()
		{
		}

		internal void SortAllTables()
		{
		}

		public bool HasCharacter(int character)
		{
			return false;
		}

		public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return false;
		}

		public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return false;
		}

		private bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return false;
		}

		private bool HasCharacter_Internal(uint character, FontStyles fontStyle = FontStyles.Normal, TextFontWeight fontWeight = TextFontWeight.Regular, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return false;
		}

		public bool HasCharacters(string text, out List<char> missingCharacters)
		{
			missingCharacters = null;
			return false;
		}

		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			missingCharacters = null;
			return false;
		}

		public bool HasCharacters(string text)
		{
			return false;
		}

		public static string GetCharacters(FontAsset fontAsset)
		{
			return null;
		}

		public static int[] GetCharactersArray(FontAsset fontAsset)
		{
			return null;
		}

		internal uint GetGlyphIndex(uint unicode)
		{
			return 0u;
		}

		internal Glyph GetGlyphInCache(uint glyphID)
		{
			return null;
		}

		internal uint GetGlyphIndex(uint unicode, out bool success)
		{
			success = default(bool);
			return 0u;
		}

		internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode)
		{
			return 0u;
		}

		internal void UpdateFontAssetData()
		{
		}

		public void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
		}

		internal void ClearCharacterAndGlyphTablesInternal()
		{
		}

		private void ClearCharacterAndGlyphTables()
		{
		}

		private void ClearFontFeaturesTables()
		{
		}

		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
		}

		private void DestroyAtlasTextures()
		{
		}

		internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset)
		{
		}

		internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset)
		{
		}

		internal static void UpdateFontFeaturesForFontAssetsInQueue()
		{
		}

		internal static void RegisterAtlasTextureForApply(Texture2D texture)
		{
		}

		internal static void UpdateAtlasTexturesInQueue()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal static void UpdateFontAssetsInUpdateQueue()
		{
		}

		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
		{
			return false;
		}

		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
		{
			missingUnicodes = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool TryAddGlyphs(List<uint> glyphsToAdd)
		{
			return false;
		}

		public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			return false;
		}

		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			missingCharacters = null;
			return false;
		}

		internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex)
		{
			return false;
		}

		internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex)
		{
			variantGlyphIndex = default(uint);
			return false;
		}

		internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph, bool populateLigatures = true)
		{
			glyph = null;
			return false;
		}

		internal bool TryAddCharacterInternal(uint unicode, out Character character)
		{
			character = null;
			return false;
		}

		internal bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = true)
		{
			character = null;
			return false;
		}

		private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = true)
		{
			glyph = null;
			return false;
		}

		private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = true)
		{
			glyph = null;
			return false;
		}

		private bool TryAddGlyphsToNewAtlasTexture()
		{
			return false;
		}

		private void SetupNewAtlasTexture()
		{
		}

		private Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight)
		{
			return null;
		}

		private void UpdateFontFeaturesForNewlyAddedGlyphs()
		{
		}

		private void UpdateGlyphAdjustmentRecordsForNewGlyphs()
		{
		}

		private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs()
		{
		}

		internal void ImportFontFeatures()
		{
		}

		private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex)
		{
		}

		internal void UpdateLigatureSubstitutionRecords()
		{
		}

		private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records)
		{
		}

		internal void UpdateGlyphAdjustmentRecords()
		{
		}

		private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records)
		{
		}

		internal void UpdateDiacriticalMarkAdjustmentRecords()
		{
		}

		private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records)
		{
		}

		private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void EnsureNativeFontAssetIsCreated()
		{
		}

		internal void UpdateFallbacks()
		{
		}

		internal void UpdateWeightFallbacks()
		{
		}

		internal void UpdateFaceInfo()
		{
		}

		internal void UpdateRenderMode()
		{
		}

		internal IntPtr[] GetFallbacks()
		{
			return null;
		}

		private bool HasRecursion(FontAsset fontAsset)
		{
			return false;
		}

		private bool HasRecursionInternal(FontAsset fontAsset)
		{
			return false;
		}

		private (IntPtr[], IntPtr[]) GetWeightFallbacks()
		{
			return default((IntPtr[], IntPtr[]));
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void CreateHbFaceIfNeeded()
		{
		}

		private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks)
		{
		}

		private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks)
		{
		}

		private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, EntityId fontEntityId, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks, GlyphRenderMode renderMode, IntPtr managedObject)
		{
			return (IntPtr)0;
		}

		private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo)
		{
		}

		private static void UpdateRenderMode(IntPtr ptr, GlyphRenderMode renderMode)
		{
		}

		[FreeFunction("FontAsset::Destroy")]
		private static void Destroy(IntPtr ptr, IntPtr managedObject)
		{
		}

		private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks)
		{
		}

		private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks)
		{
		}

		private static IntPtr Create_Injected([In] ref FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, [In] ref EntityId fontEntityId, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks, GlyphRenderMode renderMode, IntPtr managedObject)
		{
			return (IntPtr)0;
		}

		private static void UpdateFaceInfo_Injected(IntPtr ptr, [In] ref FaceInfo faceInfo)
		{
		}
	}
}
