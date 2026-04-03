using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XAppCaptureScreenshotFile
	{
		internal Unity.XGamingRuntime.Interop.XAppCaptureScreenshotFile interop;

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

		internal XAppCaptureScreenshotFile(Unity.XGamingRuntime.Interop.XAppCaptureScreenshotFile interop)
		{
		}

		internal XAppCaptureScreenshotFile()
		{
		}
	}
}
