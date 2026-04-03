using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[RequiredByNativeCode]
	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	public struct TileChangeData
	{
		[SerializeField]
		private Vector3Int m_Position;

		[SerializeField]
		private Object m_TileAsset;

		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private Matrix4x4 m_Transform;
	}
}
