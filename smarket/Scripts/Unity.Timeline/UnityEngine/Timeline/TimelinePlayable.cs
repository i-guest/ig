using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	public class TimelinePlayable : PlayableBehaviour
	{
		private readonly struct TrackCacheManager : IDisposable
		{
			public readonly HashSet<AnimationTrack> trackCache;

			public TrackCacheManager(HashSet<AnimationTrack> cache, IReadOnlyList<RuntimeElement> activeRuntimeElements)
			{
				trackCache = null;
			}

			public void Dispose()
			{
			}

			private void GetTrackAssetsFromRuntimeElements(IReadOnlyList<RuntimeElement> activeRuntimeElements)
			{
			}
		}

		private static ProfilerMarker k_CreateTimelineGraphMarker;

		private static ProfilerMarker k_CreateTimelineTrackMarker;

		private static ProfilerMarker k_CreateTimelineTrackOutputsMarker;

		private static ProfilerMarker m_findActiveClipsMarker;

		private static ProfilerMarker m_SetClipsLocalTimeMarker;

		private IntervalTree<RuntimeElement> m_IntervalTree;

		private List<RuntimeElement> m_ActiveClips;

		private List<RuntimeElement> m_CurrentListOfActiveClips;

		private int m_ActiveBit;

		private Dictionary<TrackAsset, Playable> m_PlayableCache;

		internal static bool muteAudioScrubbing;

		private readonly Dictionary<AnimationTrack, List<ITimelineEvaluateCallback>> m_EvaluateCallbacks;

		private readonly List<ITimelineEvaluateCallback> m_AlwaysEvaluateCallbacks;

		private readonly HashSet<ITimelineEvaluateCallback> m_ForceEvaluateNextEvaluate;

		private readonly HashSet<ITimelineEvaluateCallback> m_InvokedThisFrame;

		private readonly HashSet<AnimationTrack> m_ActiveTracksToEvaluateCache;

		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			return default(ScriptPlayable<TimelinePlayable>);
		}

		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
		}

		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
		{
		}

		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
		{
		}

		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
		{
			return default(Playable);
		}

		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		private void Evaluate(Playable playable, FrameData frameData)
		{
		}

		private void CacheTrack(TrackAsset track, Playable playable)
		{
		}

		private static void ForAOTCompilationOnly()
		{
		}

		private void AddPlayableOutputCallbacks(AnimationTrack track, PlayableOutput playableOutput)
		{
		}

		private void AddOutputWeightProcessor(AnimationTrack track, AnimationPlayableOutput animOutput)
		{
		}

		private void AddEvaluateCallback(AnimationTrack track, ITimelineEvaluateCallback callback)
		{
		}

		private void InvokeOutputCallbacks(IReadOnlyList<RuntimeElement> activeRuntimeElements)
		{
		}

		private bool TryGetCallbackList(AnimationTrack track, out List<ITimelineEvaluateCallback> list)
		{
			list = null;
			return false;
		}
	}
}
