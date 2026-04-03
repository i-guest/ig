using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[ExecuteInEditMode]
	internal class DisallowGPUDrivenRendering : MonoBehaviour
	{
		private bool m_AppliedRecursively;

		[FormerlySerializedAs("applyToChildrenRecursively")]
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

		private static void AllowGPUDrivenRendering(Transform transform, bool allow)
		{
		}

		private static void AllowGPUDrivenRenderingRecursively(Transform transform, bool allow)
		{
		}

		private void OnValidate()
		{
		}
	}
}
