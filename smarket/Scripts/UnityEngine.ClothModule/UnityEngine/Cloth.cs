using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform), typeof(SkinnedMeshRenderer))]
	[NativeClass("Unity::Cloth")]
	[NativeHeader("Modules/Cloth/Cloth.h")]
	public sealed class Cloth : Component
	{
	}
}
