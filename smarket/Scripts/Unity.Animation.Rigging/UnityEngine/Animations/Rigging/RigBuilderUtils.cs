using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Animations.Rigging
{
	internal static class RigBuilderUtils
	{
		public struct PlayableChain
		{
			public string name;

			public Playable[] playables;

			public bool IsValid()
			{
				return false;
			}
		}

		private static readonly ushort k_AnimationOutputPriority;

		public static Playable[] BuildRigPlayables(PlayableGraph graph, IRigLayer layer)
		{
			return null;
		}

		public static IEnumerable<PlayableChain> BuildPlayables(Animator animator, PlayableGraph graph, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer)
		{
			return null;
		}

		public static PlayableGraph BuildPlayableGraph(Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer)
		{
			return default(PlayableGraph);
		}

		public static void BuildPlayableGraph(PlayableGraph graph, Animator animator, IList<IRigLayer> layers, SyncSceneToStreamLayer syncSceneToStreamLayer)
		{
		}
	}
}
