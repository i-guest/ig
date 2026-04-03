using System;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class PreloadDatabaseOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>>
	{
		private readonly Action<AsyncOperationHandle> m_CompleteOperation;

		private readonly Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_CompleteGenericGroup;

		private LocalizedDatabase<TTable, TEntry> m_Database;

		public static readonly ObjectPool<PreloadDatabaseOperation<TTable, TEntry>> Pool;

		protected override float Progress => 0f;

		protected override string DebugName => null;

		public void Init(LocalizedDatabase<TTable, TEntry> database)
		{
		}

		protected override void Execute()
		{
		}

		private void GetAllFallbackLocales(Locale current, HashSet<Locale> locales)
		{
		}

		private AsyncOperationHandle PreloadLocale(Locale locale)
		{
			return default(AsyncOperationHandle);
		}

		private void PreloadLocales(ICollection<Locale> locales)
		{
		}

		private void CompleteOperation(AsyncOperationHandle operationHandle)
		{
		}

		private void CompleteGenericGroup(AsyncOperationHandle<IList<AsyncOperationHandle>> operationHandle)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
