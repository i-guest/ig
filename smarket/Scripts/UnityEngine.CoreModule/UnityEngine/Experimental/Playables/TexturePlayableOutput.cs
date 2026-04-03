using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
	[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	public struct TexturePlayableOutput : IPlayableOutput
	{
		private PlayableOutputHandle m_Handle;

		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}
	}
}
