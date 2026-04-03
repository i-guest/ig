namespace UnityEngine.Rendering
{
	[ExecuteInEditMode]
	internal class DisallowSmallMeshCulling : MonoBehaviour
	{
		private bool m_AppliedRecursively;

		public bool m_applyToChildrenRecursively;

		public bool applyToChildrenRecursively
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private static void AllowSmallMeshCulling(Transform transform, bool allow)
		{
		}

		private static void AllowSmallMeshCullingRecursively(Transform transform, bool allow)
		{
		}

		private void OnValidate()
		{
		}
	}
}
