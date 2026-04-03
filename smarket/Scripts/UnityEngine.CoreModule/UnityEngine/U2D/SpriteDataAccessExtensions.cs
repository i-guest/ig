using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	public static class SpriteDataAccessExtensions
	{
		private static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel)
		{
		}

		public static NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel) where T : struct
		{
			return default(NativeSlice<T>);
		}

		public static NativeArray<ushort> GetIndices(this Sprite sprite)
		{
			return default(NativeArray<ushort>);
		}

		private static SpriteChannelInfo GetIndicesInfo([NotNull] Sprite sprite)
		{
			return default(SpriteChannelInfo);
		}

		private static SpriteChannelInfo GetChannelInfo([NotNull] Sprite sprite, VertexAttribute channel)
		{
			return default(SpriteChannelInfo);
		}

		private static void GetIndicesInfo_Injected(IntPtr sprite, out SpriteChannelInfo ret)
		{
			ret = default(SpriteChannelInfo);
		}

		private static void GetChannelInfo_Injected(IntPtr sprite, VertexAttribute channel, out SpriteChannelInfo ret)
		{
			ret = default(SpriteChannelInfo);
		}
	}
}
