namespace Steamworks.Data
{
	public struct Screenshot
	{
		internal ScreenshotHandle Value;

		public bool TagUser(SteamId user)
		{
			return false;
		}

		public bool SetLocation(string location)
		{
			return false;
		}

		public bool TagPublishedFile(PublishedFileId file)
		{
			return false;
		}
	}
}
