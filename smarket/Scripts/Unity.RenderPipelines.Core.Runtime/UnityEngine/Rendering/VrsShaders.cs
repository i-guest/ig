namespace UnityEngine.Rendering
{
	internal static class VrsShaders
	{
		internal const string k_TileSizePrefix = "VRS_TILE_SIZE_";

		internal const string k_DisableTexture2dXArray = "DISABLE_TEXTURE2D_X_ARRAY";

		internal const string k_YFlip = "APPLY_Y_FLIP";

		internal static readonly int s_ScaleBias;

		internal static readonly int s_MainTex;

		internal static readonly int s_MainTexLut;

		internal static readonly int s_ShadingRateNativeValues;

		internal static readonly int s_ShadingRateImage;

		internal const string k_KernelTextureCopy = "TextureCopy";

		internal const string k_KernelTextureReduce = "TextureReduce";

		internal static readonly int s_VisualizationLut;

		internal static readonly int s_VisualizationParams;
	}
}
