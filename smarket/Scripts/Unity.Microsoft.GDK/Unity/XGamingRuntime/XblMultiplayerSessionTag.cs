using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionTag
	{
		public string Value { get; }

		public XblMultiplayerSessionTag(string value)
		{
		}

		internal XblMultiplayerSessionTag(Unity.XGamingRuntime.Interop.XblMultiplayerSessionTag interopStruct)
		{
		}
	}
}
