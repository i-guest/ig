namespace UnityEngine.Rendering.Universal
{
	internal static class Light2DLookupTexture
	{
		internal static readonly string k_LightLookupProperty;

		internal static readonly string k_FalloffLookupProperty;

		internal static readonly int k_LightLookupID;

		internal static readonly int k_FalloffLookupID;

		private static Texture2D s_PointLightLookupTexture;

		private static Texture2D s_FalloffLookupTexture;

		private static RTHandle m_LightLookupRTHandle;

		private static RTHandle m_FalloffRTHandle;

		public static RTHandle GetLightLookupTexture_Rendergraph()
		{
			return null;
		}

		public static RTHandle GetFallOffLookupTexture_Rendergraph()
		{
			return null;
		}

		public static void Release()
		{
		}

		public static Texture GetLightLookupTexture()
		{
			return null;
		}

		public static Texture GetFalloffLookupTexture()
		{
			return null;
		}

		private static Texture2D CreatePointLightLookupTexture()
		{
			return null;
		}

		private static Texture2D CreateFalloffLookupTexture()
		{
			return null;
		}
	}
}
