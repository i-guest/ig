namespace UnityEngine.UIElements.UIR
{
	internal static class Shaders
	{
		public static readonly string k_AtlasBlit;

		public static readonly string k_Default;

		public static readonly string k_RuntimeGaussianBlur;

		public static readonly string k_RuntimeColorEffect;

		public static readonly string k_ColorConversionBlit;

		public static readonly string k_ForceGammaKeyword;

		public static readonly string k_TextureSlotCount1;

		public static readonly string k_TextureSlotCount2;

		public static readonly string k_TextureSlotCount4;

		public static readonly string k_ForceRenderTypeSolid;

		public static readonly string k_ForceRenderTypeTextured;

		public static readonly string k_ForceRenderTypeText;

		public static readonly string k_ForceRenderTypeSvgGradient;

		private static Material s_DefaultMaterial;

		private static int s_RefCount;

		public static Material defaultMaterial => null;

		private static Material GetOrCreateMaterial(ref Material material, string shaderName)
		{
			return null;
		}

		public static void Acquire()
		{
		}

		public static void Release()
		{
		}
	}
}
