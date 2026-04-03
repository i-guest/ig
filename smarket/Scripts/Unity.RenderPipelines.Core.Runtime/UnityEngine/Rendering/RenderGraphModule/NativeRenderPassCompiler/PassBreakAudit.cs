using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	[DebuggerDisplay("{reason} : {breakPass}")]
	internal readonly struct PassBreakAudit
	{
		public readonly PassBreakReason reason;

		public readonly int breakPass;

		public static readonly string[] BreakReasonMessages;

		public PassBreakAudit(PassBreakReason reason, int breakPass)
		{
			this.reason = default(PassBreakReason);
			this.breakPass = 0;
		}
	}
}
