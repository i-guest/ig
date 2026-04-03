using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEditor.CoreModule", "UnityEngine.UIElementsModule" })]
	internal class FontAssetFactory
	{
		private static readonly HashSet<FontAsset> visitedFontAssets;

		internal static FontAsset ConvertFontToFontAsset(Font font)
		{
			return null;
		}

		internal static void SetupFontAssetSettings(FontAsset fontAsset)
		{
		}

		public static void SetHideFlags(FontAsset fontAsset)
		{
		}
	}
}
