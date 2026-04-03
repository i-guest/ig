namespace UnityEngine.Experimental.Rendering
{
	internal readonly struct XRView
	{
		internal readonly Matrix4x4 projMatrix;

		internal readonly Matrix4x4 viewMatrix;

		internal readonly Matrix4x4 prevViewMatrix;

		internal readonly Rect viewport;

		internal readonly Mesh occlusionMesh;

		internal readonly Mesh visibleMesh;

		internal readonly int textureArraySlice;

		internal readonly Vector2 eyeCenterUV;

		internal readonly bool isPrevViewMatrixValid;

		internal XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Matrix4x4 prevViewMatrix, bool isPrevViewMatrixValid, Rect viewport, Mesh occlusionMesh, Mesh visibleMesh, int textureArraySlice)
		{
			this.projMatrix = default(Matrix4x4);
			this.viewMatrix = default(Matrix4x4);
			this.prevViewMatrix = default(Matrix4x4);
			this.viewport = default(Rect);
			this.occlusionMesh = null;
			this.visibleMesh = null;
			this.textureArraySlice = 0;
			eyeCenterUV = default(Vector2);
			this.isPrevViewMatrixValid = false;
		}

		private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj)
		{
			return default(Vector2);
		}
	}
}
