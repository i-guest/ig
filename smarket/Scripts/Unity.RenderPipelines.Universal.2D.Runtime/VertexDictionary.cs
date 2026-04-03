using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

[StructLayout((LayoutKind)0, Size = 1)]
internal struct VertexDictionary
{
	private static Dictionary<Vector3, int> m_VertexDictionary;

	public NativeArray<int> GetIndexRemap(NativeArray<Vector3> vertices, NativeArray<int> indices)
	{
		return default(NativeArray<int>);
	}
}
