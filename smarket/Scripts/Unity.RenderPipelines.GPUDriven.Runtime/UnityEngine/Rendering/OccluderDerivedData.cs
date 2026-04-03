namespace UnityEngine.Rendering
{
	internal struct OccluderDerivedData
	{
		public Matrix4x4 viewProjMatrix;

		public Vector4 viewOriginWorldSpace;

		public Vector4 radialDirWorldSpace;

		public Vector4 facingDirWorldSpace;

		public static OccluderDerivedData FromParameters(in OccluderSubviewUpdate occluderSubviewUpdate)
		{
			return default(OccluderDerivedData);
		}
	}
}
