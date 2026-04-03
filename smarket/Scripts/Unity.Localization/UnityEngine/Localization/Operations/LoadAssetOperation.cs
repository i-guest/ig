using System;
using UnityEngine.Localization.Settings;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class LoadAssetOperation<TObject> : WaitForCurrentOperationAsyncOperationBase<TObject>
	{
		private readonly Action<AsyncOperationHandle<TObject>> m_AssetLoadedAction;

		private AsyncOperationHandle<LocalizedDatabase<UnityEngine.Localization.Tables.AssetTable, UnityEngine.Localization.Tables.AssetTableEntry>.TableEntryResult> m_TableEntryOperation;

		private AsyncOperationHandle<TObject> m_LoadAssetOperation;

		private bool m_AutoRelease;

		public static readonly ObjectPool<LoadAssetOperation<TObject>> Pool;

		public void Init(AsyncOperationHandle<LocalizedDatabase<UnityEngine.Localization.Tables.AssetTable, UnityEngine.Localization.Tables.AssetTableEntry>.TableEntryResult> loadTableEntryOperation, bool autoRelease)
		{
		}

		protected override void Execute()
		{
		}

		private void AssetLoaded(AsyncOperationHandle<TObject> handle)
		{
		}

		public void CompleteAndRelease(TObject result, bool success, string errorMsg)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
