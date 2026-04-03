using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeClass("GfxBufferID")]
	public readonly struct GraphicsBufferHandle : IEquatable<GraphicsBufferHandle>
	{
		public readonly uint value;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(GraphicsBufferHandle other)
		{
			return false;
		}
	}
}
