using System;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[UxmlObject]
	public abstract class LocalizedAssetBase : LocalizedReference
	{
		[Serializable]
		public new abstract class UxmlSerializedData : LocalizedReference.UxmlSerializedData
		{
		}

		public abstract AsyncOperationHandle<Object> LoadAssetAsObjectAsync();

		public abstract AsyncOperationHandle<TObject> LoadAssetAsync<TObject>();
	}
}
