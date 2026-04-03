using System;

namespace UnityEngine.Rendering
{
	internal struct RangeKey : IEquatable<RangeKey>
	{
		public byte layer;

		public uint renderingLayerMask;

		public MotionVectorGenerationMode motionMode;

		public ShadowCastingMode shadowCastingMode;

		public bool staticShadowCaster;

		public int rendererPriority;

		public bool supportsIndirect;

		public bool Equals(RangeKey other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
