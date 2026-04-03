using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct EdgeDictionary : IEdgeStore
	{
		private class EdgeComparer : IEqualityComparer<ShadowEdge>
		{
			public bool Equals(ShadowEdge edge0, ShadowEdge edge1)
			{
				return false;
			}

			public int GetHashCode(ShadowEdge edge)
			{
				return 0;
			}
		}

		private static Dictionary<ShadowEdge, int> m_EdgeDictionary;

		public NativeArray<ShadowEdge> GetOutsideEdges(NativeArray<Vector3> vertices, NativeArray<int> indices)
		{
			return default(NativeArray<ShadowEdge>);
		}
	}
}
