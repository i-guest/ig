using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XAppCaptureRecordClipResult
	{
		internal Unity.XGamingRuntime.Interop.XAppCaptureRecordClipResult interop;

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long FileSize
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long StartTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public uint DurationInMs
		{
			get
			{
				return 0u;
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

		public uint StartTimePreciseOffsetHns
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[Obsolete("Please use Path instead, (UnityUpgradable) -> Path", true)]
		public string path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Please use FileSize instead, (UnityUpgradable) -> FileSize", true)]
		public long fileSize
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[Obsolete("Please use StartTime instead, (UnityUpgradable) -> StartTime", true)]
		public long startTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[Obsolete("Please use DurationInMs instead, (UnityUpgradable) -> DurationInMs", true)]
		public uint durationInMs
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[Obsolete("Please use Width instead, (UnityUpgradable) -> Width", true)]
		public uint width
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[Obsolete("Please use Height instead, (UnityUpgradable) -> Height", true)]
		public uint height
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[Obsolete("Please use Encoding instead, (UnityUpgradable) -> Encoding", true)]
		public XAppCaptureVideoEncoding encoding
		{
			get
			{
				return default(XAppCaptureVideoEncoding);
			}
			set
			{
			}
		}

		[Obsolete("Please use StartTimePreciseOffsetHns instead, (UnityUpgradable) -> StartTimePreciseOffsetHns", true)]
		public uint startTimePreciseOffsetHns
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XAppCaptureRecordClipResult(Unity.XGamingRuntime.Interop.XAppCaptureRecordClipResult interop)
		{
		}

		public XAppCaptureRecordClipResult()
		{
		}
	}
}
