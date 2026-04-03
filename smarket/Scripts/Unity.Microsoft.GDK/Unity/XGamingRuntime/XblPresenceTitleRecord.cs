using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblPresenceTitleRecord
	{
		public uint TitleId { get; private set; }

		public string TitleName { get; private set; }

		public DateTime LastModified { get; private set; }

		public bool TitleActive { get; private set; }

		public string RichPresenceString { get; private set; }

		public XblPresenceTitleViewState ViewState { get; private set; }

		public XblPresenceBroadcastRecord BroadcastRecord { get; private set; }

		internal XblPresenceTitleRecord(Unity.XGamingRuntime.Interop.XblPresenceTitleRecord interopRecord)
		{
		}
	}
}
