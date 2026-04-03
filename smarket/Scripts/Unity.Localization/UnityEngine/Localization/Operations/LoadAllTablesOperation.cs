using System;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class LoadAllTablesOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<IList<TTable>>
	{
		private readonly Action<AsyncOperationHandle<IList<TTable>>> m_LoadingCompletedAction;

		private AsyncOperationHandle<IList<TTable>> m_AllTablesOperation;

		private LocalizedDatabase<TTable, TEntry> m_Database;

		private Locale m_SelectedLocale;

		public static readonly ObjectPool<LoadAllTablesOperation<TTable, TEntry>> Pool;

		public void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale)
		{
		}

		protected override void Execute()
		{
		}

		private void LoadingCompleted(AsyncOperationHandle<IList<TTable>> obj)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
