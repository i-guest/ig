using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	internal class XRVisibleMesh
	{
		private XRPass m_Pass;

		private Mesh m_CombinedMesh;

		private int m_CombinedMeshHashCode;

		private static readonly ProfilingSampler k_VisibleMeshProfilingSampler;

		internal bool hasValidVisibleMesh => false;

		internal XRVisibleMesh(XRPass xrPass)
		{
		}

		internal void Dispose()
		{
		}

		internal void RenderVisibleMeshCustomMaterial(CommandBuffer cmd, float occlusionMeshScale, Material material, MaterialPropertyBlock materialBlock, int shaderPass, bool yFlip = false)
		{
		}

		internal void UpdateCombinedMesh()
		{
		}

		private bool IsVisibleMeshSupported()
		{
			return false;
		}

		private bool TryGetVisibleMeshCombinedHashCode(out int hashCode)
		{
			hashCode = default(int);
			return false;
		}

		private void CreateVisibleMeshCombined()
		{
		}
	}
}
