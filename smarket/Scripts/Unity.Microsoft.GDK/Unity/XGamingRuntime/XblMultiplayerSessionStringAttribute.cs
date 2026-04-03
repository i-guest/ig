using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblMultiplayerSessionStringAttribute
	{
		public string Name { get; }

		public string Value { get; }

		public XblMultiplayerSessionStringAttribute(string name, string value)
		{
		}

		internal XblMultiplayerSessionStringAttribute(Unity.XGamingRuntime.Interop.XblMultiplayerSessionStringAttribute interopStruct)
		{
		}
	}
}
