using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.Multiplayer.PlayMode
{
	[MovedFrom(true, "Unity.Multiplayer.Playmode", "Unity.Multiplayer.Playmode", null)]
	public static class CurrentPlayer
	{
		private static CurrentPlayerApi s_CurrentPlayerApi;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ReloadLatestTagsOnEnterPlaymode()
		{
		}
	}
}
