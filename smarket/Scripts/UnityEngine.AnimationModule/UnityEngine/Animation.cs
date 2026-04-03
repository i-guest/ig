using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Animation.h")]
	public sealed class Animation : Behaviour, IEnumerable
	{
		private sealed class Enumerator : IEnumerator
		{
			private Animation m_Outer;

			private int m_CurrentIndex;

			public object Current => null;

			internal Enumerator(Animation outer)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		public AnimationClip clip => null;

		public AnimationState this[string name] => null;

		public void Stop()
		{
		}

		public void Sample()
		{
		}

		[ExcludeFromDocs]
		public bool Play()
		{
			return false;
		}

		public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return false;
		}

		[NativeName("Play")]
		private bool PlayDefaultAnimation(PlayMode mode)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Play(string animation)
		{
			return false;
		}

		public bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return false;
		}

		[ExcludeFromDocs]
		public void CrossFade(string animation, float fadeLength)
		{
		}

		public void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
		}

		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			return null;
		}

		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			return null;
		}

		[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = true)]
		public AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return null;
		}

		public void AddClip(AnimationClip clip, string newName)
		{
		}

		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
		}

		public void AddClip([NotNull] AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[FreeFunction("AnimationBindings::GetState", HasExplicitThis = true)]
		internal AnimationState GetState(string name)
		{
			return null;
		}

		[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = true, ThrowsException = true)]
		internal AnimationState GetStateAtIndex(int index)
		{
			return null;
		}

		[NativeName("GetAnimationStateCount")]
		internal int GetStateCount()
		{
			return 0;
		}

		public AnimationClip GetClip(string name)
		{
			return null;
		}

		private static IntPtr get_clip_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void Stop_Injected(IntPtr _unity_self)
		{
		}

		private static void Sample_Injected(IntPtr _unity_self)
		{
		}

		private static bool PlayDefaultAnimation_Injected(IntPtr _unity_self, PlayMode mode)
		{
			return false;
		}

		private static bool Play_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return false;
		}

		private static void CrossFade_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
		}

		private static AnimationState CrossFadeQueued_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return null;
		}

		private static void AddClip_Injected(IntPtr _unity_self, IntPtr clip, ref ManagedSpanWrapper newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame)
		{
		}

		private static AnimationState GetState_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return null;
		}

		private static AnimationState GetStateAtIndex_Injected(IntPtr _unity_self, int index)
		{
			return null;
		}

		private static int GetStateCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}
	}
}
