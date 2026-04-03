using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblPresenceBroadcastRecord
	{
		public string BroadcastId { get; private set; }

		public string Session { get; private set; }

		public XblPresenceBroadcastProvider Provider { get; private set; }

		public uint ViewerCount { get; private set; }

		public DateTime StartTime { get; private set; }

		internal XblPresenceBroadcastRecord(Unity.XGamingRuntime.Interop.XblPresenceBroadcastRecord interopRecord)
		{
		}
	}
}
