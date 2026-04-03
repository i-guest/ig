namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal readonly struct Name
	{
		public readonly string name;

		public readonly int utf8ByteCount;

		public Name(string name, bool computeUTF8ByteCount = false)
		{
			this.name = null;
			utf8ByteCount = 0;
		}
	}
}
