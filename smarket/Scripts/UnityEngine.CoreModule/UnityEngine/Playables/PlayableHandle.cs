using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
	public struct PlayableHandle : IEquatable<PlayableHandle>
	{
		internal IntPtr m_Handle;

		internal uint m_Version;

		private static readonly PlayableHandle m_Null;

		public static PlayableHandle Null => default(PlayableHandle);

		internal T GetObject<T>() where T : class, IPlayableBehaviour
		{
			return null;
		}

		[VisibleToOtherModules]
		internal bool IsPlayableOfType<T>()
		{
			return false;
		}

		internal Playable GetInput(int inputPort)
		{
			return default(Playable);
		}

		internal bool SetInputWeight(int inputIndex, float weight)
		{
			return false;
		}

		internal float GetInputWeight(int inputIndex)
		{
			return 0f;
		}

		public static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			return false;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public bool Equals(PlayableHandle other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			return false;
		}

		internal bool CheckInputBounds(int inputIndex)
		{
			return false;
		}

		internal bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			return false;
		}

		[VisibleToOtherModules]
		internal bool IsValid()
		{
			return false;
		}

		[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal Type GetPlayableType()
		{
			return null;
		}

		[FreeFunction("PlayableHandleBindings::GetJobType", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal Type GetJobType()
		{
			return null;
		}

		[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetScriptInstance(object scriptInstance)
		{
		}

		[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal PlayState GetPlayState()
		{
			return default(PlayState);
		}

		[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void Play()
		{
		}

		[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void Pause()
		{
		}

		[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetSpeed(double value)
		{
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = true, ThrowsException = true)]
		internal double GetTime()
		{
			return 0.0;
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = true, ThrowsException = true)]
		internal void SetTime(double value)
		{
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = true, ThrowsException = true)]
		internal bool IsDone()
		{
			return false;
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = true, ThrowsException = true)]
		internal void SetDone(bool value)
		{
		}

		[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal double GetDuration()
		{
			return 0.0;
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = true, ThrowsException = true)]
		internal void SetDuration(double value)
		{
		}

		[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetPropagateSetTime(bool value)
		{
		}

		[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal PlayableGraph GetGraph()
		{
			return default(PlayableGraph);
		}

		[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal int GetInputCount()
		{
			return 0;
		}

		[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetInputCount(int value)
		{
		}

		[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetInputWeight(PlayableHandle input, float weight)
		{
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = true, ThrowsException = true)]
		internal double GetPreviousTime()
		{
			return 0.0;
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = true, ThrowsException = true)]
		internal void SetTraversalMode(PlayableTraversalMode mode)
		{
		}

		[FreeFunction("PlayableHandleBindings::GetJobData", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal IntPtr GetJobData()
		{
			return (IntPtr)0;
		}

		[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal DirectorWrapMode GetTimeWrapMode()
		{
			return default(DirectorWrapMode);
		}

		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = true, ThrowsException = true)]
		internal void SetTimeWrapMode(DirectorWrapMode mode)
		{
		}

		[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = true, ThrowsException = true)]
		private object GetScriptInstance()
		{
			return null;
		}

		[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = true, ThrowsException = true)]
		private PlayableHandle GetInputHandle(int index)
		{
			return default(PlayableHandle);
		}

		[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = true, ThrowsException = true)]
		private void SetInputWeightFromIndex(int index, float weight)
		{
		}

		[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = true, ThrowsException = true)]
		private float GetInputWeightFromIndex(int index)
		{
			return 0f;
		}

		private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
		{
			ret = default(PlayableGraph);
		}

		private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, [In] ref PlayableHandle input, float weight)
		{
		}

		private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			ret = default(PlayableHandle);
		}
	}
}
