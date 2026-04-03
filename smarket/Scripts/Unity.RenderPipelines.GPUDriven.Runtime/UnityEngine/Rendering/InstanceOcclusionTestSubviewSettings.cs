using System;

namespace UnityEngine.Rendering
{
	internal struct InstanceOcclusionTestSubviewSettings
	{
		public int testCount;

		public int occluderSubviewIndices;

		public int occluderSubviewMask;

		public int cullingSplitIndices;

		public int cullingSplitMask;

		public static InstanceOcclusionTestSubviewSettings FromSpan(ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests)
		{
			return default(InstanceOcclusionTestSubviewSettings);
		}
	}
}
