namespace UnityEngine.Localization.Components
{
	[ExecuteAlways]
	public abstract class LocalizedAssetBehaviour<TObject, TReference> : LocalizedMonoBehaviour where TReference : new()
	{
		[SerializeField]
		private TReference m_LocalizedAssetReference;

		private LocalizedAsset<TObject>.ChangeHandler m_ChangeHandler;

		public TReference AssetReference
		{
			get
			{
				return default(TReference);
			}
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		internal virtual void RegisterChangeHandler()
		{
		}

		internal virtual void ClearChangeHandler()
		{
		}

		protected abstract void UpdateAsset(TObject localizedAsset);
	}
}
