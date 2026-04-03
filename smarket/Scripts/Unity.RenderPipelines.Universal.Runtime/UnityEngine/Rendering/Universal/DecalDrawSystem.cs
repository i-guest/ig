namespace UnityEngine.Rendering.Universal
{
	internal abstract class DecalDrawSystem
	{
		internal static readonly uint MaxBatchSize;

		protected DecalEntityManager m_EntityManager;

		private Matrix4x4[] m_WorldToDecals;

		private Matrix4x4[] m_NormalToDecals;

		private float[] m_DecalLayerMasks;

		private ProfilingSampler m_Sampler;

		public Material overrideMaterial { get; set; }

		public DecalDrawSystem(string sampler, DecalEntityManager entityManager)
		{
		}

		public void Execute(CommandBuffer cmd)
		{
		}

		internal void Execute(RasterCommandBuffer cmd)
		{
		}

		protected virtual Material GetMaterial(DecalEntityChunk decalEntityChunk)
		{
			return null;
		}

		protected abstract int GetPassIndex(DecalCachedChunk decalCachedChunk);

		private void Execute(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
		{
		}

		private void Draw(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
		{
		}

		private void DrawInstanced(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
		{
		}

		public void Execute(in CameraData cameraData)
		{
		}

		private void Execute(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
		{
		}

		private void Draw(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
		{
		}

		private void DrawInstanced(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
		{
		}
	}
}
