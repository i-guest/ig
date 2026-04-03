namespace Steamworks.Data
{
	public struct UgcAdditionalPreview
	{
		public string UrlOrVideoID { get; private set; }

		public string OriginalFileName { get; private set; }

		public ItemPreviewType ItemPreviewType { get; private set; }

		internal UgcAdditionalPreview(string urlOrVideoID, string originalFileName, ItemPreviewType itemPreviewType)
		{
			UrlOrVideoID = null;
			OriginalFileName = null;
			ItemPreviewType = default(ItemPreviewType);
		}
	}
}
