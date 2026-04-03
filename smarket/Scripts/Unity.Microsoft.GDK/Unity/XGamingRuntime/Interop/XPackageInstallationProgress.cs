namespace Unity.XGamingRuntime.Interop
{
	internal struct XPackageInstallationProgress
	{
		internal ulong totalBytes;

		internal ulong installedBytes;

		internal ulong launchBytes;

		internal bool launchable;

		internal bool completed;
	}
}
