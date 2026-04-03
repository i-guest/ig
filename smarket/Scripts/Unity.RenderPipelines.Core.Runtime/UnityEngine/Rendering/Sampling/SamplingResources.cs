using System;

namespace UnityEngine.Rendering.Sampling
{
	internal sealed class SamplingResources : IDisposable
	{
		internal enum ResourceType
		{
			BlueNoiseTextures = 1,
			SobolMatrices = 2,
			All = 3
		}

		private Texture2D m_SobolScramblingTile;

		private Texture2D m_SobolRankingTile;

		private Texture2D m_SobolOwenScrambled256Samples;

		private GraphicsBuffer m_SobolBuffer;

		public static readonly uint[] sobolMatrices;

		public static void Bind(CommandBuffer cmd, SamplingResources resources)
		{
		}

		public void Dispose()
		{
		}
	}
}
