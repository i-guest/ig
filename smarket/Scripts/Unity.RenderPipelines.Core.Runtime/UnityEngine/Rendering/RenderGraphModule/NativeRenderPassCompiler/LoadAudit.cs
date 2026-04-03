using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	[DebuggerDisplay("{reason} : {passId}")]
	internal readonly struct LoadAudit
	{
		public static readonly string[] LoadReasonMessages;

		public readonly LoadReason reason;

		public readonly int passId;

		public LoadAudit(LoadReason setReason, int setPassId = -1)
		{
			reason = default(LoadReason);
			passId = 0;
		}
	}
}
