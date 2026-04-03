using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Texture ({handle.index})")]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public readonly struct TextureHandle
	{
		private static TextureHandle s_NullHandle;

		internal readonly ResourceHandle handle;

		private readonly bool builtin;

		public static TextureHandle nullHandle => default(TextureHandle);

		internal TextureHandle(in ResourceHandle h)
		{
			handle = default(ResourceHandle);
			builtin = false;
		}

		internal TextureHandle(int handle, bool shared = false, bool builtin = false)
		{
			this.handle = default(ResourceHandle);
			this.builtin = false;
		}

		public static implicit operator RenderTargetIdentifier(TextureHandle texture)
		{
			return default(RenderTargetIdentifier);
		}

		public static implicit operator Texture(TextureHandle texture)
		{
			return null;
		}

		public static implicit operator RenderTexture(TextureHandle texture)
		{
			return null;
		}

		public static implicit operator RTHandle(TextureHandle texture)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValid()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool IsBuiltin()
		{
			return false;
		}

		public TextureDesc GetDescriptor(RenderGraph renderGraph)
		{
			return default(TextureDesc);
		}
	}
}
