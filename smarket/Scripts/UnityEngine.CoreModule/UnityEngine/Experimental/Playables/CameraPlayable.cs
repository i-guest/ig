using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct CameraPlayable : IPlayable, IEquatable<CameraPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(CameraPlayable other)
		{
			return false;
		}
	}
}
