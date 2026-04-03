using System;
using UnityEngine.Localization.Operations;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public class LocalizedAsset<TObject> : LocalizedAssetBase, IDisposable
	{
		public delegate void ChangeHandler(TObject value);

		private class ConvertToObjectOperation : WaitForCurrentOperationAsyncOperationBase<Object>
		{
			public static readonly ObjectPool<ConvertToObjectOperation> Pool;

			private AsyncOperationHandle<TObject> m_Operation;

			public void Init(AsyncOperationHandle<TObject> operation)
			{
			}

			protected override void Execute()
			{
			}

			private void OnCompleted(AsyncOperationHandle<TObject> op)
			{
			}

			protected override void Destroy()
			{
			}
		}

		[Serializable]
		public new class UxmlSerializedData : LocalizedAssetBase.UxmlSerializedData
		{
			public override object CreateInstance()
			{
				return null;
			}
		}

		private CallbackArray<ChangeHandler> m_ChangeHandler;

		private Action<Locale> m_SelectedLocaleChanged;

		private Action<AsyncOperationHandle<TObject>> m_AutomaticLoadingCompleted;

		private AsyncOperationHandle<TObject> m_PreviousLoadingOperation;

		private TObject m_CurrentValue;

		public override bool WaitForCompletion
		{
			set
			{
			}
		}

		internal override bool ForceSynchronous => false;

		public AsyncOperationHandle<TObject> CurrentLoadingOperationHandle { get; internal set; }

		public bool HasChangeHandler => false;

		public event ChangeHandler AssetChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public AsyncOperationHandle<TObject> LoadAssetAsync()
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public override AsyncOperationHandle<T> LoadAssetAsync<T>()
		{
			return default(AsyncOperationHandle<T>);
		}

		public override AsyncOperationHandle<Object> LoadAssetAsObjectAsync()
		{
			return default(AsyncOperationHandle<Object>);
		}

		public TObject LoadAsset()
		{
			return default(TObject);
		}

		protected internal override void ForceUpdate()
		{
		}

		private void HandleLocaleChange(Locale locale)
		{
		}

		private void AutomaticLoadingCompleted(AsyncOperationHandle<TObject> loadOperation)
		{
		}

		private void InvokeChangeHandler(TObject value)
		{
		}

		internal void ClearLoadingOperation()
		{
		}

		private void ClearPreviousLoadingOperation()
		{
		}

		private void ClearLoadingOperation(AsyncOperationHandle<TObject> operationHandle)
		{
		}

		protected override void Reset()
		{
		}

		~LocalizedAsset()
		{
		}

		void IDisposable.Dispose()
		{
		}

		protected override void Initialize()
		{
		}

		protected override void Cleanup()
		{
		}

		protected override BindingResult Update(in BindingContext context)
		{
			return default(BindingResult);
		}

		protected virtual BindingResult ApplyDataBindingValue(in BindingContext context, TObject value)
		{
			return default(BindingResult);
		}

		internal BindingResult SetDataBindingValue<T>(in BindingContext context, T value)
		{
			return default(BindingResult);
		}

		private void UpdateBindingValue(TObject value)
		{
		}
	}
}
