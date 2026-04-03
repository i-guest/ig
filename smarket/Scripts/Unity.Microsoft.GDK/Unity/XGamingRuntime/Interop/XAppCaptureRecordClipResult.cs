namespace Unity.XGamingRuntime.Interop
{
	internal struct XAppCaptureRecordClipResult
	{
		internal string path;

		internal long fileSize;

		internal long startTime;

		internal uint durationInMs;

		internal uint width;

		internal uint height;

		internal XAppCaptureVideoEncoding encoding;

		internal uint startTimePreciseOffsetHns;
	}
}
