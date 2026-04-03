namespace Unity.XGamingRuntime.Interop
{
	internal struct XAppCaptureVideoCaptureSettings
	{
		internal uint width;

		internal uint height;

		internal ulong maxRecordTimespanDurationInMs;

		internal XAppCaptureVideoEncoding encoding;

		internal XAppCaptureVideoColorFormat colorFormat;

		internal bool isCaptureByGamesAllowed;
	}
}
