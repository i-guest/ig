using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
	public struct PlayableGraph
	{
		internal IntPtr m_Handle;

		internal uint m_Version;

		public Playable GetRootPlayable(int index)
		{
			return default(Playable);
		}

		public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : struct, IPlayable where V : struct, IPlayable
		{
			return false;
		}

		public void Evaluate()
		{
		}

		public static PlayableGraph Create(string name)
		{
			return default(PlayableGraph);
		}

		[FreeFunction("PlayableGraphBindings::Destroy", HasExplicitThis = true, ThrowsException = true)]
		public void Destroy()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = true, ThrowsException = true)]
		public bool IsPlaying()
		{
			return false;
		}

		[FreeFunction("PlayableGraphBindings::Play", HasExplicitThis = true, ThrowsException = true)]
		public void Play()
		{
		}

		[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = true, ThrowsException = true)]
		public void Evaluate([DefaultValue("0")] float deltaTime)
		{
		}

		[FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", HasExplicitThis = true, ThrowsException = true)]
		public void SetTimeUpdateMode(DirectorUpdateMode value)
		{
		}

		[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = true, ThrowsException = true)]
		public IExposedPropertyTable GetResolver()
		{
			return null;
		}

		[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = true, ThrowsException = true)]
		public int GetPlayableCount()
		{
			return 0;
		}

		[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = true, ThrowsException = true)]
		public int GetRootPlayableCount()
		{
			return 0;
		}

		[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = true, ThrowsException = true)]
		internal void SynchronizeEvaluation(PlayableGraph playable)
		{
		}

		[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableHandle CreatePlayableHandle()
		{
			return default(PlayableHandle);
		}

		[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = true, ThrowsException = true)]
		internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}

		[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableHandle GetRootPlayableInternal(int index)
		{
			return default(PlayableHandle);
		}

		[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = true, ThrowsException = true)]
		internal bool IsMatchFrameRateEnabled()
		{
			return false;
		}

		[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = true, ThrowsException = true)]
		internal FrameRate GetFrameRate()
		{
			return default(FrameRate);
		}

		[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = true, ThrowsException = true)]
		private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return false;
		}

		private static void Create_Injected(ref ManagedSpanWrapper name, out PlayableGraph ret)
		{
			ret = default(PlayableGraph);
		}

		private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, [In] ref PlayableGraph playable)
		{
		}

		private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
		{
			ret = default(PlayableHandle);
		}

		private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
		{
			handle = default(PlayableOutputHandle);
			return false;
		}

		private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
		{
			ret = default(PlayableHandle);
		}

		private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret)
		{
			ret = default(FrameRate);
		}

		private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, [In] ref PlayableHandle source, int sourceOutputPort, [In] ref PlayableHandle destination, int destinationInputPort)
		{
			return false;
		}
	}
}
