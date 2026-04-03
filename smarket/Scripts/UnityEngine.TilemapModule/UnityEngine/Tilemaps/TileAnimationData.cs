using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	[RequiredByNativeCode]
	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	public struct TileAnimationData
	{
		private Sprite[] m_AnimatedSprites;

		private float m_AnimationSpeed;

		private float m_AnimationStartTime;

		private TileAnimationFlags m_Flags;
	}
}
