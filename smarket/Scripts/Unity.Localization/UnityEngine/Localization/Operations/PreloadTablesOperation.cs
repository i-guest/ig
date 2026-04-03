using System;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class PreloadTablesOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>>
	{
		private LocalizedDatabase<TTable, TEntry> m_Database;

		private readonly List<AsyncOperationHandle<TTable>> m_LoadTables;

		private readonly List<AsyncOperationHandle> m_LoadTablesOperation;

		private readonly List<AsyncOperationHandle> m_PreloadTablesOperations;

		private readonly Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_LoadTableContentsAction;

		private readonly Action<AsyncOperationHandle> m_FinishPreloadingAction;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTablesOperationHandle;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_PreloadTablesContentsHandle;

		private IList<TableReference> m_TableReferences;

		private Locale m_SelectedLocale;

		public static readonly ObjectPool<PreloadTablesOperation<TTable, TEntry>> Pool;

		public void Init(LocalizedDatabase<TTable, TEntry> database, IList<TableReference> tableReference, Locale locale = null)
		{
		}

		protected override void Execute()
		{
		}

		private void BeginPreloadingTables()
		{
		}

		private void LoadTableContents()
		{
		}

		private void FinishPreloading(AsyncOperationHandle op)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
