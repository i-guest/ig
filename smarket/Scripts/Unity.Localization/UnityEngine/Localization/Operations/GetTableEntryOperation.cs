using System;
using System.Collections.Generic;
using UnityEngine.Localization.Metadata;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class GetTableEntryOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>.TableEntryResult>
	{
		private readonly Action<AsyncOperationHandle<TTable>> m_ExtractEntryFromTableAction;

		private AsyncOperationHandle<TTable> m_LoadTableOperation;

		private TableReference m_TableReference;

		private TableEntryReference m_TableEntryReference;

		private LocalizedDatabase<TTable, TEntry> m_Database;

		private Locale m_SelectedLocale;

		private Locale m_CurrentLocale;

		private HashSet<Locale> m_HandledFallbacks;

		private List<Locale> m_FallbackQueue;

		private bool m_UseFallback;

		private bool m_AutoRelease;

		public static readonly ObjectPool<GetTableEntryOperation<TTable, TEntry>> Pool;

		public void Init(LocalizedDatabase<TTable, TEntry> database, AsyncOperationHandle<TTable> loadTableOperation, TableReference tableReference, TableEntryReference tableEntryReference, Locale selectedLoale, bool UseFallBack, bool autoRelease)
		{
		}

		protected override void Execute()
		{
		}

		private void ExtractEntryFromTable(AsyncOperationHandle<TTable> asyncOperation)
		{
		}

		private bool HandleEntryOverride(AsyncOperationHandle<TTable> asyncOperation, TEntry entry)
		{
			return false;
		}

		private bool ApplyEntryOverride(IEntryOverride entryOverride, AsyncOperationHandle<TTable> asyncOperation, TEntry entry)
		{
			return false;
		}

		private Locale GetNextFallback(Locale currentLocale)
		{
			return null;
		}

		private bool HandleFallback(AsyncOperationHandle<TTable> asyncOperation, TEntry entry)
		{
			return false;
		}

		private void CompleteAndRelease(LocalizedDatabase<TTable, TEntry>.TableEntryResult result, bool success, string errorMsg)
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
