using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XAppCaptureVideoCaptureSettings
	{
		internal Unity.XGamingRuntime.Interop.XAppCaptureVideoCaptureSettings interop;

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

		public ulong MaxRecordTimespanDurationInMs
		{
			get
			{
				return 0uL;
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

		public bool IsCaptureByGamesAllowed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XAppCaptureVideoCaptureSettings(Unity.XGamingRuntime.Interop.XAppCaptureVideoCaptureSettings interop)
		{
		}

		public XAppCaptureVideoCaptureSettings()
		{
		}
	}
}
