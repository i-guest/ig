using System;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class LoadSubAssetOperation<TObject> : WaitForCurrentOperationAsyncOperationBase<TObject>
	{
		private readonly Action<AsyncOperationHandle<TObject>> m_AssetLoadedAction;

		private AsyncOperationHandle<TObject> m_AssetOperation;

		private AsyncOperationHandle<Object[]> m_PreloadOperations;

		private string m_Address;

		private bool m_IsSubAsset;

		private string m_SubAssetName;

		public static readonly ObjectPool<LoadSubAssetOperation<TObject>> Pool;

		public void Init(AsyncOperationHandle<Object[]> preloadOperations, string address, bool isSubAsset, string subAssetName)
		{
		}

		protected override void Execute()
		{
		}

		private void AssetLoaded(AsyncOperationHandle<TObject> handle)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
