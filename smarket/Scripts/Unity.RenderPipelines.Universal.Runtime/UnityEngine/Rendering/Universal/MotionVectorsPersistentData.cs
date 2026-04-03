using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	internal sealed class MotionVectorsPersistentData
	{
		private const int k_MaxViewPerPass = 2;

		private Matrix4x4[] m_stagingMatrixArray;

		private const int k_EyeCount = 4;

		private int m_numPreviousViews;

		private readonly Matrix4x4[] m_Projection;

		private readonly Matrix4x4[] m_View;

		private readonly Matrix4x4[] m_ViewProjection;

		private readonly Matrix4x4[] m_PreviousProjection;

		private readonly Matrix4x4[] m_PreviousView;

		private readonly Matrix4x4[] m_PreviousViewProjection;

		private readonly Matrix4x4[] m_PreviousPreviousProjection;

		private readonly Matrix4x4[] m_PreviousPreviousView;

		private readonly int[] m_LastFrameIndex;

		private readonly float[] m_PrevAspectRatio;

		private float m_deltaTime;

		private float m_lastDeltaTime;

		private Vector3 m_worldSpaceCameraPos;

		private Vector3 m_previousWorldSpaceCameraPos;

		private Vector3 m_previousPreviousWorldSpaceCameraPos;

		internal int lastFrameIndex => 0;

		internal Matrix4x4 viewProjection => default(Matrix4x4);

		internal Matrix4x4 previousViewProjection => default(Matrix4x4);

		internal Matrix4x4[] viewProjectionStereo => null;

		internal Matrix4x4[] previousViewProjectionStereo => null;

		internal Matrix4x4[] stagingMatrixStereo => null;

		internal Matrix4x4[] projectionStereo => null;

		internal Matrix4x4[] previousProjectionStereo => null;

		internal Matrix4x4[] previousPreviousProjectionStereo => null;

		internal Matrix4x4[] viewStereo => null;

		internal Matrix4x4[] previousViewStereo => null;

		internal Matrix4x4[] previousPreviousViewStereo => null;

		internal float deltaTime => 0f;

		internal float lastDeltaTime => 0f;

		internal Vector3 worldSpaceCameraPos => default(Vector3);

		internal Vector3 previousWorldSpaceCameraPos => default(Vector3);

		internal Vector3 previousPreviousWorldSpaceCameraPos => default(Vector3);

		internal MotionVectorsPersistentData()
		{
		}

		public void Reset()
		{
		}

		private static int GetXRMultiPassId(XRPass xr)
		{
			return 0;
		}

		public void Update(UniversalCameraData cameraData)
		{
		}

		public void SetGlobalMotionMatrices(RasterCommandBuffer cmd, XRPass xr)
		{
		}
	}
}
