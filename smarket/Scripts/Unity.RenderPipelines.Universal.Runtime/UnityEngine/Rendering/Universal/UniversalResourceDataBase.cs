using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public abstract class UniversalResourceDataBase : ContextItem
	{
		internal enum ActiveID
		{
			Camera = 0,
			BackBuffer = 1
		}

		internal bool isAccessible { get; set; }

		internal void InitFrame()
		{
		}

		internal void EndFrame()
		{
		}

		protected void CheckAndSetTextureHandle(ref TextureHandle handle, TextureHandle newHandle)
		{
		}

		protected TextureHandle CheckAndGetTextureHandle(ref TextureHandle handle)
		{
			return default(TextureHandle);
		}

		protected void CheckAndSetTextureHandle(ref TextureHandle[] handle, TextureHandle[] newHandle)
		{
		}

		protected TextureHandle[] CheckAndGetTextureHandle(ref TextureHandle[] handle)
		{
			return null;
		}

		protected bool CheckAndWarnAboutAccessibility()
		{
			return false;
		}
	}
}
