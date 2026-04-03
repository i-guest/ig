namespace Unity.XGamingRuntime.Interop
{
	internal struct XblTitleStorageBlobMetadata
	{
		internal string blobPath;

		internal XblTitleStorageBlobType blobType;

		internal XblTitleStorageType storageType;

		internal string displayName;

		internal string eTag;

		internal TimeT clientTimestamp;

		internal SizeT length;

		internal string serviceConfigurationId;

		internal ulong xboxUserId;
	}
}
