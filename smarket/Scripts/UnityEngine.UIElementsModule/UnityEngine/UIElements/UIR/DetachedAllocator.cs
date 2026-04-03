using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	internal class DetachedAllocator : IDisposable
	{
		private TempAllocator<Vertex> m_VertsPool;

		private TempAllocator<ushort> m_IndexPool;

		private List<MeshWriteData> m_MeshWriteDataPool;

		private List<int> m_FillGradientMeshIndices;

		private List<FillGradient> m_FillGradients;

		private int m_FillGradientDataCount;

		private List<int> m_FillTextureMeshIndices;

		private List<Texture> m_FillTextures;

		private int m_FillTextureDataCount;

		private int m_MeshWriteDataCount;

		private bool m_Disposed;

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
