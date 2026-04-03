namespace UnityEngine.Rendering.Universal
{
	public static class ShaderUtils
	{
		private static readonly string[] s_ShaderPaths;

		internal static float PersistentDeltaTime => 0f;

		public static string GetShaderPath(ShaderPathID id)
		{
			return null;
		}

		public static ShaderPathID GetEnumFromPath(string path)
		{
			return default(ShaderPathID);
		}

		public static bool IsLWShader(Shader shader)
		{
			return false;
		}
	}
}
