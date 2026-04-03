using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XAppCaptureLocalResult
	{
		internal XAppCaptureLocalStreamHandle _clipHandle;

		internal SYSTEMTIME _clipStartTimestamp;

		internal Unity.XGamingRuntime.Interop.XAppCaptureLocalResult interop;

		public XAppCaptureLocalStreamHandle ClipHandle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ulong FileSizeInBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public SYSTEMTIME ClipStartTimestamp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ulong DurationInMilliseconds
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public uint Width
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint Height
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public XAppCaptureVideoEncoding Encoding
		{
			get
			{
				return default(XAppCaptureVideoEncoding);
			}
			set
			{
			}
		}

		public XAppCaptureVideoColorFormat ColorFormat
		{
			get
			{
				return default(XAppCaptureVideoColorFormat);
			}
			set
			{
			}
		}

		internal XAppCaptureLocalResult(Unity.XGamingRuntime.Interop.XAppCaptureLocalResult interop)
		{
		}
	}
}
