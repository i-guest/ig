using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
	[NativeHeader("Modules/Grid/Public/Grid.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[RequireComponent(typeof(Transform))]
	[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
	public sealed class Tilemap : GridLayout
	{
		[RequiredByNativeCode]
		public struct SyncTile
		{
			internal Vector3Int m_Position;

			internal TileBase m_Tile;

			internal TileData m_TileData;
		}

		internal struct SyncTileCallbackSettings
		{
			internal bool hasSyncTileCallback;

			internal bool hasPositionsChangedCallback;

			internal bool isBufferSyncTile;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Tilemap, SyncTile[]> tilemapTileChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Tilemap, NativeArray<Vector3Int>> loopEndedForTileAnimation;

		private bool m_BufferSyncTile;

		internal bool bufferSyncTile => false;

		internal static bool HasLoopEndedForTileAnimationCallback()
		{
			return false;
		}

		private void HandleLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr)
		{
		}

		private void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions)
		{
		}

		internal static bool HasSyncTileCallback()
		{
			return false;
		}

		internal static bool HasPositionsChangedCallback()
		{
			return false;
		}

		private void HandleSyncTileCallback(SyncTile[] syncTiles)
		{
		}

		private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr)
		{
		}

		private void SendTilemapTileChangedCallback(SyncTile[] syncTiles)
		{
		}

		private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions)
		{
		}

		[NativeMethod(Name = "RefreshTileAsset")]
		public void RefreshTile(Vector3Int position)
		{
		}

		[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = true)]
		internal unsafe void RefreshTilesNative(void* positions, int count)
		{
		}

		[RequiredByNativeCode]
		internal void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback)
		{
		}

		[RequiredByNativeCode]
		private void DoLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr)
		{
		}

		[RequiredByNativeCode]
		internal void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings)
		{
		}

		[RequiredByNativeCode]
		private void DoSyncTileCallback(SyncTile[] syncTiles)
		{
		}

		[RequiredByNativeCode]
		private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr)
		{
		}

		private static void RefreshTile_Injected(IntPtr _unity_self, [In] ref Vector3Int position)
		{
		}

		private unsafe static void RefreshTilesNative_Injected(IntPtr _unity_self, void* positions, int count)
		{
		}
	}
}
