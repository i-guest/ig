using System;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.Localization.Operations
{
	internal class PreloadLocaleOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>>
	{
		private readonly Action<AsyncOperationHandle<IList<IResourceLocation>>> m_LoadTablesAction;

		private readonly Action<AsyncOperationHandle<TTable>> m_LoadTableContentsAction;

		private readonly Action<AsyncOperationHandle> m_FinishPreloadingAction;

		private readonly Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_PreloadTablesCompletedAction;

		private LocalizedDatabase<TTable, TEntry> m_Database;

		private Locale m_Locale;

		private AsyncOperationHandle<IList<IResourceLocation>> m_LoadResourcesOperation;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTablesGroupOperation;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTableContentsOperation;

		private readonly List<AsyncOperationHandle> m_LoadTablesOperations;

		private readonly List<AsyncOperationHandle> m_PreloadTableContentsOperations;

		private readonly List<string> m_ResourceLabels;

		private float m_Progress;

		public static readonly ObjectPool<PreloadLocaleOperation<TTable, TEntry>> Pool;

		protected override float Progress => 0f;

		protected override string DebugName => null;

		public void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale)
		{
		}

		protected override void Execute()
		{
		}

		private void BeginPreloading()
		{
		}

		private void LoadTables(AsyncOperationHandle<IList<IResourceLocation>> loadResourcesOperation)
		{
		}

		private void LoadTableContents(AsyncOperationHandle<TTable> operation)
		{
		}

		private void PreloadTablesCompleted(AsyncOperationHandle<IList<AsyncOperationHandle>> obj)
		{
		}

		private void FinishPreloading(AsyncOperationHandle op)
		{
		}

		private void CompleteAndRelease(bool success, string errorMsg)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
