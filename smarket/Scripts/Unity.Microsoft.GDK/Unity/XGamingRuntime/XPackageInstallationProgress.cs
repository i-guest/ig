using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPackageInstallationProgress
	{
		internal Unity.XGamingRuntime.Interop.XPackageInstallationProgress interop;

		public ulong TotalBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong InstalledBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong LaunchBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public bool Launchable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Completed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XPackageInstallationProgress(Unity.XGamingRuntime.Interop.XPackageInstallationProgress interop)
		{
		}

		public XPackageInstallationProgress()
		{
		}
	}
}
