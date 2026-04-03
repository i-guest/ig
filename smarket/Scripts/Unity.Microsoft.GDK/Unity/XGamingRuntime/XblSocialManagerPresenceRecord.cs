using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblSocialManagerPresenceRecord
	{
		public XblSocialManagerPresenceTitleRecord[] PresenceTitleRecords;

		public XblPresenceUserState UserState { get; private set; }

		internal XblSocialManagerPresenceRecord(Unity.XGamingRuntime.Interop.XblSocialManagerPresenceRecord interopRecord)
		{
		}
	}
}
