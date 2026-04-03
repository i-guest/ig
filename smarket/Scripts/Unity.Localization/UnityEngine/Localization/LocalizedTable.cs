using System;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization
{
	[Serializable]
	public abstract class LocalizedTable<TTable, TEntry>
	{
		public delegate void ChangeHandler(TTable value);

		[SerializeField]
		private TableReference m_TableReference;

		private CallbackArray<ChangeHandler> m_ChangeHandler;

		private Action<Locale> m_SelectedLocaleChanged;

		protected abstract LocalizedDatabase<TTable, TEntry> Database { get; }

		public AsyncOperationHandle<TTable> CurrentLoadingOperationHandle { get; internal set; }

		public TableReference TableReference
		{
			get
			{
				return default(TableReference);
			}
			set
			{
			}
		}

		public bool IsEmpty => false;

		[Obsolete("CurrentLoadingOperation is deprecated, use CurrentLoadingOperationHandle instead.")]
		public AsyncOperationHandle<TTable>? CurrentLoadingOperation => null;

		public event ChangeHandler TableChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public LocalizedTable()
		{
		}

		public AsyncOperationHandle<TTable> GetTableAsync()
		{
			return default(AsyncOperationHandle<TTable>);
		}

		public TTable GetTable()
		{
			return default(TTable);
		}

		protected void ForceUpdate()
		{
		}

		private void InvokeChangeHandler(TTable value)
		{
		}

		private void HandleLocaleChange(Locale _)
		{
		}

		private void AutomaticLoadingCompleted(AsyncOperationHandle<TTable> loadOperation)
		{
		}

		private void ClearLoadingOperation()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
