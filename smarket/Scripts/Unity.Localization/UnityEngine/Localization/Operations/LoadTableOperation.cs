using System;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.Localization.Operations
{
	internal class LoadTableOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<TTable>
	{
		private readonly Action<AsyncOperationHandle<SharedTableData>> m_LoadTableByGuidAction;

		private readonly Action<AsyncOperationHandle<IList<IResourceLocation>>> m_LoadTableResourceAction;

		private readonly Action<AsyncOperationHandle<TTable>> m_TableLoadedAction;

		private readonly Action<AsyncOperationHandle<TTable>> m_CustomTableLoadedAction;

		private LocalizedDatabase<TTable, TEntry> m_Database;

		private TableReference m_TableReference;

		private AsyncOperationHandle<TTable> m_LoadTableOperation;

		private Locale m_SelectedLocale;

		private string m_CollectionName;

		public static readonly ObjectPool<LoadTableOperation<TTable, TEntry>> Pool;

		public Action<AsyncOperationHandle<TTable>> RegisterTableOperation { get; private set; }

		public void Init(LocalizedDatabase<TTable, TEntry> database, TableReference tableReference, Locale locale)
		{
		}

		protected override void Execute()
		{
		}

		private void LoadTableByGuid(AsyncOperationHandle<SharedTableData> operationHandle)
		{
		}

		private void FindTableByName(string collectionName)
		{
		}

		private bool TryLoadWithTableProvider()
		{
			return false;
		}

		private void DefaultLoadTableByName()
		{
		}

		private void LoadTableResource(AsyncOperationHandle<IList<IResourceLocation>> operationHandle)
		{
		}

		private void CustomTableLoaded(AsyncOperationHandle<TTable> operationHandle)
		{
		}

		private void TableLoaded(AsyncOperationHandle<TTable> operationHandle)
		{
		}

		protected override void Destroy()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
