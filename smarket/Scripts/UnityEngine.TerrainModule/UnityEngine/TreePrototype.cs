using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode]
	[NativeAsStruct]
	public sealed class TreePrototype
	{
		[NativeName("prefab")]
		internal GameObject m_Prefab;

		[NativeName("bendFactor")]
		internal float m_BendFactor;

		[NativeName("navMeshLod")]
		internal int m_NavMeshLod;

		public GameObject prefab => null;

		public float bendFactor => 0f;

		public int navMeshLod => 0;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private bool Equals(TreePrototype other)
		{
			return false;
		}
	}
}
