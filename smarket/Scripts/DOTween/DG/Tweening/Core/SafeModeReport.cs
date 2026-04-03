namespace DG.Tweening.Core
{
	internal struct SafeModeReport
	{
		internal enum SafeModeReportType
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}

		public int totMissingTargetOrFieldErrors { get; private set; }

		public int totCallbackErrors { get; private set; }

		public int totStartupErrors { get; private set; }

		public int totUnsetErrors { get; private set; }

		public void Add(SafeModeReportType type)
		{
		}

		public int GetTotErrors()
		{
			return 0;
		}
	}
}
