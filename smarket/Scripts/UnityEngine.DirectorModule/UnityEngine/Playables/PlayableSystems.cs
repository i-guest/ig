using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[StaticAccessor("PlayableSystemsBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Director/ScriptBindings/PlayableSystems.bindings.h")]
	internal static class PlayableSystems
	{
		public delegate void PlayableSystemDelegate(IReadOnlyList<DataPlayableOutput> outputs);

		public enum PlayableSystemStage : ushort
		{
			FixedUpdate = 0,
			FixedUpdatePostPhysics = 1,
			Update = 2,
			AnimationBegin = 3,
			AnimationEnd = 4,
			LateUpdate = 5,
			Render = 6
		}

		private class DataPlayableOutputList : IReadOnlyList<DataPlayableOutput>, IEnumerable<DataPlayableOutput>, IEnumerable, IReadOnlyCollection<DataPlayableOutput>
		{
			private class DataPlayableOutputEnumerator : IEnumerator<DataPlayableOutput>, IEnumerator, IDisposable
			{
				private DataPlayableOutputList m_List;

				private int m_Index;

				public DataPlayableOutput Current => default(DataPlayableOutput);

				object IEnumerator.Current => null;

				public DataPlayableOutputEnumerator(DataPlayableOutputList list)
				{
				}

				public void Dispose()
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

			private unsafe PlayableOutputHandle* m_Outputs;

			private int m_Count;

			public DataPlayableOutput this[int index] => default(DataPlayableOutput);

			public int Count => 0;

			public unsafe DataPlayableOutputList(PlayableOutputHandle* outputs, int count)
			{
			}

			public IEnumerator<DataPlayableOutput> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static Dictionary<int, Type> s_SystemTypes;

		private static Dictionary<int, PlayableSystemDelegate> s_Delegates;

		private static ReaderWriterLockSlim s_RWLock;

		private static int CombineTypeAndIndex(int typeIndex, PlayableSystemStage stage)
		{
			return 0;
		}

		[RequiredByNativeCode]
		private static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystemStage stage, IntPtr outputsPtr, int numOutputs)
		{
			return false;
		}

		static PlayableSystems()
		{
		}
	}
}
