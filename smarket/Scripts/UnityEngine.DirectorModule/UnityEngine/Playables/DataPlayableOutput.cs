using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
	[NativeHeader("Modules/Director/DataPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[StaticAccessor("DataPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	internal struct DataPlayableOutput : IPlayableOutput
	{
		private PlayableOutputHandle m_Handle;

		internal DataPlayableOutput(PlayableOutputHandle handle)
		{
			m_Handle = default(PlayableOutputHandle);
		}

		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		[RequiredByNativeCode]
		private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer)
		{
		}
	}
}
