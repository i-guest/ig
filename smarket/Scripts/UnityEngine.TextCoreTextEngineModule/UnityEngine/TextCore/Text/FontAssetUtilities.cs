using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	internal static class FontAssetUtilities
	{
		private static HashSet<int> k_SearchedAssets;

		internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		internal static Character GetCharacterFromFontAssetsInternal(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, List<FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = true)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		private static Character GetCharacterFromFontAssetsInternal(uint unicode, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = true)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		internal static TextElement GetTextElementFromTextAssets(uint unicode, FontAsset sourceFontAsset, List<TextAsset> textAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		public static uint GetCodePoint(string text, ref int index)
		{
			return 0u;
		}

		public static uint GetCodePoint(uint[] codesPoints, ref int index)
		{
			return 0u;
		}
	}
}
