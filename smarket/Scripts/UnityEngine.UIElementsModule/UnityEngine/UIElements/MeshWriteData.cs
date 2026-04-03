using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public class MeshWriteData
	{
		internal NativeSlice<Vertex> m_Vertices;

		internal NativeSlice<ushort> m_Indices;

		internal int currentIndex;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int currentVertex;

		internal MeshWriteData()
		{
		}
	}
}
