using System;
using System.Collections.Generic;
using UnityEngine.Localization.Operations;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public abstract class LocalizedDatabase<TTable, TEntry> : IPreloadRequired, IReset, IDisposable
	{
		public struct TableEntryResult
		{
			public TEntry Entry { get; }

			public TTable Table { get; }

			internal TableEntryResult(TEntry entry, TTable table)
			{
				Entry = default(TEntry);
				Table = default(TTable);
			}
		}

		[SerializeField]
		private TableReference m_DefaultTableReference;

		[SerializeReference]
		private ITableProvider m_CustomTableProvider;

		[SerializeReference]
		private ITablePostprocessor m_CustomTablePostprocessor;

		[SerializeField]
		private AsynchronousBehaviour m_AsynchronousBehaviour;

		[SerializeField]
		private bool m_UseFallback;

		internal AsyncOperationHandle m_PreloadOperationHandle;

		private Action<AsyncOperationHandle> m_ReleaseNextFrame;

		private readonly Action<AsyncOperationHandle<TTable>> m_PatchTableContentsAction;

		private readonly Action<AsyncOperationHandle<TTable>> m_RegisterSharedTableAndGuidOperationAction;

		private readonly Action<AsyncOperationHandle<TTable>> m_RegisterCompletedTableOperationAction;

		internal static readonly LocaleIdentifier k_SelectedLocaleId;

		public AsyncOperationHandle PreloadOperation => default(AsyncOperationHandle);

		internal Action<AsyncOperationHandle> ReleaseNextFrame => null;

		internal Dictionary<(LocaleIdentifier localeIdentifier, string tableNameOrGuid), AsyncOperationHandle<TTable>> TableOperations { get; }

		internal Dictionary<Guid, AsyncOperationHandle<SharedTableData>> SharedTableDataOperations { get; }

		public virtual TableReference DefaultTable
		{
			get
			{
				return default(TableReference);
			}
			set
			{
			}
		}

		public ITableProvider TableProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ITablePostprocessor TablePostprocessor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseFallback
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AsynchronousBehaviour AsynchronousBehaviour
		{
			get
			{
				return default(AsynchronousBehaviour);
			}
			set
			{
			}
		}

		public LocalizedDatabase()
		{
		}

		internal TableReference GetDefaultTable()
		{
			return default(TableReference);
		}

		internal void RegisterCompletedTableOperation(AsyncOperationHandle<TTable> tableOperation)
		{
		}

		private void RegisterTableNameOperation(AsyncOperationHandle<TTable> tableOperation, LocaleIdentifier localeIdentifier, string tableName)
		{
		}

		private void RegisterSharedTableAndGuidOperation(AsyncOperationHandle<TTable> tableOperation)
		{
		}

		public AsyncOperationHandle<TTable> GetDefaultTableAsync()
		{
			return default(AsyncOperationHandle<TTable>);
		}

		public virtual AsyncOperationHandle<TTable> GetTableAsync(TableReference tableReference, Locale locale = null)
		{
			return default(AsyncOperationHandle<TTable>);
		}

		public virtual TTable GetTable(TableReference tableReference, Locale locale = null)
		{
			return default(TTable);
		}

		public AsyncOperationHandle PreloadTables(TableReference tableReference, Locale locale = null)
		{
			return default(AsyncOperationHandle);
		}

		public AsyncOperationHandle PreloadTables(IList<TableReference> tableReferences, Locale locale = null)
		{
			return default(AsyncOperationHandle);
		}

		public void ReleaseAllTables(Locale locale = null)
		{
		}

		public void ReleaseTable(TableReference tableReference, Locale locale = null)
		{
		}

		public virtual AsyncOperationHandle<IList<TTable>> GetAllTables(Locale locale = null)
		{
			return default(AsyncOperationHandle<IList<TTable>>);
		}

		public virtual bool IsTableLoaded(TableReference tableReference, Locale locale = null)
		{
			return false;
		}

		internal virtual LoadTableOperation<TTable, TEntry> CreateLoadTableOperation()
		{
			return null;
		}

		internal virtual PreloadTablesOperation<TTable, TEntry> CreatePreloadTablesOperation()
		{
			return null;
		}

		public virtual AsyncOperationHandle<TableEntryResult> GetTableEntryAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return default(AsyncOperationHandle<TableEntryResult>);
		}

		public virtual TableEntryResult GetTableEntry(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return default(TableEntryResult);
		}

		internal AsyncOperationHandle<SharedTableData> GetSharedTableData(Guid tableNameGuid)
		{
			return default(AsyncOperationHandle<SharedTableData>);
		}

		internal virtual void ReleaseTableContents(TTable table)
		{
		}

		public virtual void OnLocaleChanged(Locale locale)
		{
		}

		private void PatchTableContents(AsyncOperationHandle<TTable> tableOperation)
		{
		}

		public void ResetState()
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
