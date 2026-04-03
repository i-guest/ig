using System.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine
{
	internal class RuntimeTextSettings : TextSettings
	{
		private static RuntimeTextSettings s_DefaultTextSettings;

		private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal;

		internal static RuntimeTextSettings defaultTextSettings => null;

		internal override List<FontAsset> GetStaticFallbackOSFontAsset()
		{
			return null;
		}

		internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets)
		{
		}
	}
}
