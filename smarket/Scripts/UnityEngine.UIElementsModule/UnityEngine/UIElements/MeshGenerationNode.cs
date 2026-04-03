using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	[NativeContainer]
	public struct MeshGenerationNode
	{
		private UnsafeMeshGenerationNode m_UnsafeNode;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Create(GCHandle handle, out MeshGenerationNode node)
		{
			node = default(MeshGenerationNode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Entry GetParentEntry()
		{
			return null;
		}
	}
}
