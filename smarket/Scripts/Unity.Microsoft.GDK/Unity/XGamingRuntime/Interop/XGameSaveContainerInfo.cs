namespace Unity.XGamingRuntime.Interop
{
	internal struct XGameSaveContainerInfo
	{
		internal string name;

		internal string displayName;

		internal uint blobCount;

		internal ulong totalSize;

		internal long lastModifiedTime;

		internal bool needsSync;
	}
}
