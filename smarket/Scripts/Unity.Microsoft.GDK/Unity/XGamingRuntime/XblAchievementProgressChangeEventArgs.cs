using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XblAchievementProgressChangeEventArgs
	{
		public XblAchievementProgressChangeEntry[] UpdatedAchievementEntries { get; private set; }

		public ulong EntryCount { get; private set; }

		internal XblAchievementProgressChangeEventArgs(Unity.XGamingRuntime.Interop.XblAchievementProgressChangeEventArgs interopEventArgs)
		{
		}
	}
}
