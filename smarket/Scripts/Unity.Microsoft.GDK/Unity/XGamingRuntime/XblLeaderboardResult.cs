using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblLeaderboardResult
	{
		public uint TotalRowCount { get; private set; }

		public XblLeaderboardColumn[] Columns { get; private set; }

		public XblLeaderboardRow[] Rows { get; private set; }

		public bool HasNext { get; private set; }

		public XblLeaderboardQuery NextQuery { get; private set; }

		internal XblLeaderboardResult(Unity.XGamingRuntime.Interop.XblLeaderboardResult interopResult)
		{
		}
	}
}
