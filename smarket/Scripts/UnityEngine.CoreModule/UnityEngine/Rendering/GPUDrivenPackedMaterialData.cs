using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	internal struct GPUDrivenPackedMaterialData
	{
		private uint data;

		public bool isTransparent => false;

		public bool isMotionVectorsPassEnabled => false;

		public bool isIndirectSupported => false;

		public bool supportsCrossFade => false;

		public GPUDrivenPackedMaterialData()
		{
			data = 0u;
		}

		public bool Equals(GPUDrivenPackedMaterialData other)
		{
			return false;
		}
	}
}
