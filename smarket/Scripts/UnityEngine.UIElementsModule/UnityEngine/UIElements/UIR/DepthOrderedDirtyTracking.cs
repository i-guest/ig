using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	internal struct DepthOrderedDirtyTracking
	{
		public RenderTree owner;

		public List<RenderData> heads;

		public List<RenderData> tails;

		public int[] minDepths;

		public int[] maxDepths;

		public uint dirtyID;

		public void EnsureFits(int maxDepth)
		{
		}

		public void RegisterDirty(RenderData renderData, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass)
		{
		}

		public void ClearDirty(RenderData renderData, RenderDataDirtyTypes dirtyTypesInverse)
		{
		}

		public void Reset()
		{
		}
	}
}
