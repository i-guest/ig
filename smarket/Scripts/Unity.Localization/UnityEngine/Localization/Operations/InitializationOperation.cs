using System;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class InitializationOperation : WaitForCurrentOperationAsyncOperationBase<LocalizationSettings>
	{
		private class UnloadBundlesOperation : AsyncOperationBase<object>
		{
			private readonly Action<AsyncOperation> m_OperationCompleted;

			private readonly List<AsyncOperation> m_UnloadBundleOperations;

			protected override void Execute()
			{
			}

			private void OnOperationCompleted(AsyncOperation obj)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void Destroy()
			{
			}
		}

		private AsyncOperationHandle m_UnloadBundlesOperationHandle;

		private readonly Action<AsyncOperationHandle> m_LoadLocales;

		internal const string k_LocaleError = "Failed to initialize localization, could not load the selected locale.\n{0}";

		internal const string k_PreloadAssetTablesError = "Failed to initialize localization, could not preload asset tables.\n{0}";

		internal const string k_PreloadStringTablesError = "Failed to initialize localization, could not preload string tables.\n{0}";

		private readonly Action<AsyncOperationHandle<Locale>> m_LoadLocalesCompletedAction;

		private readonly Action<AsyncOperationHandle> m_FinishPreloadingTablesAction;

		private LocalizationSettings m_Settings;

		private readonly List<AsyncOperationHandle> m_LoadDatabasesOperations;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_PreloadDatabasesOperation;

		private int m_RemainingSteps;

		private const int k_PreloadSteps = 3;

		public static readonly ObjectPool<InitializationOperation> Pool;

		protected override float Progress => 0f;

		protected override string DebugName => null;

		public void Init(LocalizationSettings settings)
		{
		}

		protected override void Execute()
		{
		}

		private void LoadLocales()
		{
		}

		private bool CheckOperationSucceeded(AsyncOperationHandle handle, string errorMessage)
		{
			return false;
		}

		private void LoadLocalesCompleted(AsyncOperationHandle<Locale> operationHandle)
		{
		}

		private void PreloadTables()
		{
		}

		private void PreloadTablesCompleted()
		{
		}

		private void PostInitializeExtensions()
		{
		}

		private void FinishInitializing(AsyncOperationHandle op)
		{
		}

		private void FinishInitializing(bool success, string error)
		{
		}

		protected override void Destroy()
		{
		}
	}
}
