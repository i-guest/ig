namespace UnityEngine.Rendering.Universal
{
	internal static class XRSystemUniversal
	{
		private static Matrix4x4[] s_projMatrix;

		private static MaterialPropertyBlock s_XRSharedPropertyBlock;

		internal static MaterialPropertyBlock GetMaterialPropertyBlock()
		{
			return null;
		}

		internal static void BeginLateLatching(Camera camera, XRPassUniversal xrPass)
		{
		}

		internal static void EndLateLatching(Camera camera, XRPassUniversal xrPass)
		{
		}

		internal static void UnmarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass)
		{
		}

		internal static void MarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass, bool renderIntoTexture)
		{
		}
	}
}
