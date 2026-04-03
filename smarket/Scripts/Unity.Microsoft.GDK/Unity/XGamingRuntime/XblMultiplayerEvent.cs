using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerEvent
	{
		public int Result { get; }

		public string ErrorMessage { get; }

		public object Context { get; }

		public XblMultiplayerEventType EventType { get; }

		public XblMultiplayerEventArgsHandle EventArgsHandle { get; }

		public XblMultiplayerSessionType SessionType { get; }

		internal XblMultiplayerEvent(Unity.XGamingRuntime.Interop.XblMultiplayerEvent interopStruct)
		{
		}
	}
}
