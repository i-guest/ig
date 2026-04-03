using System;

namespace UnityEngine.Rendering
{
	internal struct DrawKey : IEquatable<DrawKey>
	{
		public BatchMeshID meshID;

		public int submeshIndex;

		public int activeMeshLod;

		public BatchMaterialID materialID;

		public BatchDrawCommandFlags flags;

		public int transparentInstanceId;

		public uint overridenComponents;

		public RangeKey range;

		public int lightmapIndex;

		public bool Equals(DrawKey other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
