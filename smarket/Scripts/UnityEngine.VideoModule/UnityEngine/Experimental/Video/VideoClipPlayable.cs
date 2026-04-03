using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Video
{
	[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
	[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(VideoClipPlayable other)
		{
			return false;
		}
	}
}
