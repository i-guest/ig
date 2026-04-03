using System;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	[DisplayName("Mesh Filter", null)]
	[CustomTrackedObject(typeof(MeshFilter), false)]
	public class TrackedMeshFilter : TrackedObject
	{
		private const string k_MeshProperty = "m_Mesh";

		private AsyncOperationHandle<Mesh> m_CurrentOperation;

		public override bool CanTrackProperty(string propertyPath)
		{
			return false;
		}

		public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			return default(AsyncOperationHandle);
		}

		private void MeshOperationCompleted(AsyncOperationHandle<Mesh> assetOp)
		{
		}

		private void SetMesh(Mesh mesh)
		{
		}
	}
}
