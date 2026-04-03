namespace UnityEngine.Rendering.RenderGraphModule
{
	internal readonly struct TextureAccess
	{
		public readonly TextureHandle textureHandle;

		public readonly int mipLevel;

		public readonly int depthSlice;

		public readonly AccessFlags flags;

		public TextureAccess(in TextureHandle handle, AccessFlags flags, int mipLevel, int depthSlice)
		{
			textureHandle = default(TextureHandle);
			this.mipLevel = 0;
			this.depthSlice = 0;
			this.flags = default(AccessFlags);
		}

		public TextureAccess(in TextureAccess access, in TextureHandle handle)
		{
			textureHandle = default(TextureHandle);
			mipLevel = 0;
			depthSlice = 0;
			flags = default(AccessFlags);
		}
	}
}
