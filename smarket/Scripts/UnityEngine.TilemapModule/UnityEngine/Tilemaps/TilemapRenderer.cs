using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.U2D;

namespace UnityEngine.Tilemaps
{
	[RequireComponent(typeof(Tilemap))]
	[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
	[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	public sealed class TilemapRenderer : Renderer
	{
		[RequiredByNativeCode]
		internal void RegisterSpriteAtlasRegistered()
		{
		}

		[RequiredByNativeCode]
		internal void UnregisterSpriteAtlasRegistered()
		{
		}

		internal void OnSpriteAtlasRegistered(SpriteAtlas atlas)
		{
		}

		private static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas)
		{
		}
	}
}
