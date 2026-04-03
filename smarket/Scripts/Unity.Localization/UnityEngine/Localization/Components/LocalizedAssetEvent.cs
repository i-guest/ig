namespace UnityEngine.Localization.Components
{
	public class LocalizedAssetEvent<TObject, TReference, TEvent> : LocalizedAssetBehaviour<TObject, TReference> where TReference : new() where TEvent : new()
	{
		[SerializeField]
		private TEvent m_UpdateAsset;

		public TEvent OnUpdateAsset
		{
			get
			{
				return default(TEvent);
			}
			set
			{
			}
		}

		protected override void UpdateAsset(TObject localizedAsset)
		{
		}
	}
}
